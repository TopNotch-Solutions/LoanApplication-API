using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class DebitOrderInstruction
    {
        [Key]
        public int InstructionID { get; set; }
        public string AccountName { get; set; }
        public string BankName { get; set; }
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }

        public string BrancName { get; set; }
        public int BrancCode { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
       

       
       // public ICollection< LoanApplication> LoanApplication { get; set; }
    }
}
