using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.Controllers
{
    public class ChartController:Controller
    {
        public IActionResult Index(){

            return View();
        }
        public IActionResult Index2(){
            return View();
        }
        public IActionResult  VisualizeProductResult(){
            return Json(ComputerList());//metodumun ismi
        }
        public List<Class1> ComputerList(){
            List<Class1> cs = new List<Class1>();
            using(var c = new Context()){
             cs=c.Computers.Select(x=>new Class1{
                 computername=x.Name,
                 stock=x.Stock
             }).ToList();
             }
             return cs;
        }
        public IActionResult Statistics(){
            Context c = new Context();
            //Computer Count
            var deger1 = c.Computers.Count();
            ViewBag.d1 = deger1;
            //Categories Count
            var deger2 = c.Categories.Count();
            ViewBag.d2 = deger2;
            //Computer Stock
            var deger3 = c.Computers.Sum(x=>x.Stock);
            ViewBag.d3 = deger3;
            //Average Price
            var deger5 = c.Computers.Average(X=>X.Price).ToString("0.00");
            ViewBag.d5 = deger5;
            return View();
        }
           
    }       
    
}