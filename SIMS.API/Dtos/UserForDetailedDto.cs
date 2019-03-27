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
        public string DateOfBirth { get; set; }
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
        public string BachelorsStartDate { get; set; }
        public string BachelorsMentor { get; set; }
        public string BachelorsProjectAdvisor { get; set; }
        public string BachelorsThesisAdvisor { get; set; }
        public string BachelorsProjectTitle { get; set; }
        public string BachelorsThesisTitle { get; set; }
        public string BachelorsGradDate { get; set; }

        // Masters Info
        public string MastersStartDate { get; set; }
        public string MastersFocus { get; set; }
        public string MastersProjectAdvisor { get; set; }
        public string MastersThesisAdvisor { get; set; }
        public CommitteeDto MastersCommittee { get; set; }
        public string MastersDefenseDate { get; set; }
        public string MastersProjectTitle { get; set; }
        public string MastersThesisTitle { get; set; }
        public string MastersGradDate { get; set; }

        //PhD Info
        public string DoctoralCandidate { get; set; }
        public string DoctorateStartDate { get; set; }
        public string DateAcceptedForCandidacy { get; set; }
        public string DoctorateAdvisor { get; set; }
        public string ExternalAdvisor { get; set; }
        public CommitteeDto DoctorateCommittee { get; set; }
        public string DissertationDefenseDate { get; set; }
        public string DissertationTitle { get; set; }
        public string DoctorateGradDate { get; set; }
    }
}