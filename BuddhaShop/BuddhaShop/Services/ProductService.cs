using BuddhaShop.IRepositories;
using BuddhaShop.IServices;
using BuddhaShop.Models;


namespace BuddhaShop.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }

        public int AddProduct(Product newPro)
        {
            return _productRepo.AddProduct(newPro);
        }

        public List<Product> GetAllProduct()
        {
            return _productRepo.GetAllProduct();
        }

        public int RemoveProduct(int proId)
        {
            return _productRepo.RemoveProduct(proId);
        }

        public int UpdateProduct(Product product)
        {
            return _productRepo.UpdateProduct(product);
        }
    }
}
