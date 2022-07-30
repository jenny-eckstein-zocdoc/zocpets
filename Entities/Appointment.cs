namespace DefaultNamespace
{
    public class Appointment
    {
        public string ApptId { get; set; }
        public string VetId { get; set; }
        public string ApptDate { get; set; }
        public string ApptTime { get; set; }

        public bool isBooked { get; set; } = false;

    }
}