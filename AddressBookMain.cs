using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Dictionary<string, AddressBook> addressBooks =
                new Dictionary<string, AddressBook>(StringComparer.OrdinalIgnoreCase);

            while (true)
            {
                Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
                Console.WriteLine("1. Create New Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Search by City or State");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter Address Book Name: ");
                        string name = Console.ReadLine();

                        if (!addressBooks.ContainsKey(name))
                        {
                            addressBooks[name] = new AddressBook();
                            Console.WriteLine("Address Book created successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Address Book already exists.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter Address Book Name: ");
                        string selectedName = Console.ReadLine();

                        if (addressBooks.ContainsKey(selectedName))
                        {
                            ManageAddressBook(addressBooks[selectedName]);
                        }
                        else
                        {
                            Console.WriteLine("Address Book not found.");
                        }
                        break;

                    case "3":
                        SearchContacts(addressBooks);
                        break;

                    case "4":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void ManageAddressBook(AddressBook addressBook)
        {
            while (true)
            {
                Console.WriteLine("\n===== CONTACT MENU =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Display All Contacts");
                Console.WriteLine("5. View Contacts by City");
                Console.WriteLine("6. View Contacts by State");
                Console.WriteLine("7. Count Contacts by City");
                Console.WriteLine("8. Count Contacts by State");
                Console.WriteLine("9. Sort Contacts by Name");
                Console.WriteLine("10. Sort Contacts by City");
                Console.WriteLine("11. Sort Contacts by State");
                Console.WriteLine("12. Sort Contacts by Zip");
                Console.WriteLine("13. Back");
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
                        Console.Write("Enter city: ");
                        addressBook.ViewByCity(Console.ReadLine());
                        break;

                    case "6":
                        Console.Write("Enter state: ");
                        addressBook.ViewByState(Console.ReadLine());
                        break;

                    case "7":
                        Console.Write("Enter city: ");
                        addressBook.CountByCity(Console.ReadLine());
                        break;

                    case "8":
                        Console.Write("Enter state: ");
                        addressBook.CountByState(Console.ReadLine());
                        break;

                    case "9":
                        addressBook.SortByName();
                        break;

                    case "10":
                        addressBook.SortByCity();
                        break;

                    case "11":
                        addressBook.SortByState();
                        break;

                    case "12":
                        addressBook.SortByZip();
                        break;

                    case "13":
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

        private static void SearchContacts(Dictionary<string, AddressBook> addressBooks)
        {
            Console.Write("Search by (city/state): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter value: ");
            string value = Console.ReadLine();

            bool found = false;

            foreach (var book in addressBooks)
            {
                foreach (var contact in book.Value.GetContacts())
                {
                    if ((type == "city" && contact.City.Equals(value, StringComparison.OrdinalIgnoreCase)) ||
                        (type == "state" && contact.State.Equals(value, StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine($"\nAddress Book: {book.Key}");
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No matching contacts found.");
            }
        }
    }
}
