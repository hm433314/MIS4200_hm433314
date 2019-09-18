using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_hm433314.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string DFName { get; set; }
        public string DLName { get; set; }
        public string DEmail { get; set; }
        public string DPhone { get; set; }

        public string DFullName { get
            {
                return DLName + "," + DFName;
            }

        }

        public ICollection<Appointment> Appointment { get; set; }
    }
}