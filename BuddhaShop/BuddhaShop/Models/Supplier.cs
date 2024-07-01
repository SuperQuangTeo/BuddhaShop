using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BuddhaShop.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("supplier_name")]
        [StringLength(100)]
        public string? SupplierName { get; set; }
        [Column("address")]
        [StringLength(100)]
        public string? Address { get; set; }
        [Column("phone_number")]
        [StringLength(100)]
        public string? PhoneNumber { get; set; }
        [Column("description")]
        [StringLength(100)]
        public string? Description { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
