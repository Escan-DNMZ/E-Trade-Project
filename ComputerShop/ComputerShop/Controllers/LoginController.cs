using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ComputerShop.Data.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.Controllers
{
    
    public class LoginController:Controller
    {
        Context c = new Context();
        [AllowAnonymous]
        public IActionResult Index(){
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Admin p){
            var DataValue = c.Admins.FirstOrDefault(X=>X.UserName == p.UserName && X.Password == p.Password);

            if(DataValue != null){
                var claims = new List<Claim>{
                    new Claim(ClaimTypes.Name,p.UserName)
                };

                var useridentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Default");
            }  
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> LogOut(){
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index","Login");
        }
    }
}