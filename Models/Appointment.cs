using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_hm433314.Models
{
    public class Appointment
    {public int PatientID { get; set; }
     public int DoctorID{ get; set; }
     public DateTime AppointmentDate{ get; set; }
     public string AppointmentReason{ get; set; }
    }
}