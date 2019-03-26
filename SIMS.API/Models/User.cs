using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using SIMS.API.Data;

namespace SIMS.API.Models
{
    public class User : IdentityUser<int>
    {
        // working
        //basic info
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName;} }
        public DateTime DateOfBirth { get; set; }
        //email in parent class
        //phone number 1 in parent class
        public string PhoneNumber2 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CurrentAcademicLevel { get; set; }
        public string DegreeProgram { get; set; }
        public string CurrentProgram { get; set; }
        public string Notes { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        

        // Bachelors Info
        public DateTime BachelorsStartDate { get; set; }
        public BachelorsMentor BachelorsMentor { get; set; }
        public BachelorsProjectAdvisor BachelorsProjectAdvisor { get; set; }
        public BachelorsThesisAdvisor BachelorsThesisAdvisor { get; set; }
        public string BachelorsProjectTitle { get; set; }
        public string BachelorsThesisTitle { get; set; }
        public DateTime BachelorsGradDate { get; set; }

        // Masters Info
        public DateTime MastersStartDate { get; set; }
        public string MastersFocus { get; set; }
        public MastersProjectAdvisor MastersProjectAdvisor { get; set; }
        public MastersThesisAdvisor MastersThesisAdvisor { get; set; }
        //public ICollection<MastersCommittee> MastersCommitteeMembers { get; set; }
        public MastersCommittee MastersCommittee { get; set; }
        public DateTime MastersCommitteeFormDate { get; set; }
        public DateTime MastersDefenseDate { get; set; }
        public string MastersProjectTitle { get; set; }
        public string MastersThesisTitle { get; set; }
        public DateTime MastersGradDate { get; set; }

        //PhD Info
        public string DoctoralCandidate { get; set; }
        public DateTime DoctorateStartDate { get; set; }
        public DateTime DateAcceptedForCandidacy { get; set; }
        public DoctorateAdvisor DoctorateAdvisor { get; set; }
        public ExternalAdvisor ExternalAdvisor { get; set; }
        // public ICollection<DoctorateCommittee> DoctorateCommitteMembers { get; set; }
        public DoctorateCommittee DoctorateCommittee { get; set; }
        public DateTime DissertationDefenseDate { get; set; }
        public string DissertationTitle { get; set; }
        public DateTime DoctorateGradDate { get; set; }

    }
}