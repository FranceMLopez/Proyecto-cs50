using ServiceStack.OrmLite;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Payroll_Management_System.Forms
{
    public partial class Frm_Generate_Payroll : Form
    {
        public Frm_Generate_Payroll()
        {
            InitializeComponent();
            AppBar.Title = $"Generate Payroll";

            cmbMonth.SelectedIndex = DateTime.Today.Month - 1;
            //add past years
            for (int i = DateTime.Today.Year; i > DateTime.Today.Year - 30; i--)
                cmbYear.Items.Add(i);
            cmbYear.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //VALIDATION
            if (validationProvider1.Validate().Count() > 0)
                return;
            //check if payroll exists
            var payrolls = Kt.Db.Select<Models.Payslip>(r => r.Year == (int)cmbYear.SelectedItem && r.Month == cmbMonth.Text);
            if (payrolls.Count() > 0)
            {
                Alert.Show(this, $"{(int)cmbYear.SelectedItem}-{cmbMonth.Text} Payroll already exists. You can delete and re-generte again.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                return;
            }

            if (MessageBox.Show($"Generate Payroll for {(int)cmbYear.SelectedItem}-{cmbMonth.Text}", "Confirm!!", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
                return;

            pnlContent.Enabled = false;
            //get get all active employess
            var employees = Kt.Db.Select<Models.Employee>(r => r.EmploymentStatus == "Active");
            progressBar1.Maximum = employees.Count();
            //generate payslip per employee
            foreach (var employee in employees)
            {
                Kt.Db.Save(
                    new Models.Payslip
                    {
                        EmployeeID = employee.EmployeeID,
                        Month = cmbMonth.Text,
                        Year = (int)cmbYear.SelectedItem,
                        Basic = employee.BasicSalary,
                        Allowances = employee.GetAllowances(),
                        Deductions = employee.GetDeductions(),
                        Gross = employee.GetGrossPay(),
                        Net = employee.GetNetPay()
                    });
                progressBar1.Value += 1;
                Application.DoEvents();
            }

            this.Close();
        }

        private void AppBar_IconClick(object sender, EventArgs e)
        {

        }
    }
}