﻿using Microsoft.AspNetCore.Mvc;
using RapportGeneratorProject.Models;
using System.Diagnostics;

namespace RapportGeneratorProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(int hik, int vfi)
        {
            int new_variable = hik + vfi;
            // Store somewhere, and load on the submitform page?
            // Generate rapport using input
            // upload document
            // change to page where you can download rapport
            // change comment for github test
            //return View("~/Views/Home/SubmitForm.cshtml");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}