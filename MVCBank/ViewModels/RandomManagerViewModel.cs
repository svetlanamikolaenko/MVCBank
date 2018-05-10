using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCBank.Models;

namespace MVCBank.ViewModels
{
    public class RandomManagerViewModel
    {
        public Manager Manager { get; set; }
        public List<Client> Clients { get; set; }
    }

    public class ManagerViewModel
    {
        public List<Manager> Manager { get; set; }
    }
}