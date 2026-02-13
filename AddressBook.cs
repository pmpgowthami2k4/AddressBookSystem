using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private List<Contact> contacts;

        public AddressBook()
        {
            contacts = new List<Contact>();
        }

        public void AddContact(Contact contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact found. Contact not added.");
                return;
            }

            contacts.Add(contact);
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


    }
}
