using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestWebShop.Data.Entities
{
    [Table("good")]
    public class Good
    {
        [Column("Id")]
        [Key]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Value")]
        public double Value { get; set; }
        [Column("Articul")]
        public string Articul { get; set; }
        [Column("Currency")]
        public string Currency { get; set; }

        [Column("GoodTypeCode")]
        public string GoodTypeCode { get; set; }
        [Column("ProducerCode")]
        public string ProducerCode { get; set; }

        [ForeignKey(nameof(GoodTypeCode))]
        public virtual GoodType GoodTypes { get; set; }
        [ForeignKey(nameof(ProducerCode))]
        public virtual Producer Producers { get; set; }
    }
}
