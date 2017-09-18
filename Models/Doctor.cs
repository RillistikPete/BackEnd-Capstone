using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BECaptsone.Models
{
    public class Doctor : ApplicationUser
    {

        [Required]
        public string Expertise { get; set; }
 
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}