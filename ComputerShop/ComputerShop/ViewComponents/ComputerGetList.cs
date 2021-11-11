using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComputerShop.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.ViewComponents
{
    public class ComputerGetList:ViewComponent
    {
        [AllowAnonymous]
        public IViewComponentResult Invoke(){
            ComputerRepository computerRepository = new ComputerRepository();
            var computerList = computerRepository.TList();
            return View(computerList);
        }
    }
}