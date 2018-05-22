using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBank.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCBank.Dtos
{
    public class ManagerDto : Base
    {
        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public int RoleId { get; set; }

        public RoleDto Role { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}