namespace PeopleIndex.Models
{
    public class PeopleWhoSpeakLanguage
    {
        public int Id { get; set; }
        public Person People { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
