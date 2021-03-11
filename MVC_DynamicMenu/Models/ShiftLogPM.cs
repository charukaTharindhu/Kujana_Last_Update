using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class ShiftLogPM
    {
        [Key]

        public int Reference { get; set; }
        public String Client { get; set; }
        public String Unit { get; set; }
        public String EntryDate { get; set; }
        public String LastUpdate { get; set; }
    }
}
