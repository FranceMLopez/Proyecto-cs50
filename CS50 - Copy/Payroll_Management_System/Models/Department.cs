using Kimtoo.BindingProvider;
using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Payroll_Management_System.Models
{
    [AutoGenerateTable(0)] //this shiuld come on top
    [JengaEntity] //add models in its file.  dont mix
    [Alias("Departments")]
    public class Department
    {
        [PrimaryKey, AutoIncrement]
        public int DepartmentID { get; set; }

        [JengaIdentifier]
        public string Name { get; set; } = "";

        // -  methods ---------------
        public IEnumerable<Employee> GetEmployees()
        {
            return Kt.Db.Select<Employee>(r => r.DepartmentID == this.DepartmentID);
        }

        [JengaVirtualColumn("Employees", "", 2)]
        public int GetEmployeeCount()
        {
            return GetEmployees().Count();
        }

        [JengaVirtualColumn("", "", 3)]
        public DatagridViewProgressBar GetEmployeePass()
        {
            return new DatagridViewProgressBar
            {
                BackColor = Color.LightGray,
                ForeColor = Color.White,
                FillColor = Color.Teal,
                Value = GetEmployeeCount(),
                Maximum = Kt.Db.Select<Employee>().Count()
            };
        }
    }
}