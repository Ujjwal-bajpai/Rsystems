using Models;
using Repositories.DbHelper;
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
        public async Task<Contact> AddContact(Contact contact)
        {
            var dbHelper = new DbHelperJson();
            dbHelper.AddEntry(contact);
            return contact;
        }

        public async Task<List<Contact>> GetContacts()
        {
            var dbHelper = new DbHelperJson();
            return dbHelper.GetAllEntries();
        }

        public async Task<bool> RemoveContact(int id)
        {
            var dbHelper = new DbHelperJson();
            dbHelper.DeleteEntry(id);
            return true;
        }

        public async Task<Contact> UpdateContact(Contact contact)
        {
            var dbHelper = new DbHelperJson();
            dbHelper.UpdateEntry(contact);
            return contact;
        }
    }
}
