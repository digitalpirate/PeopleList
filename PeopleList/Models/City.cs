using System.Collections.Generic;

namespace PeopleIndex.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public List<Person> PeopleInCity { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
