using Jenga;
using ServiceStack.OrmLite;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Payroll_Management_System
{
    public partial class FrmMain : Form
    {
        private Models.Company _company;

        public FrmMain()

        {
            InitializeComponent();

            //check if first install then add defalt company
            _company = Kt.Db.Select<Models.Company>().FirstOrDefault();
            if (_company == null)
            {
                _company = new Models.Company
                {
                    CompanyName = "Company Name"
                };

                Kt.Db.Save(_company);
            }

            bunifuAppBar1.Title = _company.CompanyName + " - Payroll";
            bunifuAppBar1.Icon = _company.Logo?.ToImage();

            //set up allowances and deduction actions  for employees
            page_Employee1.CustomContextMenu.Add("Manage Allowances and Deductions", (emp) =>
            {
                new Forms.Frm_ManageAD(emp).ShowDialog();
            });
        }

        private void nav_OnItemSelected(object sender, string path, EventArgs e)
        {
            if (path == "Company")
            {
                //load the company record
                var company = Kt.Db.Select<Models.Company>().FirstOrDefault();
                new Forms.Frm_Company(company).ShowDialog();
                return;
            }
            if (path == "Database")
            {
                //load the database connections
                Kimtoo.DbManager.Connections.Show();
                _company = Kt.Db.Select<Models.Company>().FirstOrDefault();
                bunifuAppBar1.Title = _company.CompanyName + " - Payroll";
                bunifuAppBar1.Icon = _company.Logo?.ToImage();
                return;
            }

            //set the relevant page
            pages.SetPage(path);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            bunifuFormDock1.WindowState = Bunifu.UI.WinForms.BunifuFormDock.FormWindowStates.Maximized;
        }

        private void page_Payroll1_Load(object sender, EventArgs e)
        {

        }
    }
}