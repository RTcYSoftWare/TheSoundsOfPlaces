using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSoundsOfPlaces.Database;

namespace TheSoundsOfPlaces.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        TheSoundsOfPlacesDBContext _context;


        public HomeController(TheSoundsOfPlacesDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Sound> sounds = new List<Sound>();

            sounds = _context.Sounds.ToList();

            return View(sounds);
        }


        public JsonResult GetSounds(int id = 0)
        {
            var sounds = _context.Sounds.ToList();
            return Json(sounds);
        }
    }
}
