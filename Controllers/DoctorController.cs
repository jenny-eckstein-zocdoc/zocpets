using System;
using System.Collections.Generic;
using System.Linq;
using DefaultNamespace;
using Microsoft.AspNetCore.Mvc;
using zocpets.Controllers;

namespace zocpets.Controllers
{
    [ApiController]
    [Route("doctors")]
    public class ItemsController: ControllerBase
    {
        private readonly InMemoryItemRepository repository;
        private readonly AppointmentController appointmentController;

        public ItemsController()
        {
            repository = new InMemoryItemRepository();
            appointmentController = new AppointmentController();
        }

        [HttpGet]
        public IEnumerable<Doctor> GetItems()
        {
            var items = repository.GetDoctors();
            return items;
        }

        [HttpGet("{id}")]
        public Doctor GetItem(string id)
        {
            var item = repository.GetDoctor(id);
            return item;
        }
        
        [HttpGet("appointments")]
        public IEnumerable<Doctor> GetDoctorsWithAppointments()
        {
            var doctors = GetItems().ToList();
            
            foreach (var doc in doctors)
            {
              
                    var drAppts = appointmentController.GetDoctorAppointments(doc.VetId);
                    doc.Appointments = drAppts;
                
                    
                
            }
            return doctors;
        }
    }
}