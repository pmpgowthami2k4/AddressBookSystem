using System;
using System.Collections.Generic;
using System.Linq;


namespace AddressBookSystem
{
    internal class AddressBook
    {
        private List<Contact> contacts;
        private Dictionary<string, List<Contact>> cityDictionary;
        private Dictionary<string, List<Contact>> stateDictionary;


        public AddressBook()
        {
            contacts = new List<Contact>();
            cityDictionary = new Dictionary<string, List<Contact>>(StringComparer.OrdinalIgnoreCase);
            stateDictionary = new Dictionary<string, List<Contact>>(StringComparer.OrdinalIgnoreCase);
        }


        public void AddContact(Contact contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact found. Contact not added.");
                return;
            }

            contacts.Add(contact);

            // Update City Dictionary
            if (!cityDictionary.ContainsKey(contact.City))
                cityDictionary[contact.City] = new List<Contact>();

            cityDictionary[contact.City].Add(contact);

            // Update State Dictionary
            if (!stateDictionary.ContainsKey(contact.State))
                stateDictionary[contact.State] = new List<Contact>();

            stateDictionary[contact.State].Add(contact);

            Console.WriteLine("Contact added successfully.");
        }



        public void DisplayAllContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }

            foreach (Contact contact in contacts)
            {
                Console.WriteLine("\n----------------------");
                Console.WriteLine(contact);
            }
        }

        public void EditContact(string firstName)
        {
            Contact contact = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.WriteLine("Enter new details:");

            Console.Write("Address: ");
            contact.UpdateAddress(Console.ReadLine());

            Console.Write("City: ");
            contact.UpdateCity(Console.ReadLine());

            Console.Write("State: ");
            contact.UpdateState(Console.ReadLine());

            Console.Write("Zip: ");
            contact.UpdateZip(Console.ReadLine());

            Console.Write("Phone Number: ");
            contact.UpdatePhone(Console.ReadLine());

            Console.Write("Email: ");
            contact.UpdateEmail(Console.ReadLine());

            Console.WriteLine("Contact updated successfully.");
        }

        public void DeleteContact(string firstName)
        {
            Contact contact = contacts.Find(c =>
                c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            contacts.Remove(contact);
            Console.WriteLine("Contact deleted successfully.");
        }

        public List<Contact> GetContacts()
        {
            return contacts;
        }
        public void ViewByCity(string city)
        {
            if (cityDictionary.ContainsKey(city))
            {
                foreach (var contact in cityDictionary[city])
                    Console.WriteLine(contact);
            }
            else
            {
                Console.WriteLine("No contacts found in this city.");
            }
        }

        public void ViewByState(string state)
        {
            if (stateDictionary.ContainsKey(state))
            {
                foreach (var contact in stateDictionary[state])
                    Console.WriteLine(contact);
            }
            else
            {
                Console.WriteLine("No contacts found in this state.");
            }
        }

        public void CountByCity(string city)
        {
            if (cityDictionary.ContainsKey(city))
            {
                Console.WriteLine($"Number of contacts in {city}: {cityDictionary[city].Count}");
            }
            else
            {
                Console.WriteLine("No contacts found in this city.");
            }
        }

        public void CountByState(string state)
        {
            if (stateDictionary.ContainsKey(state))
            {
                Console.WriteLine($"Number of contacts in {state}: {stateDictionary[state].Count}");
            }
            else
            {
                Console.WriteLine("No contacts found in this state.");
            }
        }

        public void SortByName()
        {
            if (contacts.Count == 0)
                throw new AddressBookEmptyException("Cannot sort. Address Book is empty.");

            contacts.Sort();

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public void SortByCity()
        {
            if (contacts.Count == 0)
                throw new AddressBookEmptyException("Cannot sort. Address Book is empty.");

            var sorted = contacts.OrderBy(c => c.City);

            foreach (var contact in sorted)
                Console.WriteLine(contact);
        }

        public void SortByState()
        {
            if (contacts.Count == 0)
                throw new AddressBookEmptyException("Cannot sort. Address Book is empty.");

            var sorted = contacts.OrderBy(c => c.State);

            foreach (var contact in sorted)
                Console.WriteLine(contact);
        }

        public void SortByZip()
        {
            if (contacts.Count == 0)
                throw new AddressBookEmptyException("Cannot sort. Address Book is empty.");

            var sorted = contacts.OrderBy(c => c.Zip);

            foreach (var contact in sorted)
                Console.WriteLine(contact);
        }






    }
}
