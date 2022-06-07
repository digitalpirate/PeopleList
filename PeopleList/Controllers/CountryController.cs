using Microsoft.AspNetCore.Mvc;
using PeopleIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleIndex.Controllers
{
    public class CountryController : Controller
    {
        private readonly AppDbContext _context;
        public CountryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Countries()
        {
            List<Country> listOfCountries = _context.Countries.ToList();
            return View(listOfCountries);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Country newCountry)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Add(newCountry);
                _context.SaveChanges();
                return RedirectToAction("Countries");
            }
            return View();
        }
        public IActionResult Remove(int countryId)
        {
            var deleteEntry= _context.Countries.Find(countryId);
            _context.Countries.Remove(deleteEntry);
            _context.SaveChanges();
            return RedirectToAction("Countries");
        }
    }
}
