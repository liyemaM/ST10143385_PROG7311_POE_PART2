using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROGPOE1.DAL;
using PROGPOE1.Models.DBEntities;

namespace PROGPOE1.Controllers
{
    [Authorize(Roles = "Employee")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _context;

        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var farmers = _context.Farmers.ToList();
            return View(farmers);
        }

        [HttpGet]
        public IActionResult AddFarmer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddFarmer(Farmer farmer)
        {
            if (!ModelState.IsValid)
            {
                TempData["errorMessage"] = "Please fill in all fields.";
                return View(farmer);
            }

            _context.Farmers.Add(farmer);
            _context.SaveChanges();

            TempData["successMessage"] = "Farmer added successfully!";
            return RedirectToAction("Index"); // or wherever appropriate
        }

        [HttpGet]
        public IActionResult ViewProducts()
        {
            var products = _context.Products.Include(p => p.User).ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult ViewProducts(string productType, DateTime? fromDate, DateTime? toDate)
        {
            var products = _context.Products.Include(p => p.User).AsQueryable();

            if (!string.IsNullOrEmpty(productType))
            {
                products = products.Where(p => p.Category == productType);
            }

            if (fromDate.HasValue)
            {
                products = products.Where(p => p.ProductionDate >= fromDate.Value);
            }

            if (toDate.HasValue)
            {
                products = products.Where(p => p.ProductionDate <= toDate.Value);
            }

            return View(products.ToList());
        }

    }
}
