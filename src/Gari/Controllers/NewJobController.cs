﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Gari.Controllers
{
    public class NewJobController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var today = DateTime.Now;
            var today2 = DateTime.Now;
            return View();
        }
    }
}
