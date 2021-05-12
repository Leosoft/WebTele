using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTele.Controllers
{
    public class CanalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
