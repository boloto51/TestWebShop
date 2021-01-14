using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebShop.Data.Entities
{
    [Table("good")]
    public class Good
    {
        [Column("Id")]
        [Key]
        public string Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Value")]
        public double Value { get; set; }
        [Column("Articul")]
        public string Articul { get; set; }
        [Column("Currency")]
        public string Currency { get; set; }

        public virtual GoodType GoodTypes { get; set; }
        public virtual Producer Producers { get; set; }
    }
}
