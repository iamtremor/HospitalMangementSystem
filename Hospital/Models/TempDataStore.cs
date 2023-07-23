using System;
using System.Collections.Generic;

namespace Hospital.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public string Notes { get; set; }
    }

    public static class TempDataStore
    {
        private static List<Appointment> _appointments = new List<Appointment>();

        public static List<Appointment> GetAllAppointments()
        {
            return _appointments;
        }

        public static void AddAppointment(Appointment appointment)
        {
            appointment.AppointmentId = _appointments.Count + 1;
            _appointments.Add(appointment);
        }

        public static Appointment GetAppointmentById(int id)
        {
            return _appointments.Find(appointment => appointment.AppointmentId == id);
        }
        public static void ResetDataStore()
        {
            _appointments = new List<Appointment>();
        }
    }
}
