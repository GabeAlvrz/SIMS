using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace SIMS.API.Models
{
    public class User : IdentityUser<int>
    {
        // working
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Level { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }


        
        public string DegreeProgram { get; set; }
        public string CurrentProgram { get; set; }

        public string CurrentAcademicLevel { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }

        //Bachelors Info
        public DateTime BachelorStartDate { get; set; }
        // public Faculty BachelorMentor { get; set; }
        // public Faculty SeniorProjectAdvisor { get; set; }
        // public Faculty SeniorThesisAdvisor { get; set; }
        public string BachelorProjectTitle { get; set; }
        public string BachelorThesisTitle { get; set; }
        public DateTime BachelorGradDate { get; set; }

        //Masters Info
        public string MasterFocus { get; set; }
        public DateTime MasterStartDate { get; set; }
        // public Faculty MasterProjectAdvisor { get; set; }
        // public Faculty MasterThesisAdvisor { get; set; }
        // public Faculty MasterCommMember1 { get; set; }
        // public Faculty MasterCommMember2 { get; set; }
        // public Faculty MasterCommMember3 { get; set; }
        // public Faculty MasterCommMember4 { get; set; }
        // public Faculty MaseterCommMember5 { get; set; }
        public DateTime CommFormedDate { get; set; }
        public DateTime MasterDefenseDate { get; set; }
        public string MasterProjectTitle { get; set; }
        public string MasterThesisTitle { get; set; }
        public DateTime MasterGraduationDate { get; set; }

        //PhD Info
        public bool DoctoralCandidate { get; set; }
        public DateTime DateAcceptedForCandidacy { get; set; }
        // public Faculty DoctorateAdvisor { get; set; }
        // public ? ExternalAdvisor { get; set; }
        // public Faculty DoctorateCommMember1 { get; set; }
        // public Faculty DoctorateCommMember2 { get; set; }
        // public Faculty DoctorateCommMember3 { get; set; }
        // public Faculty DoctorateCommMember4 { get; set; }
        // public Faculty DoctorateCommMember5 { get; set; }
        public string DissertationDefenseDate { get; set; }
        public string DissertationTitle { get; set; }
        public string Dissertation { get; set; }
        public DateTime DoctorateGradDate { get; set; }

    }
}