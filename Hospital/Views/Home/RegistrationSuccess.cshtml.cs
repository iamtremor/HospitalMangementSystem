using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hospital.Views.Home
{
    public class RegistrationSuccessModel : PageModel
    {
        public void OnGet()
        {
        }
    }
    public class RegistrationSuccessViewModel
    {
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }

        // Appointment information
        public int PatientId { get; set; } // Add the PatientId property
        public int ProviderId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; }

        // Add any other relevant properties for the registration success view
        public List<SelectListItem> Providers { get; set; }
    }

}
