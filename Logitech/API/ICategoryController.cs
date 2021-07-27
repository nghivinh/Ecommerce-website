using Logitech.DataAccessLayer;
using Logitech.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Logitech.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ICategoryController : ControllerBase
    {
        CategoryDataAccessLayer categoryDAL = new CategoryDataAccessLayer();

        [HttpGet]
        [Route("api/Category/Index")]
        public IEnumerable<Category> Index()
        {
            return categoryDAL.GetAllCategories();
        }

        [HttpGet]
        [Route("api/Category/Details/{id}")]
        public Category Details(int id)
        {
            return categoryDAL.GetCategoryData(id);
        }

        [HttpPost]
        [Route("api/Category/Create")]
        public int Create(Category category)
        {
            return categoryDAL.AddCategory(category);
        }

        [HttpPut]
        [Route("api/Category/Edit/{id}")]
        public int Edit(int id, Category category)
        {
            return categoryDAL.UpdateCategory(id, category);
        }

        [HttpDelete]
        [Route("api/Category/Delete/{id}")]
        public int Delete(int id)
        {
            return categoryDAL.DeleteCategory(id);
        }
    }
}
