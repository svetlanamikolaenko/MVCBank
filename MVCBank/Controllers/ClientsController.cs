using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBank.Models;

namespace MVCBank.Controllers
{
    public class ClientsController : Controller
    {
        // GET: Clients
        public ViewResult Index()
        {
            var clients = GetClients();

            return View(clients);
        }

        public ActionResult Details(int id)
        {
            var client = GetClients().SingleOrDefault(c => c.Id == id);
            if (client == null)
                return HttpNotFound();
            return View(client);
        }

        private IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client { Id = 1, Name = "Client 1"},
                new Client { Id = 2, Name = "Client 2"}
            };
        }
    }
}