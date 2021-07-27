using Logitech.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IProductController : ControllerBase
    {
        ProductDataAccessLayer productDAL = new ProductDataAccessLayer();

        [HttpGet]
        [Route("api/Product/Index")]
        public IEnumerable<Product> Index()
        {
            return productDAL.GetAllProducts();
        }

        [HttpGet]
        [Route("api/Product/Details/{id}")]
        public Product Details(int id)
        {
            return productDAL.GetProductData(id);
        }

        [HttpPost]
        [Route("api/Product/Create")]
        public int Create(Product product)
        {
            return productDAL.AddProduct(product);
        }

        [HttpPut]
        [Route("api/Product/Edit/{id}")]
        public int Edit(int id, Product product)
        {
            return productDAL.UpdateProduct(id, product);
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public int Delete(int id)
        {
            return productDAL.DeleteProduct(id);
        }
    }
}
