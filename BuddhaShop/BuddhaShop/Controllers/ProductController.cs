using AutoMapper;
using BuddhaShop.DTOs;
using BuddhaShop.IServices;
using BuddhaShop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BuddhaShop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        [HttpGet]
        [Route("get-all-product")]
        public ResponseBodyBase<List<ProductDTO>> GetAllProducts()
        {
            var productList = _mapper.Map<List<ProductDTO>>(_productService.GetAllProduct());
            return new ResponseBodyBase<List<ProductDTO>>
            {
                data = productList,
                statusCode = HttpStatusCode.OK
            };
        }


        [HttpPost]
        [Route("add-product")]
        public ResponseBodyBase<int> GetAllProducts(Product product)
        {
            int n = _productService.AddProduct(product);
            if(n > 0)
            {
                return new ResponseBodyBase<int>
                {
                    message = "add successfull",
                    statusCode = HttpStatusCode.OK
                };
            }
            return new ResponseBodyBase<int>
            {
                message = "add failed",
                statusCode = HttpStatusCode.NotFound
            };

        }


        [HttpPut]
        [Route("update-product")]
        public ResponseBodyBase<int> UpdateProduct(Product product)
        {
            int n = _productService.UpdateProduct(product);
            if (n > 0)
            {
                return new ResponseBodyBase<int>
                {
                    message = "update successfull",
                    statusCode = HttpStatusCode.OK
                };
            }
            return new ResponseBodyBase<int>
            {
                message = "update failed",
                statusCode = HttpStatusCode.NotFound
            };
        }

        [HttpDelete]
        [Route("remove-product")]
        public ResponseBodyBase<int> RemoveProduct(int proId)
        {
            int n = _productService.RemoveProduct(proId);
            if (n > 0)
            {
                return new ResponseBodyBase<int>
                {
                    message = "delete successfull",
                    statusCode = HttpStatusCode.OK
                };
            }
            return new ResponseBodyBase<int>
            {
                message = "delete failed",
                statusCode = HttpStatusCode.NotFound
            };
        }
    }
}
