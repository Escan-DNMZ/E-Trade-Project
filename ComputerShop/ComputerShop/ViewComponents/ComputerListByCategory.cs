using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.ViewComponents
{
    public class ComputerListByCategory:ViewComponent
    {
         [AllowAnonymous]
        public IViewComponentResult Invoke(int id){
            ComputerRepository computerRepository = new ComputerRepository();
            var computerList = computerRepository.List(X=>X.CategoryID == id);
            return View(computerList);
        }
    }
}