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
        [Required(ErrorMessage ="Patient First Name is Required")]
        [StringLength(100)]
        public string PFName { get; set; }

        [Display(Name = "Patient Last Name")]
        [Required(ErrorMessage ="Patient Last Name is Required")]
        [StringLength(100)]
        public string PLName { get; set; }

        [Display(Name = "Patient Email")]
          [Required(ErrorMessage ="Patient Email is Required")]
        [StringLength(100)]
        public string PEmail { get; set; }

        [Display(Name = "Patient Phone Number")]
        [Required(ErrorMessage ="Patient Phone is Required")]
        public string PPhone { get; set; }

        public string PFullName { get
            {
                return PLName + "," + PFName;
            } }
        public ICollection<Appointment> Appointment { get; set; }
    }
}