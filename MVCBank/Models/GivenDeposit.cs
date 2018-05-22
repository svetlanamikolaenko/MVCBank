using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBank.Models
{
    public class GivenDeposit : Base
    {
        public Deposit Deposit { get; set; }
        public Client Client { get; set; }
        public Manager Manager { get; set; }
        public double Amount { get; set; }
    }
}