using Logitech.Data;
using Logitech.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.DataAccessLayer
{
    public class CategoryDataAccessLayer
    {
        LogitechContext context = new LogitechContext();

        public IEnumerable<Category> GetAllCategories()
        {
            return context.Categorys.ToList();
        }

        public Category GetCategoryData(int id)
        {
            return context.Categorys.Find(id);
        }

        public int AddCategory(Category _category)
        {
            var category = new Category()
            {
                Name = _category.Name,
                Description = _category.Description
            };

            context.Categorys.Add(category);
            context.SaveChanges();
            if (category.Id > 0)
            {
                return 1;
            }
            return 0;
        }

        public int UpdateCategory(int id, Category _category)
        {
            var category = context.Categorys.Find(id);
            category.Name = _category.Name;
            category.Description = _category.Description;

            context.SaveChanges();
            return 1;
        }

        public int DeleteCategory(int id)
        {
            var product = context.Products.Where(p => p.Category.Id == id).ToList();
            foreach (var p in product)
            {
                //Xóa danh sách đánh giá của sản phẩm này trước
                context.Ratings.RemoveRange(context.Ratings.Where(r => r.Product.Id == p.Id));

                //Xóa sản phẩm này sau
                context.Products.Remove(p);
            }

            //Xóa category này
            var category = context.Categorys.Find(id);
            context.Categorys.Remove(category);

            context.SaveChanges();
            return 1;
        }
    }
}
