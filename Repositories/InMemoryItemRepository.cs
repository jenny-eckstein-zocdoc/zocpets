using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultNamespace
{
    public class InMemoryItemRepository
    {
        private readonly List<Doctor> doctors = new List<Doctor>()
        {
            new Doctor() { VetId = "1", Name = "Dr. Dogfan", Specialty = "dog" },
            new Doctor() { VetId = "2", Name = "Dr. Purrfect", Specialty = "cat" },
            new Doctor() { VetId = "3", Name = "Dr. Runalot", Specialty = "ferret" }
        };

        private readonly List<Appointment> appointments = new List<Appointment>()
        {
            new Appointment() { ApptId = "10001", VetId = "1", ApptDate = "07/21/2022", ApptTime = "09:00 AM" },
            new Appointment() { ApptId = "10002", VetId = "2", ApptDate = "07/21/2022", ApptTime = "10:00 AM" },
            new Appointment() { ApptId = "10003", VetId = "3", ApptDate = "07/21/2022", ApptTime = "09:00 AM" },
            new Appointment() { ApptId = "10004", VetId = "1", ApptDate = "07/21/2022", ApptTime = "11:00 AM" },
            new Appointment() { ApptId = "10005", VetId = "2", ApptDate = "07/21/2022", ApptTime = "04:00 PM" },
            new Appointment() { ApptId = "10006", VetId = "3", ApptDate = "07/21/2022", ApptTime = "12:30 PM" },
            new Appointment() { ApptId = "10007", VetId = "1", ApptDate = "07/21/2022", ApptTime = "01:00 PM" },
        };

        public Appointment BookAppointment(string id)
        {
            appointments.Find(a => a.ApptId == id).isBooked = true;
            var appt = appointments.Find(a => a.ApptId == id);
            Console.WriteLine("Is Booked");
            foreach (var a in appointments)
            {
                Console.WriteLine(a.ApptId);
                Console.WriteLine(a.isBooked);
            }
            return appt;
        }
        
        public IEnumerable<Appointment> GetAppointments()
        {
            return appointments;
        }

        public Appointment GetAppointment(string id)
        {
            return appointments.Where(item => item.ApptId == id).SingleOrDefault();
        }

        public IEnumerable<Appointment> GetDoctorAppointments(string id)
        {
            return appointments.Where(appt => appt.VetId == id);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return doctors;
        }

        public Doctor GetDoctor(string id)
        {
            return doctors.Where(item => item.VetId == id).SingleOrDefault();
        }
    }
}