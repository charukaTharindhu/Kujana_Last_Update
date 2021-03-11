using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class FoodAndFluid
    {
        [Key]
        public int ClientID { get; set; }
        public String Client_Name { get; set; }
        public String Pending_Plans { get; set; }
        public String Approved_Plane { get; set; }
    }
}
