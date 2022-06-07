using Microsoft.AspNetCore.Mvc;
using PeopleIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleIndex.Controllers
{
    public class CityController : Controller
    {
        private readonly AppDbContext _context;
        public CityController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Cities()
        {
            List<City> listOfCities = _context.Cities.ToList();
            return View(listOfCities);
        }

        public IActionResult Create()
        {
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
