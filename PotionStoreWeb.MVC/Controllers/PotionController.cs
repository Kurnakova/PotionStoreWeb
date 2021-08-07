using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PotionStoreWeb.BL.Models;


namespace PotionStoreWeb.MVC.Controllers
{
    public class PotionController : Controller
    {
        private List<Potion> _potions = new List<Potion>()
        {
            new Potion()
            {
                Name = "Potion1"
            }
        };

        public IActionResult Index()
        {
            ViewBag.Potions = _potions;
            return View();
        }
    }
}
