using Microsoft.AspNetCore.Mvc;
using PeopleIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleIndex.Controllers
{
    public class LanguageController : Controller
    {
        private readonly AppDbContext _context;
        public LanguageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Languages()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Language newlanguage)
        {
            if (ModelState.IsValid)
            {
                _context.Languages.Add(newlanguage);
                _context.SaveChanges();
                return RedirectToAction("Languages");
            }
            return View();
        }
        public IActionResult Remove(int languageId)
        {
            var deleteEntry = _context.Languages.Find(languageId);
            _context.Languages.Remove(deleteEntry);
            _context.SaveChanges();
            return RedirectToAction("Languages");
        }
    }
}
