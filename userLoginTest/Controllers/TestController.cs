﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace userLoginTest.Controllers
{
    [Authorize(Roles = "Nichole ")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}