using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tel_Book.Services
{
    public class ContactsService
    {
        public Dictionary<string, List<string>> Contacts = new Dictionary<string, List<string>>();

        public string EnterDataName() // Перенести в "Програмс"
        {
            string ContactName = Console.ReadLine();
            return ContactName;
        }

        public List<string> EnterDataNumbers() // Перенести в "Програмс"
        {
            Console.Write("Кількість номерів: ");
            uint nNumbers = uint.Parse(Console.ReadLine());

            var ContactNumbers = new List<string>();
            for (int i = 0; i < nNumbers; i++)
            {
                Console.Write("номер {0}: ", (i + 1));
                ContactNumbers.Add(Console.ReadLine());
            }
            return ContactNumbers;
        }
        public void PrintContacts()
        {
            Console.WriteLine();
            foreach (var contact in FetchContacts())
            {
                Console.WriteLine(contact.Key + " " + string.Join(", ", contact.Value.ToArray()));
            }
        }

        public void AddContact()
        {
            Console.Write("\nВведіть Ім'я: ");
            string ContactName = EnterDataName();
            List<string> ContactNumbers = EnterDataNumbers();
            Contacts[ContactName] = ContactNumbers;
        }
        public void RemoveContact()
        {
            Console.WriteLine("\nВведіть ім'я дегана");
            string ContactName = EnterDataName();
            Contacts.Remove(ContactName);
        }

        public void ContactUpdate()
        {
            RemoveContact();
            AddContact();
        }
        Dictionary<string, List<string>> FetchContacts()
        {
            return Contacts;
        }
    }
}
