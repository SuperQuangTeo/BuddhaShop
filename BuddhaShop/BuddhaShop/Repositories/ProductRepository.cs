using BuddhaShop.IRepositories;
using BuddhaShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BuddhaShop.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly BuddhaShopContext _context;

        public ProductRepository(BuddhaShopContext context)
        {
            _context = context;
        }
        public List<Product> GetAllProduct()
        {
            return _context.Products.Include(x => x.Supplier).Include(x => x.Category).ToList();
        }

        public int AddProduct(Product newPro)
        {
            _context.Products.Add(newPro);
            return _context.SaveChanges();
        }

        public int UpdateProduct(Product newPro)
        {
            Product? product = _context.Products.FirstOrDefault(x => x.Id == newPro.Id);
            if(product != null)
            {
                product.ProductName = newPro.ProductName;
                product.Price = newPro.Price;
                product.Description = newPro.Description;
                product.ProfitPrice = newPro.ProfitPrice;
                product.CategoryId = newPro.CategoryId;
                product.SupplierId = newPro.SupplierId;
                product.IsActive = newPro.IsActive;
                product.Quantity = newPro.Quantity;
                _context.Products.Update(product);
                return _context.SaveChanges();
            }
            return 0;
        }

        public int RemoveProduct(int proId)
        {
            Product? newProduct = _context.Products.FirstOrDefault(x => x.Id == proId);
            if(newProduct != null)
            {
                _context.Remove(newProduct);
                return _context.SaveChanges();
            }
            return 0;
        }
    }
}
