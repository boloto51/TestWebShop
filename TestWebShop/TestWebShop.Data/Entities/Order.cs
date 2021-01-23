using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebShop.Data.Entities
{
    public class Order
    {
        [Column("OrderGuid")]
        [Key]
        public string OrderGuid { get; set; }

        [Column("GoodId")]
        public int GoodId { get; set; }
        [Column("GoodCount")]
        public int GoodCount { get; set; }
        [Column("GoodPrice")]
        public double GoodPrice { get; set; }
        [Column("OrderDate")]
        public DateTime OrderDate { get; set; }

        [ForeignKey(nameof(GoodId))]
        public virtual Good Goods { get; set; }
    }
}
