using Logitech.Data;
using Logitech.Models;
using Logitech.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Controllers
{
    public class ProductDetailController : Controller
    {
        private LogitechContext context = new LogitechContext();

        // GET: ProductDetailController/Details
        public ActionResult Details(int id)
        {
            Product product = context.Products.Find(id);
            LoadProductDetail productDetail = new LoadProductDetail();

            productDetail.Id = id;
            productDetail.Image = product.Image;
            productDetail.Name = product.Name;
            productDetail.Description = product.Description;
            productDetail.Price = product.Price;
            productDetail.SaleOff = product.SaleOff;
            productDetail.Store = product.Store;
            productDetail.Sold = product.Sold;

            var reviews = (from r in context.Ratings
                           join a in context.Accounts on r.Account.Id equals a.Id
                           where r.Product.Id == id select new LoadReview
                           {
                               //ProductId = id,
                               FullName = a.FullName,
                               Star = r.Star,
                               Comment = r.Comments,
                               CreateDate = r.CreateDate
                           }).ToList();

            productDetail.ListOfReview = reviews;

            var stars = context.Ratings.Where(r => r.Product.Id == id).ToList();

            if (stars.Count() > 0)
            {
                var starSum = stars.Sum(d => d.Star);
                ViewBag.StarSum = starSum;
                var starCount = stars.Count();
                ViewBag.StarCount = starCount;
            }
            else
            {
                ViewBag.StarSum = 0;
                ViewBag.StarCount = 0;
            }

            return View(productDetail);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(LoadReview review)
        {
            var productId = review.ProductId;
            var accountId = review.AccountId;
            var comment = review.Comment;
            var star = review.Star;

            Rating ratings = new Rating()
            {
                Comments = comment,
                Star = (float)star,
                Product = context.Products.Find(productId),
                Account = context.Accounts.Find(accountId),
                CreateDate = DateTime.Now
            };

            context.Ratings.Add(ratings);
            context.SaveChanges();

            return RedirectToAction("Details", "ProductDetail", new { id = productId }, "feadback");
        }

    }
}
