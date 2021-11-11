using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Data.Models;
using ComputerShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ComputerShop.Controllers;
using X.PagedList;
using Microsoft.AspNetCore.Http;

namespace ComputerShop.Controllers
{
    public class ComputerController: Controller
    {
      Context c = new Context();
      ComputerRepository computerRepository = new ComputerRepository();
        public IActionResult Index(int page=1){
          
          return View(computerRepository.TList("Category").ToPagedList(page,5));
        }

        [HttpGet]
        public IActionResult ComputerAdd(){
          List<SelectListItem> Values = (from x in c.Categories.ToList()
                                    select new SelectListItem{
                                        Text = x.CategoryName,
                                        Value = x.CategoryID.ToString()
                                    }).ToList();
          ViewBag.Vls = Values;
          return View();
        }
        [HttpPost]
         public IActionResult ComputerAdd(Computer p){
           if (!ModelState.IsValid)
            {
                return View("ComputerAdd");
            }
            computerRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult ComputerDelete(int id){
          computerRepository.TDelete(new Computer {ComputerID = id});
          return RedirectToAction("Index");
        }
        public IActionResult ComputerGet(int id){
          var x = computerRepository.TGet(id);
          Computer d = new Computer(){
            ComputerID = x.ComputerID,
            CategoryID = x.CategoryID,
            Name=x.Name,
            Price = x.Price,
            Stock=x.Stock,
            Description=x.Description,
            ImageUrl=x.ImageUrl
          };
          List<SelectListItem> dp = (from c in c.Computers.ToList()
                                      select new SelectListItem{
                                        Text = c.Name,
                                        Value = c.ComputerID.ToString()
                                      }).ToList();
          ViewBag.dgr = dp;
          return View(d);
        }
        [HttpPost]
        public IActionResult ComputerUpdate(Computer p){
          var x = computerRepository.TGet(p.ComputerID);
            x.ComputerID = p.ComputerID;
            x.Name = p.Name;
            x.Price = p.Price;
            x.Stock = p.Stock;
            x.ImageUrl = p.ImageUrl;
            x.Description = p.Description;
            x.CategoryID = p.CategoryID;

            computerRepository.TUpdate(x);
          return RedirectToAction("Index");
        }

    }
}