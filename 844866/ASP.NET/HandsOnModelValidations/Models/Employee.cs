using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace HandsOnModelValidations.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Pls Enter Id")]
        [DisplayName("Employee ID")]
        public int ID { get; set; }
        [Required(ErrorMessage = "Pls Enter Name")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be greater than 4")]

        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email ID")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Email")]
        public string Mobile { get; set; }
        [Required(ErrorMessage ="UserName is Required")]
        public string Uname{ get; set; }
        [Required(ErrorMessage = "Password is Required")]
        [RegularExpression ("[a-z0-9]{6,8}")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "Password Mismatch")]
        public string Cpwd { get; set; }
    }
}
