using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSoundsOfPlaces.Database;

namespace TheSoundsOfPlaces.Areas.Administration.Models
{
    public class SoundCreatePageModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public IFormFile Sound { get; set; }
        public List<Category> Categories { get; set; }
        public bool Created { get; set; }
    }
}
