using Microsoft.AspNetCore.Identity;

namespace PeopleIndex.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        
    }
}
