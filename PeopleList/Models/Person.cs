using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleIndex.Models
{
    public class Person 
    {
        [Key]
        public int PersonId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public int CityId { get; set; }
        
        public City City { get; set; }
                
        public List<PeopleWhoSpeakLanguage> LanguageOfPerson { get; set; }
        
    }
}
