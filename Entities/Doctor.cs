using System;
using System.Collections.Generic;

namespace DefaultNamespace
{
    public class Doctor
    {
        public string VetId { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }

        public IEnumerable<Appointment> Appointments { get; set; }
    }
}