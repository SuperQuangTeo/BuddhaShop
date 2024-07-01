using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BuddhaShop.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column("product_name")]
        [StringLength(100)]
        public string? ProductName { get; set; }
        [Column("description")]
        [StringLength(100)]
        public string? Description { get; set; }
        [Column("quantity")]
        [Required]
        public int? Quantity { get; set; }
        [Column("price")]
        [Required]
        public double? Price { get; set; }
        [Column("profit_price")]
        [Required]
        public double? ProfitPrice { get; set; }
        [Column("is_active")]
        public bool? IsActive { get; set; }
        [Column("category_id")]
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
        [Column("supplier_id")]
        [ForeignKey("Supplier")]
        public int? SupplierId { get; set; }
        [JsonIgnore]
        public virtual Supplier? Supplier { get; set; }
        
    }
}
