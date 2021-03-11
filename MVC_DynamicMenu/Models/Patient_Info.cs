using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Patient_Info
    {
        [Key]
        public int Patient_InfoID { get; set; }
        public int NDIS_Number { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public String DateOfBirth { get; set; }
        public String Office { get; set; }
        public String Country { get; set; }
        public String COB_Comment { get; set; }
        public String Indegenous_status { get; set; }
        public String Other_Cultural_Issues { get; set; }
        public String Language_spoken_at_home { get; set; }
        public String Interpreted_needed { get; set; }
        public String Comments { get; set; }
        public String Primary_income_source { get; set; }
        public String Effective_date { get; set; }
        public String CeterLink_Number { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
