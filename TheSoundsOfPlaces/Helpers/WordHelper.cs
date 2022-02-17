using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Helpers
{
    public class WordHelper
    {
        public string encryptSha256(string text)
        {
            SHA256 sha = SHA256.Create();

            return Convert.ToBase64String(sha.ComputeHash(Encoding.ASCII.GetBytes(text)));
        }
    }
}
