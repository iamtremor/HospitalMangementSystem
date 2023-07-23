using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hospital.Models
{
    public class NewModel
    {
        public List<string> AvailableBloodGroups { get; set; }
    }
    public class RegistrationSuccessViewModel
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
        public int PatientId { get; set; } 
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; }

        public List<SelectListItem> Providers { get; set; }
    }

}
