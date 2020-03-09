using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace CASESTUDY.Models
{
    public class Category
    {
        [Key]
        public int Category_id { get; set; }
        public string Category_name { get; set; }
        public string Brief_Details1 { get; set; }
        public Category()
        { }
    }

}
