﻿using Microsoft.AspNetCore.Mvc;

namespace RunGroupWebApp.Controllers
{
    public class RunningClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
