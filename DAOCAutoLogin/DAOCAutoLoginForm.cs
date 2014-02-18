using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using NAudio.Wave;
using System.Reflection;

namespace DAOCAutoConnector
{
    public partial class DAOCAutoLoginForm : Form

    {
        private readonly static String daocRegPath = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\camelot.exe";
        private static Thread autoLoginProcess = null;
        private IWavePlayer waveOutDevice;
        private Mp3FileReader audioFileReader;
        
        private static CustomAboutBox aboutBox = new CustomAboutBox();
        
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        delegate void ResetButtonCallback();

        public DAOCAutoLoginForm()
        {
            InitializeComponent();
           hostBox.Text = "62.210.143.112";
           portNumberBox.Text = "10300";
            waveOutDevice  = new WaveOut();
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            
            try
            {
                audioFileReader = new Mp3FileReader(myAssembly.GetManifestResourceStream("DAOCAutoLogin.itsready.mp3"));
                waveOutDevice.Init(audioFileReader);
            }catch(Exception e){
                //crappy catching base exception.
                windowsAlertRadioButton.Select();
                loudAlertRadioButton.Enabled = false;
                ToolTip loudAlertDisabledToolTip = new ToolTip();              
                loudAlertDisabledToolTip.SetToolTip(loudAlertRadioButton, "Loud alert is not available.");
                
            }
            String gameDllPath = Registry.GetValue(daocRegPath, null, "game.dll").ToString();
            if (gameDllPath != null)
            {
                openGameDLLDialog.FileName = gameDllPath.Replace("camelot.exe", "game.dll");
                gameDllPathBox.Text = openGameDLLDialog.FileName;
            }
        }


        void resetButton()
        {
            if (autoLoginButton.InvokeRequired)
            {
                ResetButtonCallback d = new ResetButtonCallback(resetButton);
                this.Invoke(d, null);
            }
            if (loudAlertRadioButton.Checked)
            {
                waveOutDevice.Play();
            }
            else
            {
                System.Media.SystemSounds.Exclamation.Play(); 
            }
            autoLoginButton.Text = "Start";
            changeControlsState(true);    
            autoLoginProcess = null;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openGameDLLDialog.ShowDialog() == DialogResult.OK)
            {
                gameDllPathBox.Text = openGameDLLDialog.FileName;
            }
        }

        private void connectPathBrowseButton_Click(object sender, EventArgs e)
        {
            if (openConnectExeFileDialog.ShowDialog() == DialogResult.OK)
            {
                connectPathBox.Text = openConnectExeFileDialog.FileName;
            }
        }

        private void autoLoginButton_Click(object sender, EventArgs e)
        {
            if (connectPathBox.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("You must provide the path to Connect.exe (in DAoC Portal Install Directory)");
            }
            else
            {

                if (autoLoginProcess == null)
                {
                    autoLoginButton.Text = "Stop";
                    changeControlsState(false);
                    String arguments = "\"" + gameDllPathBox.Text + "\" " + hostBox.Text + ":" + portNumberBox.Text + " " + usernameBox.Text + " " + passwordBox.Text;
                    autoLoginProcess = new Thread(() => autoLogin(connectPathBox.Text, arguments));
                    autoLoginProcess.IsBackground = true;
                    autoLoginProcess.Start();

                }
                else
                {
                    autoLoginButton.Text = "Start";
                    changeControlsState(true);
                    autoLoginProcess.Abort();
                    autoLoginProcess = null;
                }
            }
        }

        private void changeControlsState(Boolean state)
        {
            gameDllButton.Enabled = state;
            connectPathBrowseButton.Enabled = state;
            portNumberBox.Enabled = state;
            passwordBox.Enabled = state;
            usernameBox.Enabled = state;
            hostBox.Enabled = state;
            loudAlertRadioButton.Enabled = state;
            windowsAlertRadioButton.Enabled = state;
        }

        public void autoLogin(String connectExePath, String argumentString)
        {
            while (true)
            {
                Process proc = new Process();
                proc.StartInfo.FileName = connectExePath;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.Arguments = argumentString;
               
                proc.Start();

                Thread.Sleep(35000);

                Process gameDll = null;
                int waitForConnectCounter = 0;
                while (true)
                {
                    if (waitForConnectCounter >= 10)
                    {
                        break;
                    }
                    Process[] processes = Process.GetProcessesByName("game.dll");
                    if (processes.Length > 0)
                    {
                        gameDll = processes[0];
                        Thread.Sleep(2000);
                        SetForegroundWindow(gameDll.MainWindowHandle);                 
                        SendKeys.SendWait("{ESCAPE}");
                        break;
                    }
                    Thread.Sleep(1000);
                    waitForConnectCounter++;
                }     
                Thread.Sleep(2000);
                Process[] afterProcesses = Process.GetProcessesByName("game.dll");
                if (afterProcesses.Length > 0)
                {                   
                    resetButton();
                    Thread.CurrentThread.Join();                    
                }
            }
        }

        private void DAOCConnectorForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            
            if (aboutBox != null)
            {
                aboutBox.ShowDialog();
                
            }
            else
            {
                aboutBox = new CustomAboutBox();
                aboutBox.ShowDialog();
            }
            e.Cancel = true;
        }

        private void DAOCConnectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

       

      
     

      
     
    }
}
