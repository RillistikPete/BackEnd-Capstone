using System;

namespace BECaptsone.Models
{
    public class NewAppointmentViewModel
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public DateTime Date {get;set;}

        public NewAppointmentViewModel()
        {
            this.Date = DateTime.Now;
        }
    }
}