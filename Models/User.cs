using System.ComponentModel.DataAnnotations;

namespace Pre_emince.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BusinessName { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string Password { get; set; }

        public Gender Gender { get; set; }

        public string Address { get; set; }

        public string ZipCode { get; set; }

        public DateTime RegistrationDate { get; set; }

        //public ICollection<NextOfKin> NextOfKin { get; set; }
       // public  BankDetail BankDetail { get; set; }
       // public  ContactNumber ContactNumber { get; set; }
       // public  EmploymentDetail EmploymentDetail { get; set; }
       // public  DebitOrderInstruction DebitOrderInstruction { get; set; }
       // public ICollection< LoanApplication> LoanApplication { get; set; }
    }
}
