using Kimtoo.BindingProvider;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Payroll_Management_System.Models
{
    [AutoGenerateTable(1)]
    [JengaEntity]
    [Alias("Employees")]
    public class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmployeeID { get; set; }

        [JengaImage(150, 150)]
        public byte[] Photo { get; set; }

        [JengaIdentifier]
        public string FullName { get; set; } = "";

        [JengaOptions("Male,Female,Other")]
        public string Gender { get; set; } = "Male";

        [JengaOptions("Single,Married,Divorced,Widow,Widower")]
        public string MaritalStatus { get; set; } = "Single";

        public DateTime BirthDate { get; set; } = DateTime.Now;

        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";

        [JengaTextArea]
        public string Address { get; set; } = "";

        public string KinName { get; set; } = "";
        public string KinPhone { get; set; } = "";

        public DateTime JoinDate { get; set; } = DateTime.Now;

        [JengaOptions("Active,Deceased,Laid-off,Fired,Quit,Retired")]
        [JengaLink("Status", "GetStatus")]
        public string EmploymentStatus { get; set; } = "Active";

        [ForeignKey(typeof(Department), OnDelete = "CASCADE")]
        [JengaLink("Department", "GetDepartmentName")]
        public int DepartmentID { get; set; }

        public string Designation { get; set; } = "";

        public bool OnLeave { get; set; } = false;
        public double BasicSalary { get; set; }

        [JengaTextArea]
        public string Notes { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //methods
        public DataGridViewBadge GetStatus()
        {
            return new DataGridViewBadge
            {
                BackColor = this.EmploymentStatus == "Active" ? Color.Teal : Color.Crimson,
                ForeColor = Color.White,
                Value = this.EmploymentStatus,
                Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
            };
        }

        public Department GetDepartment()
            => Kt.Db.SingleById<Department>(this.DepartmentID);

        public DataGridViewBadge GetDepartmentName()
        {
            return new DataGridViewBadge
            {
                BackColor = Color.Teal,
                ForeColor = Color.White,
                Value = GetDepartment().Name,
                Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold)
            };
        }

        [JengaVirtualColumn("Allowances", "", 9)]
        public double GetAllowances()
        {
            var data = Kt.Db.Select<Allowance>(r => r.EmployeeID == this.EmployeeID);
            return data.Sum(r => r.Amount);
        }

        public IEnumerable<Allowance> GetAllowanceList()
        {
            var data = Kt.Db.Select<Allowance>(r => r.EmployeeID == this.EmployeeID);
            return data;
        }

        [JengaVirtualColumn("Deductions", "", 10)]
        public double GetDeductions()
        {
            var data = Kt.Db.Select<Deduction>(r => r.EmployeeID == this.EmployeeID);
            return data.Sum(r => r.Amount);
        }

        public IEnumerable<Deduction> GetDeductionList()
        {
            var data = Kt.Db.Select<Deduction>(r => r.EmployeeID == this.EmployeeID);
            return data;
        }

        [JengaVirtualColumn("Gross", "", 11)]
        public double GetGrossPay()
        {
            return this.BasicSalary + GetAllowances();
        }

        [JengaVirtualColumn("Net", "", 12)]
        public double GetNetPay()
        {
            return GetGrossPay() - GetDeductions();
        }
    }
}