using Microsoft.AspNetCore.Mvc;
using Models;
using Services.IServices;

namespace ContactsManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactsController: ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        [Route("GetAllContacts")]
        public async Task<IActionResult> GetContacts()
        {
           return Ok(await _contactService.GetContacts());
        }

        [HttpPost]
        [Route("AddContact")]
        public async Task<IActionResult> AddContact([FromBody] Contact contact)
        {
            return Ok(await _contactService.AddContact(contact));
        }
        [HttpPut]
        [Route("UpdateContact")]
        public async Task<IActionResult> UpdateContact([FromBody] Contact contact)
        {
            return Ok(await _contactService.UpdateContact(contact));
        }
        [HttpDelete]
        [Route("RemoveContact")]
        public async Task<IActionResult> RemoveContact([FromQuery] int id)
        {
            return Ok(await _contactService.RemoveContact(id));
        }
    }
}
