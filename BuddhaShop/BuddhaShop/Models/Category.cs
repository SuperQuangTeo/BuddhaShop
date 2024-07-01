using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BuddhaShop.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("category_name")]
        [StringLength(100)]
        public string? CategoryName { get; set; }
        [Column("description")]
        [StringLength(100)]
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
