namespace Hospital.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BloodGroup { get; set; }
    }
}
