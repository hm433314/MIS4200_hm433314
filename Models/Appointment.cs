using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_hm433314.Models
{
    public class Appointment
    {[Key] public int AppointmentID { get; set; }
     
     public DateTime AppointmentDate{ get; set; }
     public string AppointmentReason{ get; set; }

        public string AppointmentMedication { get; set; }
     
     public int DoctorID { get; set; }   
     public virtual Doctor Doctor { get; set; }

     public int PatientID { get; set; }
     public virtual Patient Patient { get; set; }

    }
}