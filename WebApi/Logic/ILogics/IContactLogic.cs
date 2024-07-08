using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogics
{
    public interface IContactLogic
    {
        Task<List<Contact>> GetContacts();

        Task<Contact> AddContact(Contact contact);
        Task<Contact> UpdateContact(Contact contact);

        Task<bool> RemoveContact(int id);
    }
}
