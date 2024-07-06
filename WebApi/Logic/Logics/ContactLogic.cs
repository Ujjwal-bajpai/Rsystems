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
        public async Task<Contact> GetContacts()
        {
            return await _contactRepository.GetContacts();
        }
    }
}
