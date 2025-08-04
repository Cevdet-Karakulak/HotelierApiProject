using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebApi.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebApi.Controllers
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
        [HttpPost]
        public IActionResult AddContact([FromBody] CreateContactDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var contact = new Contact
            {
                Name = dto.Name,
                Mail = dto.Mail,
                Subject = dto.Subject,
                Message = dto.Message,
                MessageCategoryID = dto.MessageCategoryID,
                Date = DateTime.Now
            };

            _contactService.TInsert(contact);
            return Ok();
        }
        [HttpGet]
        public IActionResult InboxListContact()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetSendMessage(int id)
        {
            var values = _contactService.TGetById(id);
            return Ok(values);
        }
        [HttpGet("GetContactCount")]
        public IActionResult GetContactCount()
        {
            return Ok(_contactService.TGetContactCount());
        }
    }
}
