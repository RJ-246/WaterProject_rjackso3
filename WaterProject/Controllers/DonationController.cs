using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterProject.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WaterProject.Controllers
{
    public class DonationController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Donation());
        }
    }
}

