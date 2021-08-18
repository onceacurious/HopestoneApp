using HopestoneApp.Data;
using HopestoneApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HopestoneApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _appDb;

        public ProductController(AppDbContext db)
        {
            _appDb = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objList = _appDb.Products;
            return View(objList);
        }

        //Get-Create
        public IActionResult Create()
        {
            return View();
        }

        //Post-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            if (ModelState.IsValid)
            {
                _appDb.Products.Add(obj);
                _appDb.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(obj);
            }
        }

        //Get-Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _appDb.Products.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return View(obj);
            }
        }

        //Post-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Product obj)
        {
            _appDb.Products.Update(obj);
            _appDb.SaveChanges();
            return RedirectToAction("Index");
        }

        //Get-Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _appDb.Products.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return View(obj);
            }
        }
    }
}