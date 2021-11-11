using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using ComputerShop.Data.Models;

namespace ComputerShop.Controllers
{
    public class CategoryController:Controller
    {
        Context c = new Context();
        CategoryRepository categoryRepository = new CategoryRepository();
        public IActionResult Index(string p){
            
            if (!string.IsNullOrEmpty(p))
            {
                return View(categoryRepository.List(X=>X.CategoryName == p));
            }
            return View(categoryRepository.TList());
        }

        [HttpGet]
        public IActionResult CategoryAdd(){
           return View();
        }
        [HttpPost]
         public IActionResult CategoryAdd(Category p){
            if (!ModelState.IsValid)
            {
                return View("CategoryAdd");
            }
            categoryRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CategoryDelete(int id)
        {
            categoryRepository.TDelete(new Category {CategoryID = id});
                return RedirectToAction("Index");
        }
        public IActionResult CategoryGet(int id){
            var x = categoryRepository.TGet(id);
            Category ct = new Category(){
                CategoryName=x.CategoryName,
                CategoryDescription=x.CategoryDescription,
                CategoryID=x.CategoryID
            };
            return View(ct);
        }
        [HttpPost]
        public IActionResult CategoryUpdate(Category p){
            var x = categoryRepository.TGet(p.CategoryID);
            x.CategoryID = p.CategoryID;
            x.CategoryName = p.CategoryName;
            x.CategoryDescription = p.CategoryDescription;
            x.Status = true;
            categoryRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
      

    }
}