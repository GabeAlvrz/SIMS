using System;
using System.ComponentModel.DataAnnotations;

namespace SIMS.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "You must specify password between 8 and 16")]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string CurrentAcademicLevel { get; set; }
        public string DegreeProgram { get; set; }
        public string CurrentProgram { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
        public DateTime? BachelorsStartDate { get; set; }
        public string BachelorsMentor { get; set; }
        public string BachelorsProjectAdvisor { get; set; }
        public string BachelorsThesisAdvisor { get; set; }
        public string BachelorsProjectTitle { get; set; }
        public string BachelorsThesisTitle { get; set; }
        public DateTime? BachelorsGradDate { get; set; }

        // Masters Info
        public DateTime? MastersStartDate { get; set; }
        public string MastersFocus { get; set; }
        public string MastersProjectAdvisor { get; set; }
        public string MastersThesisAdvisor { get; set; }
        public string MastersCommitteeMember1 { get; set; }
        public string MastersCommitteeMember2 { get; set; }
        public string MastersCommitteeMember3 { get; set; }
        public string MastersCommitteeMember4 { get; set; }
        public string MastersCommitteeMember5 { get; set; }
        public DateTime? MastersCommitteeFormDate { get; set; }
        public DateTime? MastersDefenseDate { get; set; }
        public string MastersProjectTitle { get; set; }
        public string MastersThesisTitle { get; set; }
        public DateTime? MastersGradDate { get; set; }

        //PhD Info
        public string DoctoralCandidate { get; set; }
        public DateTime? DoctorateStartDate { get; set; }
        public DateTime? DateAcceptedForCandidacy { get; set; }
        public string DoctorateAdvisor { get; set; }
        //public AdvisorDto ExternalAdvisor { get; set; }
        public string DoctorateCommitteMember1 { get; set; }
        public string DoctorateCommitteMember2 { get; set; }
        public string DoctorateCommitteMember3 { get; set; }
        public string DoctorateCommitteMember4 { get; set; }
        public string DoctorateCommitteMember5 { get; set; }
        public string DoctorateCommitteMember6 { get; set; }
        public DateTime? DissertationDefenseDate { get; set; }
        public string DissertationTitle { get; set; }
        public DateTime? DoctorateGradDate { get; set; }
        
    }
}