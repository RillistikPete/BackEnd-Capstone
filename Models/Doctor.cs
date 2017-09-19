using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BECaptsone.Models
{
    public class Doctor : ApplicationUser
    {
        public int DoctorId { get; set; }


        [Required]
        public string Expertise { get; set; }

        public string ImgPath { get; set; }
 
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}