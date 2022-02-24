namespace TestProject1.Models
{
    public class Calendar
    {
        public System System { get; set; }
        public Sanctorale Sanctorale { get; set; }
    }

    public class System
    {
        public int Promulgated { get; set; }
        public int EffectiveSince { get; set; }
        public string Desc { get; set; }
    }

    public class Sanctorale
    {
        public string Title { get; set; }
        public string Language { get; set; }
    }

}
