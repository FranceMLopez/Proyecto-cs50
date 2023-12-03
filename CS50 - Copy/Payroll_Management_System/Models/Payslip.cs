using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System;

namespace Payroll_Management_System.Models
{
    [AutoGenerateTable(2)]
    [JengaEntity]
    [Alias("Payslips")]
    public class Payslip
    {
        [PrimaryKey, AutoIncrement]
        public int PayslipID { get; set; }

        [ForeignKey(typeof(Employee), OnDelete = "CASCADE")]
        [JengaLink("Employee", "GetEmployeeName")]
        public int EmployeeID { get; set; }

        public int Year { get; set; } = DateTime.Today.Year;

        [JengaOptions("Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec")]
        public string Month { get; set; }

        public double Basic { get; set; }
        public double Allowances { get; set; }
        public double Deductions { get; set; }
        public double Gross { get; set; }
        public double Net { get; set; }

        public Employee GetEmployee()
        {
            return Kt.Db.SingleById<Employee>(this.EmployeeID);
        }

        public string GetPeriod()
        {
            return this.Year + "-" + this.Month;
        }

        public string GetEmployeeName()
        { return GetEmployee().FullName; }
    }
}