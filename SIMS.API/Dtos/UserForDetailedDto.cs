using System;
using System.Collections.Generic;
using SIMS.API.Models;

namespace SIMS.API.Dtos
{
    public class UserForDetailedDto
    {
        // original
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return LastName + ", " + FirstName;} }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CurrentAcademicLevel { get; set; }
        public string DegreeProgram { get; set; }
        public string CurrentProgram { get; set; }
        public string Notes { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotosForDetailedDto> Photos { get; set; }
        

        // Bachelors Info
        public DateTime BachelorsStartDate { get; set; }
        public string BachelorsMentor { get; set; }
        public string BachelorsProjectAdvisor { get; set; }
        public string BachelorsThesisAdvisor { get; set; }
        public string BachelorsProjectTitle { get; set; }
        public string BachelorsThesisTitle { get; set; }
        public DateTime BachelorsGradDate { get; set; }

        // Masters Info
        public DateTime MastersStartDate { get; set; }
        public string MastersFocus { get; set; }
        public string MastersProjectAdvisor { get; set; }
        public string MastersThesisAdvisor { get; set; }
        public MastersCommittee MastersCommitteeMembers { get; set; }
        public DateTime MastersCommitteeFormDate { get; set; }
        public DateTime MastersDefenseDate { get; set; }
        public string MastersProjectTitle { get; set; }
        public string MastersThesisTitle { get; set; }
        public DateTime MastersGradDate { get; set; }

        //PhD Info
        public string DoctoralCandidate { get; set; }
        public DateTime DoctorateStartDate { get; set; }
        public DateTime DateAcceptedForCandidacy { get; set; }
        public string DoctorateAdvisor { get; set; }
        public string ExternalAdvisor { get; set; }
        public ICollection<DoctorateCommittee> DoctorateCommitteMembers { get; set; }
        public DateTime DissertationDefenseDate { get; set; }
        public string DissertationTitle { get; set; }
        public DateTime DoctorateGradDate { get; set; }
    }
}