using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class NewMentalHealthReview
    {
        [Key]

        public int ClientID { get; set; }
        public String Client_Name { get; set; }
        public String Entry_date { get; set; }
        public String Hierarchy { get; set; }
        public String Client_status { get; set; }
        public String Question_1 { get; set; }
        public String Question_2 { get; set; }
        public String Question_3 { get; set; }
        public String Question_4 { get; set; }
        public String Question_5 { get; set; }
        public String Summery { get; set; }
    }
}
