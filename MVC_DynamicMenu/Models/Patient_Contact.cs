using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Patient_Contact
    {
        [Key]
        public int ContactID { get; set; }
        public String Name { get; set; }
        public String Relationship { get; set; }
        public String Phone { get; set; }
        public String Disclose_Address { get; set; }
        public String Line1 { get; set; }
        public String Line2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public String Type_of_housing { get; set; }
        public String Start_Date { get; set; }
        public String Security { get; set; }
        public String LivingWith { get; set; }
        public String Comment { get; set; }
        public int emargencyPhone{ get; set; }
        public String Can_text { get; set; }
        public String Email { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

    }
}
