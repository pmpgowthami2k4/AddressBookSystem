using System;

namespace AddressBookSystem
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            Contact contact = new Contact(
                "Gowthami",
                "Payasam",
                "123 Main Street",
                "Hyderabad",
                "Telangana",
                "500001",
                "9876543210",
                "gowthami@email.com"
            );

            Console.WriteLine("\nContact Created Successfully:\n");
            Console.WriteLine(contact);
        }
    }
}
