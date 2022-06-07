﻿using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using PeopleIndex.Models;

namespace PeopleIndex.NewFolder
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly AppDbContext _appDbContext;
        public PeopleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Person> AllPeople
        {
            get { return _appDbContext.People; }
        }
    }
}