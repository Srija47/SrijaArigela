using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace CASESTUDY.Models
{
    public class Item : SubCategory
    {

        public int ItemId { get; set; }
        //public int Category_id { get; set; }
        //public int Subcategory_id { get; set; }
        public int Price { get; set; }
        public int Item_Name { get; set; }
        public string Description { get; set; }
        public int Stock_Number { get; set; }
        public string Remarks { get; set; }
        public Item()
        { }
    }

}
