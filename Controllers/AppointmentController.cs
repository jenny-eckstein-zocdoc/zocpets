using System.Collections.Generic;
using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;

namespace zocpets.Controllers
{
    [ApiController]
    [Route("appointments")]
    public class AppointmentController: ControllerBase
    {
        private readonly InMemoryItemRepository repository;

        public AppointmentController()
        {
            repository = new InMemoryItemRepository();
        }

        [HttpGet]
        public IEnumerable<Appointment> GetAppointments()
        {
            var appointments = repository.GetAppointments();
            return appointments;
        }

        [HttpGet("{id}")]
        public Appointment GetAppointment(string id)
        {
            var appt = repository.GetAppointment(id);
            return appt;
        }

        [HttpGet("/doctor/{id}")]
        public IEnumerable<Appointment> GetDoctorAppointments(string id)
        {
            var appts = repository.GetDoctorAppointments(id);
            return appts;
        }

        [HttpPost("book")]
        public Appointment BookAppt(string id)
        {
            var appt = repository.BookAppointment(id);
            return appt;
        }
    }
}