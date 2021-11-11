using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.Controllers
{
    public class DefaultController:Controller
    {
        [AllowAnonymous]
        public IActionResult Index(){

            return View();
        }
        [AllowAnonymous]
        public IActionResult CategoryDetails(int id){
            ViewBag.x = id;
            return View();
        }
    }
}