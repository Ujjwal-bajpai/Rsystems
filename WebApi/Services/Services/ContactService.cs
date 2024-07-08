using Logic.ILogics;
using Models;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactLogic _contactLogic;

        public ContactService(IContactLogic contactLogic)
        {
            _contactLogic = contactLogic;
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            return await _contactLogic.AddContact(contact);
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _contactLogic.GetContacts();
        }

        public Task<bool> RemoveContact(int id)
        {
            return _contactLogic.RemoveContact(id);
        }

        public Task<Contact> UpdateContact(Contact contact)
        {
            return _contactLogic.UpdateContact(contact);
        }
    }
}
