﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CA1.Models;
using CA1.Database;

namespace CA1.Controllers
{
    public class HomeController : Controller
    {

        private readonly DbGallery db;
        public HomeController(DbGallery db)
        {
            this.db = db;
        }

      
        public IActionResult Index()
        {
            string sessionId = HttpContext.Request.Cookies["sessionId"];
            Session session = db.Sessions.FirstOrDefault(x => x.Id.ToString() == sessionId);

            if (session != null)
                ViewData["IsLogin"] = session.IsLogin;
            else
                ViewData["IsLogin"] = false;

            List<Product> products = db.Products.ToList();
            string[] images = new string[products.Count];
            string[] names = new string[products.Count];
            string[] tags = new string[products.Count];
            string[] info = new string[products.Count];
            double[] prices = new double[products.Count];
            string[] Id = new string[products.Count];

            for (int i = 0; i < products.Count; i++)
            {
                images[i] = products[i].PhotoLink;
                names[i] = products[i].ProductName;
                tags[i] = products[i].PhotoTag;
                info[i] = products[i].Description;
                prices[i] = products[i].Price;
                Id[i] = products[i].Id;
            }

            ViewData["images"] = images;
            ViewData["names"] = names;
            ViewData["tags"] = tags;
            ViewData["informations"] = info;
            ViewData["prices"] = prices;
            ViewData["productId"] = Id;
            ViewData["home"] = "menu_hilite";

            if (session != null && session.User != null)
            {
                ViewData["username"] = session.User.Username.ToUpper();
            }
            else
            {
                ViewData["username"] = "";
            }

            return View();
        }

        public IActionResult Search(string search)
        {
            /* List<Product> products = db.Products.Where(
                     x => x.Description.Contains(search) ||
                     x.ProductName.Contains(search)).ToList();*/

            /*  List<Product> products = db.Products.Where(
                      x => x.ProductName==search).ToList();*/

            List<Product> products = db.Products.Where(
                   x => x.Description.ToUpper().Contains(search.ToUpper()) ||
                   x.ProductName.ToUpper().Contains(search.ToUpper())).ToList();

            ViewData["products"] = products;

            Debug.WriteLine(products.Count);

            string sessionId = HttpContext.Request.Cookies["sessionId"];
            Session session = db.Sessions.FirstOrDefault(x => x.Id.ToString() == sessionId);
            if (session != null && session.User != null)
            {
                ViewData["IsLogin"] = session.IsLogin;
                ViewData["username"] = session.User.Username.ToUpper();
            }
            else
            {
                ViewData["IsLogin"] = false;
            }

            ViewData["userInput"] = search;
            ViewData["home"] = "menu_hilite";
            return View("SearchResults");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
