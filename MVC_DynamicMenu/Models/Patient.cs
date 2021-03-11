using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Patient
    {
        [Key]
        public int PatientID { get; set; }
        public String Full_Name { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }
        public int Age { get; set; }
        public int Telephone { get; set; }
        public String Email { get; set; }
        public String Supervisor { get; set; }
        public String Emergency_Contact_Name { get; set; }
        public int Emergency_Contact_No { get; set; }


        public List<Patient_Info> Patient_Info { get; set; }
        public List<Patient_Contact> patient_Contacts { get; set; }
        public List<Summerising> summerisings { get; set; }
        public List<Patient_Helth> patient_Helths { get; set; }
        public List<Programs> programs { get; set; }
        public List<Case_Worker> Case_Worker { get; set; }
        public List<Housing_Register_Application> Housing_Register_Application { get; set; }
        public List<Commencement_Issuse> Commencement_Issuse { get; set; }
        public List<CareTeams> CareTeams { get; set; }
        public List<Files> Files { get; set; }



    }
}
