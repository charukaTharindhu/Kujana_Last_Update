using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class NewBudgetAgreement
    {
        [Key]

        public int ClientID { get; set; }
        public String Client_Name { get; set; }
        public String Start_Date { get; set; }
        public String End_Date { get; set; }
        public String Select_Program { get; set; }
        public String Support_purpose { get; set; }
        public String Support_category { get; set; }
        public String Budget { get; set; }
        public String Remaining_budget { get; set; }
        public String Biler_type { get; set; }
        public String Support_Item { get; set; }
        public String Biller_type { get; set; }
        public String Service_Provider { get; set; }
        public String Ration { get; set; }
        public String SVC_Booking { get; set; }
        public String Qty_week { get; set; }
        public String Week { get; set; }
        public String Total_units { get; set; }
        public String Unit_of_measure { get; set; }
        public String Unit_Price { get; set; }
        public String Total_price { get; set; }
        public String Description_of_costs { get; set; }
        public String Biller { get; set; }
        public String Notes { get; set; }
        public String Debtor { get; set; }
       
    }
}
