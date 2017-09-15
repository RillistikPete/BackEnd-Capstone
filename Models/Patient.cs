using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BECaptsone.Models
{
    public class Patient : ApplicationUser
    {

        public int PatientId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Please limit the state of illness description to 100 characters")]
        public string StateOfIllness { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}