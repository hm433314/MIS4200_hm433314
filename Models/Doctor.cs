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
        [Required(ErrorMessage ="Doctor First Name is Required")]
        [StringLength(100)]
        public string DFName { get; set; }

        [Display(Name = "Doctor Last Name")]
        [Required(ErrorMessage ="Doctor Last Name is Required")]
        [StringLength(100)]
        public string DLName { get; set; }

        [Display(Name = "Doctor Email")]
        [Required(ErrorMessage ="Doctor Email is Required")]
        [StringLength(100)]
        public string DEmail { get; set; }

        [Display(Name = "Doctor Phone Number")]
        [Required(ErrorMessage = "Doctor Phone Number is Required")]
        public string DPhone { get; set; }

        [Display(Name = "Doctor Name")]
        public string DFullName { get
            {
                return DLName + "," + DFName;
            }

        }

        public ICollection<Appointment> Appointment { get; set; }
    }
}