using Microsoft.AspNetCore.Mvc;
using PeopleList.Models;
using PeopleList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleList.Controllers
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
            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _context.People.ToList()
                
            };

            return View(peopleViewModel);
        }
        [HttpPost]
        public IActionResult Index(string name, string phoneNumber, string city)
        {
            var newPerson = new Person()
            {
                Name = name,
                PhoneNumber = phoneNumber,
                City = city
            };
            _context.People.Add(newPerson);

            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _context.People.ToList()
            };
            return View(peopleViewModel);
        }

        [HttpPost]
        public IActionResult Index(string search)
        {
            //PeopleViewModel peopleViewModel = Search(search);
            //plocka ut det som matchar sökterm skicka till View.
            //return View(peopleViewModel);
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            var person = new Person()
            {
                Id = id
            };
            _context.People.Remove(person);
            _context.SaveChanges();
            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _context.People.ToList()
            };
            return View(peopleViewModel);
        }
    }
}
