using System.ComponentModel.DataAnnotations.Schema;

namespace MyTestWebApplication.Models
{
    [Table("TestTable")]
    public class Record
    {
        public int Id { get; set; }

        [Column("Info")]
        public string? Information { get; set; }

        [Column("Dt")]
        public DateTime DateTime { get; set; }
    }
}
