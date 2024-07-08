using Logic.ILogics;
using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logics
{
    public class ContactLogic : IContactLogic
    {
        private readonly IContactRepository _contactRepository;
        public ContactLogic(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<Contact> AddContact(Contact contact)
        {
            return await _contactRepository.AddContact(contact);
        }

        public async Task<List<Contact>> GetContacts()
        {
            return await _contactRepository.GetContacts();
        }

        public Task<bool> RemoveContact(int id)
        {
            return _contactRepository.RemoveContact(id);
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
           return await _contactRepository.UpdateContact(contact);
        }
    }
}
