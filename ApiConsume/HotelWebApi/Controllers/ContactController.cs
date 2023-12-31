﻿using Hotel.BussinesLayer.Abstract;
using Hotel.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetList();

            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddContact(Contact Contact)
        {
            Contact.Date=Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(Contact);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var values = _contactService.TGetById(id);
            _contactService.TDelete(values);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateContact(Contact Contact)
        {
            _contactService.TUpdate(Contact);

            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }

      
    }
}

