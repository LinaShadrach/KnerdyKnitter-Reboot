using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KnerdyKnitter.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KnerdyKnitter.Controllers
{
    public class ScarfController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            StarterScarfViewModel scarf = new StarterScarfViewModel();
            return View(scarf);
        }
    }
}
