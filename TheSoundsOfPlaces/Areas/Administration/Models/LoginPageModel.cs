﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Areas.Administration.Models
{
    public class LoginPageModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Error { get; set; }
    }
}
