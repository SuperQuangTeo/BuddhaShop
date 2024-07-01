using BuddhaShop.Models;

namespace BuddhaShop.IServices
{
    public interface IProductService
    {
        public List<Product> GetAllProduct();
        public int AddProduct(Product newPro);
        public int UpdateProduct(Product product);
        public int RemoveProduct(int proId);

    }
}
