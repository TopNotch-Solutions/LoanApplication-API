using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class LoanBalance
    {
        [Key]
        public int LoanBalanceID { get; set; }
        public decimal OutStandingAmount { get; set; }
        [ForeignKey("LoanID")]
        public int LoanID { get; set; }
       

      
    }
}
