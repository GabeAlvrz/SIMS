namespace SIMS.API.Models
{
    public class DoctorateAdvisor
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string AdvisorName { get; set; }
    }
}