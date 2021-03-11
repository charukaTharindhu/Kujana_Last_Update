using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class NewTherapyLog
    {
        [Key]
        public int ClientID { get; set; }
        public String Client_Name { get; set; }
        public String Entry_date { get; set; }
        public String Hierarchy { get; set; }
        public String Mental_Duration_Time { get; set; }
        public String Mental_Before_Therapy { get; set; }
        public String Mental_After_Therapy { get; set; }
        public String Mental_Exercises { get; set; }
        public String Mental_Client_Concerns { get; set; }
        public String Mental_Status { get; set; }
        public String Physical_Duration_Time { get; set; }
        public String Physical_Before_Therapy { get; set; }
        public String Physical_After_Therapy { get; set; }
        public String Physical_Exercises { get; set; }
        public String Physical_Client_Concerns { get; set; }
        public String Physical_Status { get; set; }
    }
}
