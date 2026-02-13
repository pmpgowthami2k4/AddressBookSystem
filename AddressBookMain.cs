using System;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook addressBook = new AddressBook();

            Console.WriteLine("\nEnter Contact Details:");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Zip: ");
            string zip = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Contact contact = new Contact(
                firstName,
                lastName,
                address,
                city,
                state,
                zip,
                phone,
                email
            );

            addressBook.AddContact(contact);

            Console.WriteLine("\nAll Contacts:");
            addressBook.DisplayAllContacts();

            Console.Write("\nEnter first name to edit: ");
            string nameToEdit = Console.ReadLine();

            addressBook.EditContact(nameToEdit);

            Console.WriteLine("\nUpdated Contact List:");
            addressBook.DisplayAllContacts();

            Console.Write("\nEnter first name to delete: ");
            string nameToDelete = Console.ReadLine();

            addressBook.DeleteContact(nameToDelete);

            Console.WriteLine("\nUpdated Contact List:");
            addressBook.DisplayAllContacts();

        }
    }
}
