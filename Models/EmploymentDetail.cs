using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class EmploymentDetail
    {
        [Key]
        public int EmploymentID { get; set; }

        public int EmploymentNumber { get; set; }

        public string EmployeeName { get; set; }

        public string Department { get; set; }
        public DateTime EngagemmentDate { get; set; }

        public string JobTitle { get; set; }

        public DateTime ContractEndDate { get; set; }

        public string EmploymentStatus { get; set; }

        public int EmployerNumber { get; set; }
        public string EmployerTelephone { get; set; }
        public string EmployerName { get; set; }
        public string EmployerJobTitle { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
       

        
    }
}
