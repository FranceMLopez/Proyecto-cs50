using Jenga;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Payroll_Management_System.Pages
{
    public partial class Page_Payroll : UserControl
    {
        public Page_Payroll()
        {
            //disable rendering
            if (IsInDesignMode()) return;
            InitializeComponent();

            //add past years
            for (int i = DateTime.Today.Year; i > DateTime.Today.Year - 30; i--)
                cmbYear.Items.Add(i);
            cmbYear.SelectedIndex = 0;
            //hide columns not needed
            page_Payslip1.lnkYear.Visible = false;
            page_Payslip1.lnkMonth.Visible = false;

            //add payslip print option
            page_Payslip1.CustomContextMenu.Add("Print Preview", (p) =>
             {
                 GeneratePayslip(new List<Models.Payslip> { p });
                 report.ShowPrintPreviewDialog();
             });
        }

        private void Loaddata()
        {
            //load Data to grid

            var payslips = Kt.Db.Select<Models.Payslip>(r => r.Year == (int)cmbYear.SelectedItem);
            grid.Rows.Clear();
            foreach (var payroll in payslips.GroupBy(r => r.GetPeriod()))
            {
                var idx = grid.Rows.Add(
                      new object[]
                      {
                        null,
                        payroll.Key,
                        payroll.Count(),
                        payroll.Sum(r=>r.Basic),
                        payroll.Sum(r=>r.Allowances),
                        payroll.Sum(r=>r.Deductions),
                        payroll.Sum(r=>r.Gross),
                      });

                grid.Rows[idx].Tag = payroll.Key;
            }
            if (grid.SelectedRows.Count == 0)
            {
                page_Payslip1.LoadData();
                return;
            }
            //filter only selected payroll
            page_Payslip1.SetDataFilter(r => r.GetPeriod() == grid.CurrentRow.Tag.ToString());
        }

        private static bool IsInDesignMode()
              => (Application.ExecutablePath.IndexOf("devenv.exe", StringComparison.OrdinalIgnoreCase) > -1);

        private void colYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void colMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Page_Payroll_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Forms.Frm_Generate_Payroll().ShowDialog();
            Loaddata();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grid.SelectedRows.Count == 0) return;
            //filter only selected payroll
            page_Payslip1.SetDataFilter(r => r.GetPeriod() == grid.CurrentRow.Tag.ToString());
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (grid.SelectedRows.Count == 0);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Deleete {grid.CurrentRow.Tag.ToString()} payroll?", "Confirm!!", MessageBoxButtons.YesNoCancel) != DialogResult.Yes) return;
            var slips = Kt.Db.Select<Models.Payslip>(r => r.Year == (int)cmbYear.SelectedItem).Where(r => r.GetPeriod() == grid.CurrentRow.Tag.ToString());
            Kt.Db.DeleteAll<Models.Payslip>(slips);
            Loaddata();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratePayslip(page_Payslip1.GetCurrentRecords());
            report.ShowPrintPreviewDialog();
        }

        private void GeneratePayslip(IEnumerable<Models.Payslip> payslips)
        {
            report.Clear();

            foreach (var payslip in payslips)
            {
                var employee = payslip.GetEmployee();
                var company = Kt.Db.Select<Models.Company>().FirstOrDefault();
                report.AddHorizontalRule();
                report.AddLineBreak();
                report.AddImage(company.Logo.ToImage(), "width=50");
                report.AddString($"<h1 style='float:right'>PAYSLIP</h1>");
                report.AddString($"<h2>{company.CompanyName}</h2>");
                report.AddString($"<h4 style='margin-top:-10' >💬 {company.Email} | 📞 {company.Phone}</h4>");
                report.AddString($"<h4 style='margin-top:-10'>{company.Address}</h4>");

                report.AddLineBreak();
                report.AddHorizontalRule();
                report.AddLineBreak();
                report.AddString("<h3>Employee Information</h3>");

                //Employee Information
                DataTable dt = new DataTable();
                dt.Columns.Add("EMPLOYEE ID");
                dt.Columns.Add("FULL NAME");
                dt.Columns.Add("PHONE");
                dt.Columns.Add("EMAIL");
                dt.Columns.Add("ADDRESS");

                dt.Rows.Add(
                    new object[] {
                        employee.EmployeeID.ToString().PadLeft(4,'0'),
                        employee.FullName,
                        employee.Phone,
                        employee.Email,
                        employee.Address
                  });

                report.AddDataTable(dt);
                report.AddLineBreak();
                report.AddHorizontalRule();
                report.AddLineBreak();
                report.AddString("<h3>Payslip Information</h3>");

                dt.Columns.Clear();
                dt = new DataTable();
                dt.Columns.Add("DEPARTMENT");
                dt.Columns.Add("DESIGNATION");
                dt.Columns.Add("PERIOD");
                dt.Columns.Add("PAY TYPE");
                dt.Columns.Add("PAYSLIP ID");

                dt.Rows.Add(
                  new object[] {
                        employee.GetDepartment().Name,
                        employee.Designation,
                        payslip.GetPeriod().ToUpper(),
                        "MONTHLY",
                        payslip.EmployeeID.ToString().PadLeft(6,'0')
            });

                report.AddDataTable(dt);
                report.AddLineBreak();

                dt.Columns.Clear();
                dt = new DataTable();
                dt.Columns.Add("<b>EARNINGS</b>");
                dt.Columns.Add(" ");

                dt.Rows.Add("BASIC SALARY", employee.BasicSalary.ToString("C2"));

                foreach (var allowance in employee.GetAllowanceList())
                {
                    dt.Rows.Add(new object[] {
                        allowance.Name.ToUpper(),
                        allowance.Amount.ToString("C2")
                    });
                }
                dt.Rows.Add(new object[] {
                        "<b>GROSS PAY</b>",
                        payslip.Gross.ToString("C2")
                    });
                report.AddDataTable(dt);
                report.AddLineBreak();
                dt.Columns.Clear();
                dt = new DataTable();
                dt.Columns.Add("<b>DEDUCTIONS</b>");
                dt.Columns.Add(" ");

                foreach (var DED in employee.GetDeductionList())
                {
                    dt.Rows.Add(new object[] {
                        DED.Name.ToUpper(),
                        DED.Amount.ToString("C2")
                    });
                }
                dt.Rows.Add(new object[] {
                        "<b>TOTAL DEDUCTIONS</b>",
                        payslip.Deductions.ToString("C2")
                    });
                report.AddDataTable(dt);

                report.AddLineBreak();
                dt.Columns.Clear();
                dt = new DataTable();
                dt.Columns.Add("<b><H3>NET PAY</H2></3>");
                dt.Columns.Add($"<H3>{payslip.Net.ToString("C2")}</H3>");
                report.AddDataTable(dt);
                report.AddLineBreak();

                if (payslips.LastOrDefault() != payslip)
                    report.NewPage();
            }
        }
    }
}