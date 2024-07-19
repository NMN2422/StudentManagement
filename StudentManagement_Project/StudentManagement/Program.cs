using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagement.Account;

namespace StudentManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            load();
            
        }
        public static void load()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK && login.rbStudent.Checked)
            {
                Loading load = new Loading();
                login.Close();
                Application.Run(load);
            }
            else if (login.DialogResult == DialogResult.OK && login.rbHr.Checked)
            {
                LoadingHr loadhr= new LoadingHr();
                login.Close();
                Application.Run(loadhr);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
