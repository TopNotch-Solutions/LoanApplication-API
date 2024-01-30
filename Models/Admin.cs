using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class Admin
    {
        [Key]
        public int AdminID {  get; set; }

        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
       // public  Payment Payment { get; set; }
       // public ICollection< LoanApplication> LoanApplication { get; set; }

    }
}
