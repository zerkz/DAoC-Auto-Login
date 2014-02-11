using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DAOCAutoConnector
{
    static class DAOCAutoLogin
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DAOCAutoLoginForm form = new DAOCAutoLoginForm();           
            Application.Run(form);
            


        }







    }
}
