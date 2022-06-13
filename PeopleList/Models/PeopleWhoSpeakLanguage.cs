namespace PeopleIndex.Models
{
    public class PeopleWhoSpeakLanguage
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
