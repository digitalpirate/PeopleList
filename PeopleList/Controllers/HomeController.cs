using Microsoft.AspNetCore.Mvc;
using PeopleList.Models;
using PeopleList.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleList.Controllers
{
    public class HomeController : Controller
    {
        private readonly PeopleRepository _peopleRepository;
        public HomeController(PeopleRepository peopleRepository)
        {
            _peopleRepository = peopleRepository;
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
            {
                var newPerson = new Person()
                {

                    Name = name,
                    PhoneNumber = phoneNumber,
                    City = city
                };

                _peopleRepository.



                PeopleViewModel peopleViewModel = new PeopleViewModel
                {
                    Person = _peopleRepository.AllPeople
                };

                return View(peopleViewModel);

            }
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
            context.People.Remove(person);
            context.SaveChanges();

            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _peopleRepository.AllPeople
            };

            return View(peopleViewModel);
        }
    }
}