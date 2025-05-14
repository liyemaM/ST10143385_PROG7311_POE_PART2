using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PROGPOE1.DAL;
using PROGPOE1.Models.DBEntities;
using System.Security.Claims;

namespace PROGPOE1.Controllers
{
    public class UserController : Controller
    {
        private readonly EmployeeDbContext _context;

        public UserController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: /User/Register
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // POST: /User/Register
        [HttpPost]
        public IActionResult Register([Bind("Username,Password,Role")] AppUser user)
        {
            if (!ModelState.IsValid)
            {
                // Print errors for debugging
                foreach (var entry in ModelState)
                {
                    foreach (var error in entry.Value.Errors)
                    {
                        Console.WriteLine($"Field {entry.Key}: {error.ErrorMessage}");
                    }
                }

                TempData["errorMessage"] = "Please fill in all required fields.";
                return View(user);
            }

            var exists = _context.Users.Any(u => u.Username == user.Username);
            if (exists)
            {
                TempData["errorMessage"] = "Username already exists.";
                return View(user);
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            TempData["successMessage"] = "Registration successful!";
            return RedirectToAction("Login");
        }


        // GET: /User/Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /User/Login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                TempData["errorMessage"] = "❌ Username and password are required.";
                return View();
            }

            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Role, user.Role)
        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity)
                );

                TempData["successMessage"] = $"✅ Welcome, {user.Username}!";

                // Redirect ALL users to the Home page after login
                return RedirectToAction("Index", "Home");
            }

            TempData["errorMessage"] = "❌ Invalid username or password.";
            return View();
        }

        // POST: /User/Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            TempData["successMessage"] = "✅ You have been logged out.";
            return RedirectToAction("Login");
        }
    }
}
