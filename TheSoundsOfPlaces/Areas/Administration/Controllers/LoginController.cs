using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
