﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlattsAPI.Controllers
{
    public class SubscriptionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
