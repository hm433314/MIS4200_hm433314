using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_hm433314.Models
{
    public class Appointment
    {[Key] public int AppointmentID { get; set; }
     
     [Display (Name ="Appointment Date")]
     public DateTime AppointmentDate{ get; set; }

     [Display(Name = "Appointment Reason")]
      public string AppointmentReason{ get; set; }

     [Display(Name = "Appointment Medication")]
     public string AppointmentMedication { get; set; }

      
     public int DoctorID { get; set; }

     [Display(Name = "Doctor Name")]
     public virtual Doctor Doctor  { get; set; }

       
     public int PatientID { get; set; }

     [Display(Name = "Patient Name")]
      public virtual Patient Patient { get; set; }

    }
}