using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ColdSubject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ColdSubject.Controllers
{
    public class ProductsController : Controller
    {
        public ProductsController(IProductRepository repo = null)
        {
            this.db = repo ?? new EFReviewRepository();
        }

        private IProductRepository db;
        public IActionResult Index()
        {
            List<Product> model = db.Products.ToList();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Save(product);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            db.Edit(product);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            db.Remove(thisProduct);
            return RedirectToAction("Index");
        }

        public IActionResult AddReview(int id)
        {
            Review review = new Review();
            ViewBag.ProductId = id;
            return View(review);
        }

        [HttpPost]
        public IActionResult AddReview(Review review)
        {
            //ViewBag
            db.Save(review);
            return RedirectToAction("Index");
        }

        public IActionResult ViewReviews(int id)
        {
            return View(db.Reviews.Where(r => r.ProductId == id).Include(reviews => reviews.Product).ToList());
        }
    }
}
