using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class ServiceSchedules
    {
        [Key]
        public int ReferenceID { get; set; }
        public String Client_name { get; set; }
        public String Start_date_and_time { get; set; }
        public String End_date_and_time { get; set; }
        public String Day_of_week { get; set; }
        public String Hierarchy { get; set; }
        public String Service { get; set; }
        public String Staff { get; set; }

        public List<LogSchedule> LogSchedule { get; set; }
        
    }
}
