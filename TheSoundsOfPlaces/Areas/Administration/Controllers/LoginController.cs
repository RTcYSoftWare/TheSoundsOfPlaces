using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using TheSoundsOfPlaces.Areas.Administration.Models;
using TheSoundsOfPlaces.Database;
using TheSoundsOfPlaces.Helpers;

namespace TheSoundsOfPlaces.Areas.Administration.Controllers
{
    [Area("Administration")]
    [AllowAnonymous]
    public class LoginController : Controller
    {
        TheSoundsOfPlacesDBContext _context;
        WordHelper wordHelper = new WordHelper();


        public LoginController(TheSoundsOfPlacesDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            LoginPageModel adminLoginPageModel = new LoginPageModel();

            adminLoginPageModel = FillAdminLoginPageModel(adminLoginPageModel, false);

            return View(adminLoginPageModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(string email, string password, string rememberMe, string returnUrl)
        {
            string encryptedPassword = wordHelper.encryptSha256(password);
            var admin = await GetAdmin(email, encryptedPassword);

            if (admin != null)
            {
                await AdminAuthentication(admin, HttpContext);

                if (rememberMe == "on")
                {
                    // To Do: remember transaction
                }

                if (!string.IsNullOrEmpty(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                LoginPageModel adminLoginPageModel = new LoginPageModel();

                adminLoginPageModel = FillAdminLoginPageModel(adminLoginPageModel, true);

                return View(adminLoginPageModel);
            }
        }

        public async Task<Admin> GetAdmin(string email, string password)
        {
            return await _context.Admins.Where(x => x.Email == email && x.Password == password && x.Status == true).FirstOrDefaultAsync();
        }

        public async Task AdminAuthentication(Admin admin, HttpContext httpContext)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, admin.Email),
                new Claim("NameSurname", admin.NameSurname),
                new Claim("GUID", admin.GUID.ToString()),
                new Claim(ClaimTypes.Role, "Administrator"),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties();

            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
        }

        public LoginPageModel FillAdminLoginPageModel(LoginPageModel adminLoginPageModel, bool error = false)
        {
            //adminLoginPageModel.Email = _cookieHandler.readCookie(CookieNamesEnum.ADMIN_EMAIL.ToString());
            //adminLoginPageModel.Password = _cookieHandler.readCookie(CookieNamesEnum.ADMIN_PASSWORD.ToString());

            if (error)
            {
                adminLoginPageModel.Error = "Email Adresiniz Veya Şifreniz Hatalıdır !!!";
            }

            return adminLoginPageModel;
        }
    }
}
