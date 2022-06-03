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
        private readonly IPeopleRepository _peopleRepository;
        public HomeController(IPeopleRepository peopleRepository)
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
        public IActionResult Index(int id,string name, string phoneNumber, string city)
        {
            {
                Models.Person.AddNewPerson(id, name, phoneNumber, city);
                

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
            //DeletePerson(id);
            PeopleViewModel peopleViewModel = new PeopleViewModel
            {
                Person = _peopleRepository.AllPeople
            };

            return View(peopleViewModel);
        }
    }
}