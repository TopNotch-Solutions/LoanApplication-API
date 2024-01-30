using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string? Notes { get; set; }
        [ForeignKey("AdminID")]
        public int AdminID { get; set; }
       
        [ForeignKey("LoanID")]
        public int LoanID { get; set; }
        

        
    }
}
