using System;

namespace AddressBookSystem
{

    internal class Contact : IComparable<Contact>

    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Zip { get; private set; }
        public string PhoneNumber { get; private set; }
        public string Email { get; private set; }
        public void UpdateAddress(string address) => Address = address;
        public void UpdateCity(string city) => City = city;
        public void UpdateState(string state) => State = state;
        public void UpdateZip(string zip) => Zip = zip;
        public void UpdatePhone(string phone) => PhoneNumber = phone;
        public void UpdateEmail(string email) => Email = email;



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
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Contact other = (Contact)obj;

            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                FirstName.ToLower(),
                LastName.ToLower()
            );
        }
        public int CompareTo(Contact other)
        {
            if (other == null)
                return 1;

            int firstNameComparison = FirstName.CompareTo(other.FirstName);

            if (firstNameComparison != 0)
                return firstNameComparison;

            return LastName.CompareTo(other.LastName);
        }


    }
}

