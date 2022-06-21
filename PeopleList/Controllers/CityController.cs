using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PeopleIndex.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace PeopleIndex.Controllers
{
   // [Authorize(Roles ="Admin")]
    public class CityController : Controller
    {
        private readonly AppDbContext _context;
        public CityController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Cities()
        {
            List<City> listOfCities = _context.Cities.Include(c => c.Country).ToList();
            return View(listOfCities);
        }
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(_context.Countries, "CountryId", "CountryName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(City newCity)
        {
            if (ModelState.IsValid)
            {
                _context.Cities.Add(newCity);
                _context.SaveChanges();
                return RedirectToAction("Cities");
            }
            return View();
        }
        public IActionResult Remove(int cityId)
        {
            var deleteEntry = _context.Cities.Find(cityId);
            _context.Cities.Remove(deleteEntry);
            _context.SaveChanges();
            return RedirectToAction("Cities");
        }
    }
}
