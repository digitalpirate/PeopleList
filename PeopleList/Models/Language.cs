﻿using System.Collections.Generic;

namespace PeopleIndex.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        
        public ICollection<PersonLanguage> People { get; set; }
    }
}
