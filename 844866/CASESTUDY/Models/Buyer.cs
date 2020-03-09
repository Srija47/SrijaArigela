using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace CASESTUDY.Models
{
    public class Buyer
    {
        [Key]
        [Required]
        [DisplayName("BuyerId")]
        public int BId { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be greater than 4")]
        public string Username { get; set; }
        [Required]
        [DataType("Password")]
        [RegularExpression(@"^(.{0,7}|[^0-9]*|[^a-zA-Z])$", ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Required]
        [RegularExpression("^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)\\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid Email")]
        public string Emailid { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Give Only Numbers")]
        public long MobileNumber { get; set; }
        public DateTime dateTime { get; set; }

        public Buyer()
        {

        }

    }
}
