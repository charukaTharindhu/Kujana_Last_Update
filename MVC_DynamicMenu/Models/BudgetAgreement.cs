using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class BudgetAgreement
    {
        [Key]
        public int Reference { get; set; }
        public int NDIS_ID { get; set; }
        public String Client { get; set; }
        public String Date_of_birth { get; set; }
        public String Start_Date { get; set; }
        public String End_Date { get; set; }
        public String Actions { get; set; }
    }
}
