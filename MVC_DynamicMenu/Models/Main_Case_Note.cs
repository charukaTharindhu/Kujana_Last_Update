using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Main_Case_Note
    {
        public int NoteID { get; set; }
        public String Date { get; set; }
        public int Hours { get; set; }
        public String Participant { get; set; }
        public String Note_summary { get; set; }
        public String Added_by { get; set; }
        public String Contact_type { get; set; }
    }
}
