using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TheSoundsOfPlaces.Areas.Administration.Models;
using TheSoundsOfPlaces.Database;

namespace TheSoundsOfPlaces.Areas.Administration.Controllers
{
    [Area("Administration")]
    [AllowAnonymous]
    public class SoundController : Controller
    {
        TheSoundsOfPlacesDBContext _context;
        IHostingEnvironment _hostingEnvironment; 


        public SoundController(TheSoundsOfPlacesDBContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            SoundCreatePageModel soundCreatePageModel = new SoundCreatePageModel();

            soundCreatePageModel.Categories = _context.Categories.Where(x => x.Status == true).ToList();

            return View(soundCreatePageModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(SoundCreatePageModel createSound)
        {
            if (ModelState.IsValid)
            {
                string uniqFileName = null;
                if (createSound.Sound != null)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "sounds");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + createSound.Sound.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    createSound.Sound.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                Sound newSound = new Sound
                {
                    Title = createSound.Title,
                    Text = createSound.Text,
                    CategoryId = 1,
                    Slug = createSound.Title.ToLower(),
                    SoundUrl = uniqFileName,
                    CityId = 1,
                    DistrictId = 1,
                    Latitude = createSound.Latitude,
                    Longitude = createSound.Longitude,
                    Status = true,
                    CreatedAt = DateTime.Now
                };

                await _context.Sounds.AddAsync(newSound);
                _context.SaveChanges();

                createSound.Categories = _context.Categories.Where(x => x.Status == true).ToList();
                createSound.Created = true;

                return View(createSound);
            }

            return View();
        }
    }
}
