using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Case_Worker
    {
        [Key]
        public int WorkerID { get; set; }
        public String DateAllocated { get; set; }
        public String DateDeallocated { get; set; }
        public String KeyWorker { get; set; }

        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
