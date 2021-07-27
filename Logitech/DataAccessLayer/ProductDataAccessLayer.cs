using Logitech.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Models
{
    public class ProductDataAccessLayer
    {
        LogitechContext context = new LogitechContext();

        public IEnumerable<Product> GetAllProducts()
        {
            var products = context.Products.Select(p => new Product
            {
                Id = p.Id,
                Image = p.Image,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                SaleOff = p.SaleOff,
                Store = p.Store,
                Sold = p.Sold,
                Featured = p.Featured,
                CreatedDate = p.CreatedDate,
                UpdatedDate = p.UpdatedDate,
                Category = context.Categorys.Where(c => c.Id == p.Category.Id).FirstOrDefault(),
                Rating = context.Ratings.Where(r => r.Product.Id == p.Id).ToList()
            }).ToList();

            return products;
        }

        public Product GetProductData(int id)
        {
            var products = context.Products.Select(p => new Product
            {
                Id = p.Id,
                Image = p.Image,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                SaleOff = p.SaleOff,
                Store = p.Store,
                Sold = p.Sold,
                Featured = p.Featured,
                CreatedDate = p.CreatedDate,
                UpdatedDate = p.UpdatedDate,
                Category = context.Categorys.Where(c => c.Id == p.Category.Id).FirstOrDefault(),
                Rating = context.Ratings.Where(r => r.Product.Id == p.Id).ToList()
            }).Where(p => p.Id == id).FirstOrDefault();

            return products;
        }

        public int AddProduct(Product _product)
        {
            var product = new Product()
            {
                Image = _product.Image,
                Name = _product.Name,
                Description = _product.Description,
                Price = _product.Price,
                SaleOff = _product.SaleOff,
                Store = _product.Store,
                Sold = _product.Sold,
                Featured = _product.Featured,
                CreatedDate = _product.CreatedDate,
                UpdatedDate = _product.UpdatedDate,
                Category = context.Categorys.Find(_product.CategoryId)
            };

            context.Products.Add(product);
            context.SaveChanges();
            if (product.Id > 0)
            {
                return 1;
            }
            return 0;
        }

        public int UpdateProduct(int id, Product _product)
        {
            var product = context.Products.Find(id);
            product.Image = _product.Image;
            product.Name = _product.Name;
            product.Description = _product.Description;
            product.Price = _product.Price;
            product.SaleOff = _product.SaleOff;
            product.Store = _product.Store;
            product.Sold = _product.Sold;
            product.Featured = _product.Featured;
            product.CreatedDate = _product.CreatedDate;
            product.UpdatedDate = _product.UpdatedDate;
            product.Category = context.Categorys.Find(_product.CategoryId);

            context.SaveChanges();
            return 1;
        }

        public int DeleteProduct(int id)
        {
            //Xóa danh sách đánh giá của sản phẩm này trước
            context.Ratings.RemoveRange(context.Ratings.Where(r => r.Product.Id == id));

            //Xóa sản phẩm này
            var product = context.Products.Find(id);
            context.Products.Remove(product);

            context.SaveChanges();
            return 1;
        }
    }
}
