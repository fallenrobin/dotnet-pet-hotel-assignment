using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using pet_hotel.Models;
using Microsoft.EntityFrameworkCore;

namespace pet_hotel.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetOwnersController : ControllerBase
    {
        private readonly ApplicationContext _context;
        public PetOwnersController(ApplicationContext context)
        {
            _context = context;
        }

        // This is just a stub for GET / to prevent any weird frontend errors that 
        // occur when the route is missing in this controller

        //get all action
        [HttpGet]
        public IEnumerable<PetOwner> GetOwners()
        {
            return _context.PetOwners;
        }

        //get by ID action
        [HttpGet("{id}")]
        public ActionResult<PetOwner> GetById(int id)
        {
            PetOwner petOwner = _context.PetOwners
            .SingleOrDefault(petOwner => petOwner.id == id);
            if (petOwner == null)
            {
                return NotFound();
            }
            return petOwner;
        }
        //post action
        [HttpPost]
        public PetOwner Create(PetOwner petOwner)
        {
            _context.Add(petOwner);
            _context.SaveChanges();
            return petOwner;

        }
        // put action
        [HttpPut("{id}")]
        public PetOwner Update(int id, PetOwner petOwner)
        {
            petOwner.id = id;
            _context.Update(petOwner);
            _context.SaveChanges();
            return petOwner;
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            PetOwner petOwner = _context.PetOwners.Find(id);
            _context.PetOwners.Remove(petOwner);
            _context.SaveChanges();
        }
    }
}
