using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace Repositories.DbHelper
{
    public class DbHelperJson
    {
        private readonly string _filePath;
        private List<Contact> _entries;
        private int _nextId;

        public DbHelperJson()
        {
            _filePath = "E:\\Rsystems\\WebApi\\Repositories\\DbHelper\\DbHelper.json";
            LoadEntries();
        }

        private void LoadEntries()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                _entries = JsonConvert.DeserializeObject<List<Contact>>(json) ?? new List<Contact>();
                _nextId = _entries.Count > 0 ? _entries[^1].Id + 1 : 1;
            }
            else
            {
                _entries = new List<Contact>();
                _nextId = 1;
            }
        }

        private void SaveEntries()
        {
            var json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }

        public List<Contact> GetAllEntries()
        {
            return new List<Contact>(_entries);
        }

        public Contact GetEntryById(int id)
        {
            return _entries.Find(e => e.Id == id);
        }

        public Contact AddEntry(Contact contact)
        {
            var newEntry = new Contact
            { 
                Id = _nextId++, 
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.Email,

            };
            _entries.Add(newEntry);
            SaveEntries();
            return newEntry;
        }

        public bool UpdateEntry(Contact contact)
        {
            var entry = GetEntryById(contact.Id);
            if (entry == null)
            {
                return false;
            }
            entry.FirstName = contact.FirstName;
            entry.LastName = contact.LastName;
            entry.Email = contact.Email;
            SaveEntries();
            return true;
        }

        public bool DeleteEntry(int id)
        {
            var entry = GetEntryById(id);
            if (entry == null)
            {
                return false;
            }
            _entries.Remove(entry);
            SaveEntries();
            return true;
        }

    }
}
