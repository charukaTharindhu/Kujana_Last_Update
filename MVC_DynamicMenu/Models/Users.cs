using FSharp.Data.Runtime.StructuralTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_DynamicMenu.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public int RoleId { get; set; }
        public Roles Roles { get; set; }
    }
}
