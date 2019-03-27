using System;

namespace SIMS.API.Models
{
    public class DoctorateCommittee
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime FormDate { get; set; }
        public string Member1 { get; set; }
        public string Member2 { get; set; }
        public string Member3 { get; set; }
        public string Member4 { get; set; }
        public string Member5 { get; set; }
        public string Member6 { get; set; }
    }
}