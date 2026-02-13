using System;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook addressBook = new AddressBook();

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContactFlow(addressBook);
                        break;

                    case "2":
                        Console.Write("Enter first name to edit: ");
                        addressBook.EditContact(Console.ReadLine());
                        break;

                    case "3":
                        Console.Write("Enter first name to delete: ");
                        addressBook.DeleteContact(Console.ReadLine());
                        break;

                    case "4":
                        addressBook.DisplayAllContacts();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void AddContactFlow(AddressBook addressBook)
        {
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
        }


    }
}
