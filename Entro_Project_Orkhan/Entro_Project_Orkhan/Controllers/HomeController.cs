using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Entro_Project_Orkhan.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
