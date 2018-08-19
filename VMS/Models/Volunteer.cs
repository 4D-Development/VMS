using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VMS.Models
{
    public class Volunteer
    {
        public int VolunteerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CentersPreferredToWork { get; set; }
        public string SkillsInterests { get; set; }
        public string AvailabilityTimes { get; set; }
        public string Address { get; set; }
        public string HomeWorkCellPhoneNumber { get; set; }
        public string Email { get; set; }
        public string EducationalBackground { get; set; }
        public string CurrentLicenses { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactHomeWorkPhone { get; set; }
        public string EmergencyContactEmail { get; set; }
        public string EmergencyContactAddress { get; set; }
        public bool CopyOfVolunteerDriverLicenseOnFile { get; set; }
        public bool CopyOfVolunteerSocialSecurityCardOnFile { get; set; }
        public string ApprovalStatus { get; set; }
    }
}
