namespace SIMS.API.Models
{
    public class MastersCommittee
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Member1 { get; set; }
        public string Member2 { get; set; }
        public string Member3 { get; set; }
        public string Member4 { get; set; }
        public string Member5 { get; set; }
    }
}