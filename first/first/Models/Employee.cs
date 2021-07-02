using System;
using System.ComponentModel.DataAnnotations;

namespace first.Models
{
    public class Employee
    {
         
        public int Id { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]

        public string Name { get; set; }
         public string Designation { get; set; }
        [RegularExpression("[^0-9]", ErrorMessage = "UPRN must be numeric")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]

        public string Email { set; get; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public decimal Mobie { set; get; }
        public string Qualification { set; get; }
        public string Mname { set; get; }


    }
}
