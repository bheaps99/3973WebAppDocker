using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentLibrary
{
    public class Student {

        [Required(ErrorMessage="First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage="BCIT Student Number is required.")]
        [RegularExpression("^[A|a][0-9]{8}$", ErrorMessage="Please enter a valid BCIT Student Number")]
        public string StudentId { get; set; }
        
        [Phone(ErrorMessage="Please enter a valid phone number.")]
        [DisplayName("Mobile Number")]
        [Required(ErrorMessage="Mobile Phone Number is required")]
        public string MobileNumber { get; set; }

        [EmailAddress(ErrorMessage="Please enter a valid email address.")]
        [Required(ErrorMessage="Email Address is required.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage="City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage="Specialization is required.")]
        public string Specialization { get; set; }
    }
}
