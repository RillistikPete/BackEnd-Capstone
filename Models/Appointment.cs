using System;
using System.ComponentModel.DataAnnotations;

namespace BECaptsone.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        
        [Required]
        public DateTime Date { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }



    }
}