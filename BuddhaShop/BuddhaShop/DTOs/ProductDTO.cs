namespace BuddhaShop.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public int? Quantity { get; set; }
        public double? Price { get; set; }
        public double? ProfitPrice { get; set; }
        public bool? IsActive { get; set; }
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? SupplierId { get; set; }
        public string SupplierName { get; set; }
    }
}
