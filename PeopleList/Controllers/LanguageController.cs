using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using PeopleIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleIndex.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class LanguageController : Controller
    {
        private readonly AppDbContext _context;
        public LanguageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Languages()
        {
            List<Language> listOfLanguages = _context.Languages.ToList();
            return View(listOfLanguages);
            
        }
        public IActionResult Create()
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
