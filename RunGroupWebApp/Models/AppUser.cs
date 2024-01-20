namespace RunGroupWebApp.Models
{
    public class AppUser 
    {
        public int? Pace { get; set; }
        public int? Milage { get; set; }
        public Address? Address { get; set; }    
    
        public ICollection<RunningClub> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }

    }
}
