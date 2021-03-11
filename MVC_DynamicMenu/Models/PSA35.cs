using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class PSA35
    {
        [Key]
        public int Reference { get; set; }
        public String Client { get; set; }
        public String Unit { get; set; }
        public String Entry_Date { get; set; }
        public String Last_Updated { get; set; }
    }
}
