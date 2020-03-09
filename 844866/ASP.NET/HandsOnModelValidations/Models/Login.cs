using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HandsOnModelValidations.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Username is required")]
        [DisplayName("UserName")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="Password is Required")]
        [DisplayName("Password")]
        public string Pwd { get; set; }

    }
}
