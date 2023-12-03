using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace Payroll_Management_System.Models
{
    [AutoGenerateTable(2)]
    [JengaEntity]
    [Alias("Allowances")]
    public class Allowance
    {
        [PrimaryKey, AutoIncrement]
        public int AllowanceID { get; set; }

        [JengaLink("Employee", "GetEmployeeName")]
        [ForeignKey(typeof(Employee), OnDelete = "CASCADE")]
        public int EmployeeID { get; set; }

        [JengaIdentifier]
        public string Name { get; set; } = "";

        public double Amount { get; set; }

        //---methods ---
        public Employee GetEmployee()
        {
            return Kt.Db.SingleById<Employee>(this.EmployeeID);
        }

        public string GetEmployeeName()
        { return GetEmployee().FullName; }
    }
}