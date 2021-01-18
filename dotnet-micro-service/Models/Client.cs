using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogueApp.Models
{
    [Table("CLIENT")]
    public class Client
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        // public double Price { get; set; }
        // public long CategoryID { get; set; }
        // [ForeignKey("CategoryID")]
        // public virtual Category Category { get; set; }
    }
}