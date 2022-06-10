using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using PeopleIndex.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleIndex.Controllers
{
    public class PeopleController : Controller
    {
        private readonly AppDbContext _context;
        public PeopleController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           List<Person> listOfPeople=_context.People
                .Include(c => c.City)
                .ToList();

           return View(listOfPeople);
        }
        [HttpPost]
        public IActionResult Index(string search)
        {
            var searchPeople =  from ppl in _context.People.Include(c => c.City)
                                where ppl.City.CityName == search || ppl.Name == search
                                select ppl;

            return View(searchPeople);
        }
        public IActionResult Create()
        {
            ViewBag.City = new SelectList(_context.Cities, "CityId", "CityName");
            ViewBag.Language = new SelectList(_context.Languages, "LanguageId", "LanguageName");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Person newPerson)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(newPerson);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Remove(int id)
        {
            var deleteEntry=_context.People.Find(id);
            _context.People.Remove(deleteEntry);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        /*[HttpPost]
        public IActionResult Order(string order)
        {
            if (order == "ascending")
            {
                var orderByAscendingPeople = from ppl in _context.People
                                                 //where ppl.City == search || ppl.Name == search
                                             orderby ppl.Name ascending
                                             select ppl;
                return View(orderByAscendingPeople);
            }
            else
                return RedirectToAction("Index");
        }*/
    }
}
