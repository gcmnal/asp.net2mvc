using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp.net2mvc.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult _Layout()
        {
            return View();
        }
    }
}