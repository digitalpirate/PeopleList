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
        private readonly AppDbContext _appDbContext;
        public PeopleController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        private readonly PeopleRepository _peopleRepository;
        public PeopleRepository(PeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
        }
        public IEnumerable<Person> AllPeople
        {
            get { return _appDbContext.People; }
        }
        
        public IActionResult Index()
        {
            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _peopleRepository.AllPeople
            };

            return View(peopleViewModel);
        }
        [HttpPost]
        public IActionResult AddPerson(string name, string phoneNumber, string city)
        {
            var newPerson = new Person()
            {
                Name = name,
                PhoneNumber = phoneNumber,
                City = city
            };

            _appDbContext.People.Add(newPerson);

            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _peopleRepository.AllPeople
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
            _appDbContext.People.Remove(person);
            _appDbContext.SaveChanges();

            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _peopleRepository.AllPeople
            };

            return View(peopleViewModel);
        }
    }
}
