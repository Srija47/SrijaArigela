using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace CASESTUDY.Models
{
    public class SubCategory : Category
    {

        public int Subcategory_id { get; set; }
        public string Subcategory_name { get; set; }
        // public int Category_id { get; set; }
        public string Brief_details2 { get; set; }
        public float GST_Percentage { get; set; }
        public SubCategory()
        { }

    }
}
