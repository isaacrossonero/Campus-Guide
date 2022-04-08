using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace RoleBasedAuth.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                return RedirectToAction("Login"); 
            }

            ClaimsIdentity identity = null;
            #pragma warning disable CS0219 // Variable is assigned but its value is never used
            bool isAuthenticated = false;
            #pragma warning restore CS0219 // Variable is assigned but its value is never used

            //Creating anew user 'Admin'. This user will have specific priveledges. 
            if (username == "admin" && password == "a")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "Admin")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                //This is set to true since the credentials entered match the 'Admin' properties and therefore the user has been authenticated.
                isAuthenticated = true;
            }
            //Creating anew user 'Demo'. This user will have specific priveledges. 
            if (username == "demo" && password == "d")
            {
                identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, "User")
                }, CookieAuthenticationDefaults.AuthenticationScheme);

                //This is set to true since the credentials entered match the 'User' properties and therefore the user has been authenticated.
                isAuthenticated = true;
            }
            if(isAuthenticated)
            {
                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
