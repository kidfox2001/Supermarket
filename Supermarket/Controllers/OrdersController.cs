using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Supermarket.Data;
using Supermarket.Models;
using Supermarket.Services;

namespace Supermarket.Controllers
{
    public class OrdersController : Controller
    {
        private static Order order = new Order();
        private static List<Product> products = new List<Product>
        {
            //new Product("A",50m),
            //new Product("B",30m),
            //new Product("C",20m),
            //new Product("D",15m)

        };
        private readonly ILog log;
        private readonly SupermarketDb db;

        public OrdersController(ILog log,SupermarketDb db)
        {
            this.log = log;
            this.db = db;
        }

        public IActionResult Index()
        {

            var q1 = from p in db.Products
                     where p.UnitsInStock > 0
                     select p;

            ViewBag.ProductList = new SelectList(q1, nameof(Product.SKU), nameof(Product.Name));

            return View(order);
        }

        [HttpPost]
        public IActionResult Scan(string sku)
        {
            if (sku == null) return RedirectToAction(nameof(Index));

            var product =  db.Products.SingleOrDefault(x => x.SKU.ToLower() == sku.ToLower());
            if (product != null)
            {
                order.Scan(product);
                log.Write($"Product {sku} was scaned, ");
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult Checkout()
        {
            foreach (var line in order.LineItems)
            {
                db.Attach(line.Product);
                db.Entry(line.Product).Reload();
            }

            order.Checkout();

            db.Orders.Add(order);
            db.SaveChanges();

            order = new Order();

            return RedirectToAction(nameof(Index));
        }

    }
}