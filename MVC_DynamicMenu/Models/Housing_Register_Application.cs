using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Housing_Register_Application
    {
        [Key]
        public int ApplicationID { get; set; }
        public String AolicationType { get; set; }
        public String priority_catogory { get; set; }
        public String Date_Submited { get; set; }
        public String Location_Submited { get; set; }
        public String Application_number { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
