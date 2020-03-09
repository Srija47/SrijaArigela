using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDALAssignment.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        [StringLength(5)]
        public int Orderid { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? OrderDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? DeliveryDate { get; set; }
        public int ItemID { get; set; }
        //Navigation Property
        [ForeignKey("ItemID")]
        public Item Item { get; set; }
    }
}
