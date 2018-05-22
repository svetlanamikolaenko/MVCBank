using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBank.Models
{
    public class Client: Base
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public Manager Manager { get; set; }
        public int ManagerId { get; set; }
    }
}