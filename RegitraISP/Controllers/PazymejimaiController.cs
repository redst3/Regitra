﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegitraISP.Controllers
{
    public class PazymejimaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
