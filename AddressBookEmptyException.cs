using System;

namespace AddressBookSystem
{
    internal class AddressBookEmptyException : Exception
    {
        public AddressBookEmptyException(string message)
            : base(message)
        {
        }
    }
}

