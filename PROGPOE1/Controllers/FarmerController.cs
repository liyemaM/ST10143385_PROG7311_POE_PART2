﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROGPOE1.DAL;
using PROGPOE1.Models.DBEntities;
using System.Security.Claims;

namespace PROGPOE1.Controllers
{
    [Authorize(Roles = "Farmer")]
    public class FarmerController : Controller
    {
        private readonly EmployeeDbContext _context;

        public FarmerController(EmployeeDbContext context)
        {
            _context = context;
        }

         // For the farmer dashbaord
        public IActionResult Dashboard()
        {
            var username = User.Identity?.Name;

            if (string.IsNullOrEmpty(username))
                return Unauthorized();

            var farmer = _context.Users.FirstOrDefault(u => u.Username == username && u.Role == "Farmer");

            if (farmer == null)
                return Unauthorized();

            var products = _context.Products
                .Where(p => p.UserId == farmer.Id)
                .ToList();

            return View(products);
        }

        // for the farmer AddProduct
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            var username = User.Identity?.Name;
            var farmer = _context.Users.FirstOrDefault(u => u.Username == username && u.Role == "Farmer");

            if (farmer == null)
            {
                TempData["errorMessage"] = "Unauthorized access.";
                return RedirectToAction("Login", "User");
            }

            // to check if all the needed fields in the form are there
            if (string.IsNullOrWhiteSpace(product.Name) || string.IsNullOrWhiteSpace(product.Category) || product.ProductionDate == default)
            {
                TempData["errorMessage"] = "Please fill in all fields.";
                return View(product);
            }

            product.UserId = farmer.Id;
            product.DateAdded = DateTime.Now;

            _context.Products.Add(product);
            _context.SaveChanges();

            TempData["successMessage"] = "Product added successfully!";
            return RedirectToAction("Dashboard");
        }
    }
    }
