using Payroll_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms
{
    public partial class Frm_ManageAD : Form
    {
        private readonly Employee employee;

        public Frm_ManageAD(Models.Employee employee)
        {
            InitializeComponent();
            this.employee = employee;

            //filter only the employee data
            page_Allowance1.SetDataFilter(r => r.EmployeeID == employee.EmployeeID);
            page_Deduction1.SetDataFilter(r => r.EmployeeID == employee.EmployeeID);

            page_Allowance1.lnkEmployeeID.Visible = false;
            page_Deduction1.lnkEmployeeID.Visible = false;

            //set default values for the form -  read only
            page_Deduction1.FixedValues = page_Allowance1.FixedValues = new Dictionary<string, object>
            {
                {"EmployeeID",employee.EmployeeID }
            };

            AppBar.Title += " - " + employee.FullName;
        }

        private void nav_OnSelectionChange(object sender, EventArgs e)
        {
            pages.SetPage(sender.ToString());
        }

        private void AppBar_IconClick(object sender, EventArgs e)
        {

        }
    }
}