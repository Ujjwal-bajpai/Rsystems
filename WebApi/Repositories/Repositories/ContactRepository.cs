using Models;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class ContactRepository : IContactRepository
    {
        public async Task<Contact> GetContacts()
        {
            return new Contact
            {
                Id = 1,
                Email = "testEmail",
                FirstName = "fname",
                LastName = "lname",


            };
        }
    }
}
