using System.Collections.Generic;

namespace PeopleIndex.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public List<PeopleInCity> People { get; set; }
        public List<CitiesInCountry> Cities { get; set; }
    }
}
