using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_hm433314.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PFName { get; set; }
        public string PLName { get; set; }
        public string PEmail { get; set; }
        public string PPhone { get; set; }

        public string PFullName { get
            {
                return PLName + "," + PFName;
            } }
        public ICollection<Appointment> Appointment { get; set; }
    }
}