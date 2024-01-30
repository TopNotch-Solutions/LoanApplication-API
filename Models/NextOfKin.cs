using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pre_emince.Models
{
    public class NextOfKin
    {
        [Key]
        public int NextOfKinID { get; set; }

        public string KinFirstName { get; set; }
        public string KinLastName { get; set; }

        public string KinPhoneNumber { get; set; }
        [ForeignKey("UserID")]
        public int UserID { get; set; }
       

        
    }
}
