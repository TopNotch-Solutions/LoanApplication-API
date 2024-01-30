using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class LoanApplication
    {
        [Key]
         public int LoanID { get; set; }

        public string LoanType { get; set; }

        public int Amount { get; set; }
        
        public int Duration { get; set; }

        public decimal NetIncomePerMonth { get; set; }

        public string ReasonForLoan { get; set; }

        public MaritalStatus MaritalStatus { get; set; }

        public int IDNumber { get; set; }

        public AppliactionStatus AppliactionStatus { get; set; }
        public DateTime ApprovedDate { get; set; }
        public string PassportOrID { get; set; }

        public string BankStatement { get; set; }
        public string PaySlip { get; set; }
        public string UtilityBill { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
      
        [ForeignKey("AdminID")]
        public int? AdminID { get; set; }
      
        [ForeignKey("InstructionID")]
        public int InstructionID { get; set; }
        
       // public  LoanBalance LoanBalance { get; set; }
    }
}
