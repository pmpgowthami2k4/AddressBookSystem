using System;

namespace AddressBookSystem.Exceptions
{
    internal class AddressBookEmptyException : Exception
    {
        public AddressBookEmptyException(string message)
            : base(message)
        {
        }
    }
}

