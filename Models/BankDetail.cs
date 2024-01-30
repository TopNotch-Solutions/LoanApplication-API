using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class BankDetail
    {
        [Key]
        public int BankId { get; set; }

        public int AccountNumber { get; set; }
        public string BankName { get; set;}
        public string BranchName { get; set;}

        public int BranchCode { get; set;}
        [ForeignKey("UserID")]
        public int UserID { get; set; }
        

       
    }
}
