using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDALAssignment.Models
{
    [Table("Item")]
    public class Item
    {
        [Key] //set primary key
        public int ItemID { get; set; }
        [Required] //set not null
        [StringLength(30)]
        public string ItemName { get; set; }
        public decimal? Price { get; set; }
        //set one to many relation with Employee
        public IEnumerable<Orders> Orders { get; set; }
    }
}
