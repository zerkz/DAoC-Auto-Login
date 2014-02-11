namespace DAOCAutoConnector
{
    partial class DAOCAutoLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAOCAutoLoginForm));
            this.gameDllButton = new System.Windows.Forms.Button();
            this.openGameDLLDialog = new System.Windows.Forms.OpenFileDialog();
            this.gameDllPathBox = new System.Windows.Forms.TextBox();
            this.gameDLLGroupBox = new System.Windows.Forms.GroupBox();
            this.connectPathGroupBox = new System.Windows.Forms.GroupBox();
            this.connectPathBrowseButton = new System.Windows.Forms.Button();
            this.connectPathBox = new System.Windows.Forms.TextBox();
            this.openConnectExeFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.accountGroupBox = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.autoLoginButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.masterFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.serverGroupBox = new System.Windows.Forms.GroupBox();
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.portNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.alertOptionBox = new System.Windows.Forms.GroupBox();
            this.loudAlertRadioButton = new System.Windows.Forms.RadioButton();
            this.windowsAlertRadioButton = new System.Windows.Forms.RadioButton();
            this.gameDLLGroupBox.SuspendLayout();
            this.connectPathGroupBox.SuspendLayout();
            this.accountGroupBox.SuspendLayout();
            this.masterFlowLayout.SuspendLayout();
            this.serverGroupBox.SuspendLayout();
            this.alertOptionBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameDllButton
            // 
            this.gameDllButton.Location = new System.Drawing.Point(6, 19);
            this.gameDllButton.Name = "gameDllButton";
            this.gameDllButton.Size = new System.Drawing.Size(75, 23);
            this.gameDllButton.TabIndex = 0;
            this.gameDllButton.Text = "Browse";
            this.gameDllButton.UseVisualStyleBackColor = true;
            this.gameDllButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openGameDLLDialog
            // 
            this.openGameDLLDialog.FileName = "game.dll";
            this.openGameDLLDialog.Filter = "Game.DLL Files|game.dll|All Files|*.*";
            // 
            // gameDllPathBox
            // 
            this.gameDllPathBox.Enabled = false;
            this.gameDllPathBox.Location = new System.Drawing.Point(94, 21);
            this.gameDllPathBox.Name = "gameDllPathBox";
            this.gameDllPathBox.Size = new System.Drawing.Size(188, 20);
            this.gameDllPathBox.TabIndex = 1;
            // 
            // gameDLLGroupBox
            // 
            this.gameDLLGroupBox.Controls.Add(this.gameDllButton);
            this.gameDLLGroupBox.Controls.Add(this.gameDllPathBox);
            this.gameDLLGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.gameDLLGroupBox.Location = new System.Drawing.Point(3, 51);
            this.gameDLLGroupBox.Name = "gameDLLGroupBox";
            this.gameDLLGroupBox.Size = new System.Drawing.Size(288, 50);
            this.gameDLLGroupBox.TabIndex = 1;
            this.gameDLLGroupBox.TabStop = false;
            this.gameDLLGroupBox.Text = "Path to Game.DLL";
            // 
            // connectPathGroupBox
            // 
            this.connectPathGroupBox.Controls.Add(this.connectPathBrowseButton);
            this.connectPathGroupBox.Controls.Add(this.connectPathBox);
            this.connectPathGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectPathGroupBox.Location = new System.Drawing.Point(3, 107);
            this.connectPathGroupBox.Name = "connectPathGroupBox";
            this.connectPathGroupBox.Size = new System.Drawing.Size(288, 50);
            this.connectPathGroupBox.TabIndex = 2;
            this.connectPathGroupBox.TabStop = false;
            this.connectPathGroupBox.Text = "Path to Connect.exe";
            // 
            // connectPathBrowseButton
            // 
            this.connectPathBrowseButton.Location = new System.Drawing.Point(6, 19);
            this.connectPathBrowseButton.Name = "connectPathBrowseButton";
            this.connectPathBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.connectPathBrowseButton.TabIndex = 0;
            this.connectPathBrowseButton.Text = "Browse";
            this.connectPathBrowseButton.UseVisualStyleBackColor = true;
            this.connectPathBrowseButton.Click += new System.EventHandler(this.connectPathBrowseButton_Click);
            // 
            // connectPathBox
            // 
            this.connectPathBox.Enabled = false;
            this.connectPathBox.Location = new System.Drawing.Point(94, 21);
            this.connectPathBox.Name = "connectPathBox";
            this.connectPathBox.Size = new System.Drawing.Size(188, 20);
            this.connectPathBox.TabIndex = 1;
            // 
            // openConnectExeFileDialog
            // 
            this.openConnectExeFileDialog.FileName = "connect.exe";
            this.openConnectExeFileDialog.Filter = ".exe Files|connect.exe|All Files|*.*";
            // 
            // accountGroupBox
            // 
            this.accountGroupBox.Controls.Add(this.passwordLabel);
            this.accountGroupBox.Controls.Add(this.usernameLabel);
            this.accountGroupBox.Controls.Add(this.passwordBox);
            this.accountGroupBox.Controls.Add(this.autoLoginButton);
            this.accountGroupBox.Controls.Add(this.usernameBox);
            this.accountGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.accountGroupBox.Location = new System.Drawing.Point(3, 163);
            this.accountGroupBox.Name = "accountGroupBox";
            this.accountGroupBox.Size = new System.Drawing.Size(288, 78);
            this.accountGroupBox.TabIndex = 3;
            this.accountGroupBox.TabStop = false;
            this.accountGroupBox.Text = "Account Details";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(9, 47);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(9, 22);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(71, 48);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(127, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // autoLoginButton
            // 
            this.autoLoginButton.Location = new System.Drawing.Point(204, 22);
            this.autoLoginButton.Name = "autoLoginButton";
            this.autoLoginButton.Size = new System.Drawing.Size(75, 38);
            this.autoLoginButton.TabIndex = 4;
            this.autoLoginButton.Text = "Start";
            this.autoLoginButton.UseVisualStyleBackColor = true;
            this.autoLoginButton.Click += new System.EventHandler(this.autoLoginButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(71, 22);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(127, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // masterFlowLayout
            // 
            this.masterFlowLayout.Controls.Add(this.serverGroupBox);
            this.masterFlowLayout.Controls.Add(this.gameDLLGroupBox);
            this.masterFlowLayout.Controls.Add(this.connectPathGroupBox);
            this.masterFlowLayout.Controls.Add(this.accountGroupBox);
            this.masterFlowLayout.Controls.Add(this.alertOptionBox);
            this.masterFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterFlowLayout.Location = new System.Drawing.Point(0, 0);
            this.masterFlowLayout.Name = "masterFlowLayout";
            this.masterFlowLayout.Size = new System.Drawing.Size(294, 291);
            this.masterFlowLayout.TabIndex = 4;
            // 
            // serverGroupBox
            // 
            this.serverGroupBox.Controls.Add(this.hostLabel);
            this.serverGroupBox.Controls.Add(this.hostBox);
            this.serverGroupBox.Controls.Add(this.portNumberLabel);
            this.serverGroupBox.Controls.Add(this.portNumberBox);
            this.serverGroupBox.Location = new System.Drawing.Point(3, 3);
            this.serverGroupBox.Name = "serverGroupBox";
            this.serverGroupBox.Size = new System.Drawing.Size(279, 42);
            this.serverGroupBox.TabIndex = 2;
            this.serverGroupBox.TabStop = false;
            this.serverGroupBox.Text = "Server";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Location = new System.Drawing.Point(6, 16);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(32, 13);
            this.hostLabel.TabIndex = 3;
            this.hostLabel.Text = "Host:";
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(44, 13);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(138, 20);
            this.hostBox.TabIndex = 2;
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Location = new System.Drawing.Point(188, 16);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(29, 13);
            this.portNumberLabel.TabIndex = 1;
            this.portNumberLabel.Text = "Port:";
            // 
            // portNumberBox
            // 
            this.portNumberBox.Location = new System.Drawing.Point(223, 13);
            this.portNumberBox.Mask = "00000";
            this.portNumberBox.Name = "portNumberBox";
            this.portNumberBox.Size = new System.Drawing.Size(50, 20);
            this.portNumberBox.TabIndex = 0;
            this.portNumberBox.ValidatingType = typeof(int);
            // 
            // alertOptionBox
            // 
            this.alertOptionBox.Controls.Add(this.loudAlertRadioButton);
            this.alertOptionBox.Controls.Add(this.windowsAlertRadioButton);
            this.alertOptionBox.Location = new System.Drawing.Point(3, 247);
            this.alertOptionBox.Name = "alertOptionBox";
            this.alertOptionBox.Size = new System.Drawing.Size(288, 38);
            this.alertOptionBox.TabIndex = 4;
            this.alertOptionBox.TabStop = false;
            this.alertOptionBox.Text = "Alert Type";
            // 
            // loudAlertRadioButton
            // 
            this.loudAlertRadioButton.AutoSize = true;
            this.loudAlertRadioButton.Location = new System.Drawing.Point(159, 19);
            this.loudAlertRadioButton.Name = "loudAlertRadioButton";
            this.loudAlertRadioButton.Size = new System.Drawing.Size(103, 17);
            this.loudAlertRadioButton.TabIndex = 1;
            this.loudAlertRadioButton.TabStop = true;
            this.loudAlertRadioButton.Text = "Loud and Vulgar";
            this.loudAlertRadioButton.UseVisualStyleBackColor = true;
            // 
            // windowsAlertRadioButton
            // 
            this.windowsAlertRadioButton.AutoSize = true;
            this.windowsAlertRadioButton.Checked = true;
            this.windowsAlertRadioButton.Location = new System.Drawing.Point(12, 19);
            this.windowsAlertRadioButton.Name = "windowsAlertRadioButton";
            this.windowsAlertRadioButton.Size = new System.Drawing.Size(125, 17);
            this.windowsAlertRadioButton.TabIndex = 0;
            this.windowsAlertRadioButton.TabStop = true;
            this.windowsAlertRadioButton.Text = "Windows Beep (Soft)";
            this.windowsAlertRadioButton.UseVisualStyleBackColor = true;
            // 
            // DAOCConnectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 291);
            this.Controls.Add(this.masterFlowLayout);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DAOCConnectorForm";
            this.Text = "DAOC Auto Connector";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.DAOCConnectorForm_HelpButtonClicked);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DAOCConnectorForm_FormClosing);
            this.gameDLLGroupBox.ResumeLayout(false);
            this.gameDLLGroupBox.PerformLayout();
            this.connectPathGroupBox.ResumeLayout(false);
            this.connectPathGroupBox.PerformLayout();
            this.accountGroupBox.ResumeLayout(false);
            this.accountGroupBox.PerformLayout();
            this.masterFlowLayout.ResumeLayout(false);
            this.serverGroupBox.ResumeLayout(false);
            this.serverGroupBox.PerformLayout();
            this.alertOptionBox.ResumeLayout(false);
            this.alertOptionBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button gameDllButton;
        private System.Windows.Forms.OpenFileDialog openGameDLLDialog;
        private System.Windows.Forms.TextBox gameDllPathBox;
        private System.Windows.Forms.GroupBox gameDLLGroupBox;
        private System.Windows.Forms.GroupBox connectPathGroupBox;
        private System.Windows.Forms.Button connectPathBrowseButton;
        private System.Windows.Forms.TextBox connectPathBox;
        private System.Windows.Forms.OpenFileDialog openConnectExeFileDialog;
        private System.Windows.Forms.GroupBox accountGroupBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.FlowLayoutPanel masterFlowLayout;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button autoLoginButton;
        private System.Windows.Forms.GroupBox alertOptionBox;
        private System.Windows.Forms.RadioButton loudAlertRadioButton;
        private System.Windows.Forms.RadioButton windowsAlertRadioButton;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.MaskedTextBox portNumberBox;

        
        


    }
}

