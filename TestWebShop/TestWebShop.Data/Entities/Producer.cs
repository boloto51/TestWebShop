using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebShop.Data.Entities
{
    [Table("producer")]
    public class Producer
    {
        //[Column("Id")]
        //[Key]
        //public int Id { get; set; }
        [Column("Code")]
        [Key]
        public string Code { get; set; }
        [Column("Name")]
        public string Name { get; set; }

        public virtual ICollection<Good> Goods { get; set; }
    }
}
