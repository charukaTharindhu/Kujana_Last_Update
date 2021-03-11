using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Programs
    {
        [Key]
        public int ProgramID { get; set; }
        public String Program { get; set; }
        public String Commenced { get; set; }
        public String DateOfExit { get; set; }
        public String Status { get; set; }
        public String Pause { get; set; }
        public String Resume { get; set; }
        public String Setting { get; set; }
    }
}
