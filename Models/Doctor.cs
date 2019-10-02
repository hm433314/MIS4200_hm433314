using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_hm433314.Models
{
    public class Doctor
    {
      
        public int DoctorID { get; set; }

        [Display(Name = "Doctor First Name")]
        public string DFName { get; set; }

        [Display(Name = "Doctor Last Name")]
        public string DLName { get; set; }

        [Display(Name = "Doctor Email")]
        public string DEmail { get; set; }

        [Display(Name = "Doctor Phone Number")]
        public string DPhone { get; set; }

        public string DFullName { get
            {
                return DLName + "," + DFName;
            }

        }

        public ICollection<Appointment> Appointment { get; set; }
    }
}