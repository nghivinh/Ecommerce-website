﻿using Logitech.Data;
using Logitech.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;

namespace Logitech.Controllers
{
    public class HomeController : Controller
    {
        private LogitechContext context = new LogitechContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string SearchText, int categoryId = 0)
        {
            var productFeatured = (from p in context.Products select p).Where(p => p.Featured)
                                  .OrderByDescending(p => p.UpdatedDate).Take(6);
            ViewBag.productFeatured = productFeatured;

            var categorys = (from c in context.Categorys select c).ToList();
            ViewBag.Categorys = categorys;

            var products = context.Products.Select(p => new LoadProduct
            {
                Id = p.Id,
                Image = p.Image,
                Name = p.Name,
                Price = p.Price,
                SaleOff = p.SaleOff,
                Store = p.Store,
                Sold = p.Sold,
                CategoryId = p.Category.Id,
                Star = p.Rating.Average(pr => pr.Star)
            });

            if (!String.IsNullOrEmpty(SearchText))
            {
                products = products.Where(s => s.Name.Contains(SearchText));
            }

            if (categoryId != 0)
            {
                products = products.Where(p => p.CategoryId == categoryId);
            }

            ViewBag.CategoryId = categoryId;

            return View(products.ToList());
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Account _account)
        {
            if (ModelState.IsValid)
            {
                var check = context.Accounts.FirstOrDefault(s => s.UserName == _account.UserName);
                if (check == null)
                {
                    //_account.Password = GetMD5(_account.Password);
                    context.Accounts.Add(_account);
                    context.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.error = "Tên người dùng đã có rồi";
                    return View();
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string username, string password)
        {
            if (ModelState.IsValid)
            {
                //var _password = GetMD5(password);
                var data = context.Accounts.Where(s => s.UserName.Equals(username) && s.Password.Equals(password)).ToList();
                if (data.Count() > 0)
                {
                    HttpContext.Session.SetString("UserName", data.FirstOrDefault().UserName);
                    HttpContext.Session.SetString("Id", data.FirstOrDefault().Id.ToString());
                    HttpContext.Session.SetString("FullName", data.FirstOrDefault().FullName);
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.error = "Đăng nhập thất bại";
                    return RedirectToAction("Login");
                }
            }
            return View();

        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
