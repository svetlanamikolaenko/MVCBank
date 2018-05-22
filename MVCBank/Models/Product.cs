using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBank.Models
{
    public class Product : Base
    {
        public string Name { get; set; }
        public int Procent { get; set; }
        public int Period { get; set; }
    }
}