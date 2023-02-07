﻿using Microsoft.AspNetCore.Mvc;

namespace FixxoWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";
            return View();
        }
    }
}
