using System.ComponentModel.DataAnnotations.Schema;

namespace SIMS.API.Models
{
    public class BachelorsMentor
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string MentorName { get; set; }
    }
}