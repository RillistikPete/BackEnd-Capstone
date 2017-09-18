using System;
using System.Collections.Generic;
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
        //include these instances as FK thingies (Doctor Doctor) so that:
        // .Include(a => a.Doctor) lets you pull back an object of a Doctor.
        // without that it just gets the id
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}