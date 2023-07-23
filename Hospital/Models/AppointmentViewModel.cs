using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hospital.Models
{
    public class AppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; }
        public List<SelectListItem> Providers { get; set; }

    }

}
