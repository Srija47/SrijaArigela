using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CASESTUDY.Models
{
    public class Seller
    {
        [Key]
        [Required]
        [DisplayName("SellerId")]
        public int SId { get; set; }
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be greater than 4")]
        public string SName { get; set; }
        [Required]
        //[RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid Email")]
        [RegularExpression("^([a-zA-Z0-9]+)@([a-zA-Z0-9]+)\\.([a-zA-Z]{2,5})$", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Required]
        [DataType("Password")]
        [RegularExpression(@"^(.{0,7}|[^0-9]*|[^a-zA-Z])$", ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Required]
        [MaxLength(10, ErrorMessage = "Company Name should be in length 10")]
        public string CompanyName { get; set; }
        [Required]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Give Only Numbers")]
        public long ContactNumber { get; set; }
        [Required]
        public string Brief_abt_Company { get; set; }
        [Required]
        public string Postal_Address { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z]{5}[0-9]{4}[a-zA-Z]{1}$", ErrorMessage = "Give Correct Number")]
        public string GSTIN { get; set; }
        [Required]
        public string Website { get; set; }
        public string Photopath { get; set; }
        public Seller()
        { }
    }
}
