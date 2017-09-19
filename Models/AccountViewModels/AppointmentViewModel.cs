using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BECaptsone.Models.AccountViewModels
{
    public class AppointmentViewModel
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public List<Appointment> Appointments { get; set; }

        public DateTime Date { get; set; }
        public AppointmentViewModel()
        {
            this.Date = DateTime.Now;
        }

    }
}
