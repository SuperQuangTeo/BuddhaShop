using BuddhaShop.Models;

namespace BuddhaShop.IRepositories
{
    public interface IProductRepository
    {
        public List<Product> GetAllProduct();
        public int AddProduct(Product product);
        public int UpdateProduct(Product product);
        public int RemoveProduct(int proId);
    }
}
