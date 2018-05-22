using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using MVCBank.Dtos;
using MVCBank.Models;
using System.Data.Entity;

namespace MVCBank.Controllers.Api
{
    public class ManagersController : ApiController
    {
        private ApplicationDbContext _context;

        public ManagersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/managers
        public IHttpActionResult GetManagers()
        {
            var managerDtos = _context.Manager
                .Include(c => c.Role)
                .ToList()
                .Select(Mapper.Map<Manager, ManagerDto>);

            return Ok(managerDtos);
        }

        // GET /api/managers/1
        public IHttpActionResult GetManager(int id)
        {
            var manager = _context.Manager.SingleOrDefault(c => c.Id == id);

            if (manager == null)
                return NotFound();

            return Ok(Mapper.Map<Manager, ManagerDto>(manager));
        }

        // POST /api/managers
        [HttpPost]
        public IHttpActionResult CreateManager(ManagerDto managerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var manager = Mapper.Map<ManagerDto, Manager>(managerDto);
            _context.Manager.Add(manager);
            _context.SaveChanges();

            managerDto.Id = manager.Id;
            return Created(new Uri(Request.RequestUri + "/" + manager.Id), managerDto);
        }

        // PUT /api/managers/1
        [HttpPut]
        public IHttpActionResult UpdateManager(int id, ManagerDto managerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var managerInDb = _context.Manager.SingleOrDefault(c => c.Id == id);

            if (managerInDb == null)
                return NotFound();

            Mapper.Map(managerDto, managerInDb);

            _context.SaveChanges();
            return Ok();
        }

        // DELETE /api/managers/1
        [HttpDelete]
        public IHttpActionResult DeleteManager(int id)
        {
            var managerInDb = _context.Manager.SingleOrDefault(c => c.Id == id);

            if (managerInDb == null)
                return NotFound();

            _context.Manager.Remove(managerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
