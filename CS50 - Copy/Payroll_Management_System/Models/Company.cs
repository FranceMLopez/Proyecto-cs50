using Kimtoo.DbManager;
using ServiceStack.DataAnnotations;

namespace Payroll_Management_System.Models
{
    [AutoGenerateTable(0)]
    [JengaEntity]
    [Alias("Company")]
    public class Company
    {
        [PrimaryKey, AutoIncrement]
        public int CompanyID { get; set; }

        [JengaIdentifier]
        public string CompanyName { get; set; } = "";

        [JengaImage(150, 150)]
        public byte[] Logo { get; set; }

        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";

        [JengaTextArea]
        public string Address { get; set; } = "";
    }
}