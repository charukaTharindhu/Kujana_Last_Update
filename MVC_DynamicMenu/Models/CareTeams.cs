using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class CareTeams
    {
        [Key]
        public int CareTeameID { get; set; }
        public String Sub_Program { get; set; }
        public String Group { get; set; }
        public String Referal_Date { get; set; }
        public String Referal_source { get; set; }
        public String Referal_name { get; set; }
        public String Agency_name { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }

    }
}
