using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Files
    {
        [Key]
        public int FilesID { get; set; }


        public int PatientID { get; set; }
        public Patient Patient { get; set; }
    }
}
