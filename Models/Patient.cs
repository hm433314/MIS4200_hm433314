using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_hm433314.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        [Display(Name = "Patient First Name")]
        public string PFName { get; set; }

        [Display(Name = "Patient Last Name")]
        public string PLName { get; set; }

        [Display(Name = "Patient Email")]
        public string PEmail { get; set; }

        [Display(Name = "Patient Phone Number")]
        public string PPhone { get; set; }

        public string PFullName { get
            {
                return PLName + "," + PFName;
            } }
        public ICollection<Appointment> Appointment { get; set; }
    }
}