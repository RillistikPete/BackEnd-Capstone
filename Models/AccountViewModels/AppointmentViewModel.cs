using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BECaptsone.Models.AccountViewModels
{
    public class AppointmentViewModel
    {
        public List<Appointment> Appointments { get; set; }
    }
}
