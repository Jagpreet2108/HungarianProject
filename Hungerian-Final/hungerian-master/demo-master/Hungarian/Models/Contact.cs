using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Hungarian.Models

{[Table("Contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CId { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        public string CName { get; set; }


        [Required(ErrorMessage ="Enter Valid Email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string CEmail { get; set; }


        [Required(ErrorMessage ="Enter Valid Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$")]
        [StringLength(10)]
        public string CContact { get; set; }

       

        [Required(ErrorMessage ="Please Enter the Subject")]
        public string Subject { get; set; }
    }
}
