using System;
using System.Windows.Forms;

namespace Payroll_Management_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        db: try
            {
                var db = Kt.Db;
                Application.Run(new FrmMain());
            }
            catch (Exception err)
            {
                if (MessageBox.Show(err.Message + ". Click Retry to configure.", Application.ProductName, MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    Kimtoo.DbManager.Connections.Show();
                    goto db;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}