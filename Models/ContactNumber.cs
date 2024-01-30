using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class ContactNumber
    {
        [Key]
        public int ContactID { get; set; }
        public string HomeNumber { get; set; }

        public string WorkNumber { get; set; }

        public string TelephoneNumber { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
           
    }
}
