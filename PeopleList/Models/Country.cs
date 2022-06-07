﻿using System.Collections.Generic;

namespace PeopleIndex.Models
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public List<CitiesInCountry> Cities  {get ; set;}
    }
}
