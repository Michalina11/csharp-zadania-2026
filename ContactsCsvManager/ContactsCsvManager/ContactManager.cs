using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactsCsvManager
{
    public class ContactManager
    {
        private string path = "contacts.csv";
        public List<Contact> Contacts { get; set; }
        public ContactManager()
        {
            Contacts = LoadContacts();
        }
        public List<Contact> LoadContacts()
        {
            List<Contact> contacts = new List<Contact>();

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Id,FirstName,LastName,Email,Phone\n");
            }

            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines.Skip(1))
            {
                string[] values = line.Split(',');

                if (values.Length == 5)
                {
                    Contact contact = new Contact()
                    {
                        Id = Convert.ToInt32(values[0]),
                        FirstName = values[1],
                        LastName = values[2],
                        Email = values[3],
                        Phone = values[4]
                    };

                    contacts.Add(contact);
                }
            }

            return contacts;
        }

        public void SaveContacts()
        {
            List<string> lines = new List<string>();

            lines.Add("Id,FirstName,LastName,Email,Phone");

            foreach (Contact contact in Contacts)
            {
                string line =
                    $"{contact.Id}," +
                    $"{contact.FirstName}," +
                    $"{contact.LastName}," +
                    $"{contact.Email}," +
                    $"{contact.Phone}";

                lines.Add(line);
            }

            File.WriteAllLines(path, lines);
        }

        public void Add(Contact contact)
        {
            int newId = 1;
            if (Contacts.Count > 0)
            {
                newId = Contacts[Contacts.Count - 1].Id;
            }

            contact.Id = newId;

            Contacts.Add(contact);

            SaveContacts();
        }

        public void Delete(int id)
        {
            Contact contact = 
                Contacts.FirstOrDefault(c => c.Id == id);

            if (contact != null)
            {
                Contacts.Remove(contact);

                SaveContacts();
            }
        }

        public List<Contact> Search(string query)
        {
            return Contacts.Where(c => 
                c.LastName.Contains(query,
                    StringComparison.OrdinalIgnoreCase)
                ||
                c.Email.Contains(query,
                    StringComparison.OrdinalIgnoreCase)
                ).ToList();
        }

        public List<Contact> Sort(string field)
        {
            switch (field.ToLower())
            {
                case "firstname":
                    return Contacts
                        .OrderBy(c => c.FirstName)
                        .ToList();

                case "lastname":
                    return Contacts
                        .OrderBy(c => c.LastName)
                        .ToList();

                case "email":
                    return Contacts
                        .OrderBy(c => c.Email)
                        .ToList();

                default:
                    return Contacts;
            }
        }
    }
}
