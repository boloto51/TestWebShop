using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebShop.Data.Entities
{
    [Table("goodtype")]
    public class GoodType
    {
        [Column("Id")]
        [Key]
        public string Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Code")]
        public string Code { get; set; }

        public virtual ICollection<Good> Goods { get; set; }
    }
}
