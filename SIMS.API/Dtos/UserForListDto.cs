using System;

namespace SIMS.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string PhotoUrl { get; set; }
    }
}