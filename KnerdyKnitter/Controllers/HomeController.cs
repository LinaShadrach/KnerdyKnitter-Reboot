using System;
using KnerdyKnitter.Models;
using Microsoft.AspNetCore.Mvc;

namespace KnerdyKnitter.Controllers
{
    public class HomeController :Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
