using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Supermarket.Data;
using Supermarket.Models;

namespace Supermarket.Controllers
{
    // ctrl + . เรียกหลอดไฟ
    // controller รู้แต่ what ไม่รู้ how เป็นคนสั่งงานไม่ใช่คนทำงาน
    public class ProductsController : Controller
    {
        private readonly SupermarketDb db;
        private readonly IHostingEnvironment host;

        //private static List<Product> products 
        //    = new List<Product>()
        //    {
        //       new Product("Scone", 15m),
        //       new Product("Donut", 20m)
        //    };
        //private static Product p = new Product("Toys", 100) { Discontinoued = false };

        public ProductsController(SupermarketDb db,IHostingEnvironment host)
        {
            this.db = db;
            this.host = host;
        }

        public IActionResult Index()
        {

            var products = db.Products.ToList();
            return View(products);
        }

        // todo อยากปิดไม่ใช้ให้ทาง url ทำอย่างไรและทำอย่างไหร่ถึงใช้ได้ทั้งระบบ
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product item , IFormFile pictureFile)
        {

            if (db.Products.Any(x => x.Name == item.Name))
            {
                ModelState.AddModelError(nameof(Product.Name), "This name was already used");
            }

            if (pictureFile ==null)
            {

            }

            if (!ModelState.IsValid)
            {
                return View(item);
            }

            item.FileName = $"Uploads\\Products\\{item.SKU}.png";

            var ms = new MemoryStream();
            pictureFile.CopyTo(ms);
            System.IO.File.WriteAllBytes(item.FileName , ms.ToArray());

            db.Products.Add(item);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Test(string id)
        {
            Product product = null;

            if (id != null)
            {
                product = db.Products.Find(id);
            }

            if (product == null)
            {
                product = db.Products.First();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ReduceStock(string sku, int qty)
        {
            var product = db.Products.Find(sku);
            product?.StockOut(qty);
            db.SaveChanges();

            return RedirectToAction(nameof(Test),new { id = sku});
        }

        [HttpPost]  // กันไม่ให้พิมเข้า url ตรงๆ
        [ValidateAntiForgeryToken]
        public IActionResult IncreaseStock(string sku, int qty)
        {
            var product = db.Products.Find(sku);
            product?.StockIn(qty);
            db.SaveChanges();

            return RedirectToAction(nameof(Test), new { id = sku });
        }

        public IActionResult Picture(string id)
        {
            var p = db.Products.SingleOrDefault(x => x.SKU == id);
            var path = Path.Combine(host.ContentRootPath, p.FileName);

            return PhysicalFile(path, "image/png");

        }

        public IActionResult Info(string id)
        {
            var p = db.Products.Find(id);
            return Json(p);
        }

        //    [HttpPost]
        //    public IActionResult SetDiscontinue()
        //    {
        //        p.SetDiscontinue();

        //        return RedirectToAction(nameof(Test));
        //    }

        //    [HttpPost]  // กันไม่ให้พิมเข้า url ตรงๆ
        //    public IActionResult SetContinue()
        //    {
        //        p.SetContinue();

        //        return RedirectToAction(nameof(Test));
        //    }

        //    [HttpPost]
        //    public IActionResult AdjustCost(decimal newPrice)
        //    {
        //        p.AdjustPrice(newPrice);

        //        return RedirectToAction(nameof(Test));
        //    }
    }
}