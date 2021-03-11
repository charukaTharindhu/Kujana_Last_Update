using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class AddNewSLESProgress
    {
        [Key]
        public int ClientID { get; set; }
        public String Client { get; set; }
        public String EntryDate { get; set; }
        public String Hierarchy { get; set; }
        public String Date { get; set; }
        public String TypeOfContact { get; set; }
        public String Activity { get; set; }
        public String AnyBarrierssIdentified { get; set; }
        public String If_yes_list_barriers_identifieed { get; set; }
        public String Step_taken_to_Address_beriers { get; set; }
        public String Duration { get; set; }
        public String StaffName { get; set; }
    }
}
