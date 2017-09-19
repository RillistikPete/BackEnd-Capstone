using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BECaptsone.Models
{
    // Add profil e data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        // public ApplicationUser()
        // {
        //     this.FullName = this.FirstName + " " + this.LastName;
        // }
        // public string FullName { get; set; }
        public string FullName => string.Format("{0} {1}", FirstName, LastName);
        
        [NotMapped]
        //NotMapped means it will not be in the DB, but it will be a property here on AppUser
        //so that you can use it in the join table controller! (FullName)


        [Display(Name = "User Name")]
        public string CustomUserName { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public byte[] UserPhoto { get; set; }

        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
