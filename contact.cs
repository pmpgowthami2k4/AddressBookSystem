using System;

namespace AddressBookSystem
{
    internal class Contact
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
        public string PhoneNumber { get; }
        public string Email { get; }

        public Contact(string firstName,
                       string lastName,
                       string address,
                       string city,
                       string state,
                       string zip,
                       string phoneNumber,
                       string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}\n" +
                   $"Address: {Address}\n" +
                   $"City: {City}\n" +
                   $"State: {State}\n" +
                   $"Zip: {Zip}\n" +
                   $"Phone: {PhoneNumber}\n" +
                   $"Email: {Email}";
        }
    }
}

