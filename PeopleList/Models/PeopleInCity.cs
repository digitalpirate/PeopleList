namespace PeopleIndex.Models
{
    public class PeopleInCity
    {
        public int Id { get; set; }
        public Person People { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }

    }
}
