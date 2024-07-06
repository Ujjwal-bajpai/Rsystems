using Microsoft.AspNetCore.Mvc;
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
        [Route("GetAllCustomers")]
        public async Task<IActionResult> GetContacts()
        {
           return Ok(await _contactService.GetContacts());
        }
    }
}
