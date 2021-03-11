using FSharp.Data.Runtime.StructuralTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Menus
    {
        [Key]
        public int MenuId { get; set; }
        public String Menu { get; set; } 
        public String Url { get; set; }


       
    }
}
