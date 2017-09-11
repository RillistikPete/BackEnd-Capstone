using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BECaptsone.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Expertise { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}