using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BECaptsone.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please limit the state of illness description to 100 characters")]
        public string StateOfIllness { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}