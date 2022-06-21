using System.Collections.Generic;

namespace PeopleIndex.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public int PersonId { get; set; }

        public List<PersonLanguage> Languages { get; set; }
    }
}
