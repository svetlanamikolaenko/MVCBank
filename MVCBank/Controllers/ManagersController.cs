using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBank.Models;
using MVCBank.ViewModels;


namespace MVCBank.Controllers
{
    public class ManagersController : Controller
    {
        // GET: Managers/Random
        public ActionResult Random()
        {
            var manager = new Manager() { Name = "Shrek!" };
            var clients = new List<Client>
            {
                new Client {Name = "Client 1"},
                new Client {Name = "Client 2"}
            };

            var viewModel = new RandomManagerViewModel
            {
                Manager = manager,
                Clients = clients
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //managers
        /*
        public ActionResult Index()
        {
            var manager = new List<Manager>
            {
                new Manager{Name = "Man 1"},
                new Manager{Name = "Man 2"}
            };

            var viewModel = new ManagerViewModel
            {
                Manager = manager
            };
            return View(viewModel);
            }
            */
        /*
        if (!pageIndex.HasValue)
            pageIndex = 1;

        if (String.IsNullOrWhiteSpace(sortBy))
            sortBy = "Name";
        return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        */


        public ViewResult Index()
        {
            var managers = GetManagers();

            return View(managers);
        }

        public ActionResult Details(int id)
        {
            var manager = GetManagers().SingleOrDefault(c => c.Id == id);
            if (manager == null)
                return HttpNotFound();
            return View(manager);
        }

        private IEnumerable<Manager> GetManagers()
        {
            return new List<Manager>
            {
                new Manager { Id = 1, Name = "Neo" },
                new Manager { Id = 2, Name = "Triniti" }
            };
        }
    }
}