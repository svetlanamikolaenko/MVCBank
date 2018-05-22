using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBank.Models
{
    public class Role : Base
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}