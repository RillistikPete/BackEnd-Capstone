using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BECaptsone.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "UserRoles")]
        public string UserRoles { get; set; }
        
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string CustomUserName { get; set; }

        [Display(Name = "Expertise")]
        public string Expertise { get; set; }

        [StringLength(100, ErrorMessage = "Please limit the state of illness description to 100 characters")]
        [Display(Name = "State Of Illness Description")]
        public string StateOfIllness { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password must match confirmation password.")]
        public string ConfirmPassword { get; set; }
    }
}
