using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class AddNewFoodAndFluid
    {
        [Key]

        public int ClientID { get; set; }
        public String Client_Name { get; set; }
        public String Start_date { get; set; }
        public String End_date { get; set; }
        public String Breakfast { get; set; }
        public String Lunch { get; set; }
        public String Diner { get; set; }
        public String Additional_Food { get; set; }
        public String Breakfast_Fluid { get; set; }
        public String Lunch_Fluid { get; set; }
        public String Status { get; set; }
        public String Diner_Fluid { get; set; }
        public String Toal_Calories { get; set; }
        public String Staf_Name { get; set; }
    }
}
