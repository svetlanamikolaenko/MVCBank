using System;
using System.Data.Entity;
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
        private ApplicationDbContext _context;

        public ManagersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            if (User.IsInRole("CanManageUsers"))
                return View("List");

            return View("ReadOnlyList");
        }


        [Authorize(Roles = "CanManageUsers")]
        public ActionResult Create()
        {
            var role = _context.Role.ToList();
            var viewModel = new ManagerFormViewModel
            {   
                Manager = new Manager(),
                Role = role
            };
            return View("ManagerForm", viewModel);
        }

        [Authorize(Roles = "CanManageUsers")]
        public ActionResult Edit(int id)
        {
            var manager = _context.Manager.SingleOrDefault(c => c.Id == id);
            if (manager == null)
                return HttpNotFound();

            var viewModel = new ManagerFormViewModel
            {
                Manager = manager,
                Role = _context.Role.ToList()
            };
            return View("ManagerForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CanManageUsers")]
        public ActionResult Save(Manager manager)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new ManagerFormViewModel()
                {
                    Manager = manager,
                    Role = _context.Role.ToList()
                };

                return View("ManagerForm", viewModel);
            }

            if (manager.Id == 0)
            {
                _context.Manager.Add(manager);
            }
            else
            {
                var managerInDb = _context.Manager.Single(c => c.Id == manager.Id);
                managerInDb.FirstName = manager.FirstName;
                managerInDb.LastName = manager.LastName;
                managerInDb.RoleId = manager.RoleId;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Managers");
        }

        
        /*
        private IEnumerable<Manager> GetManagers()
        {
            return new List<Manager>
            {
                new Manager { Id = 1, Name = "Neo" },
                new Manager { Id = 2, Name = "Triniti" }
            };
        }
        */
    }
}