using System.Collections.Generic;

namespace AddressBookSystem
{
    internal interface IAddressBookStorage
    {
        void Save(string filePath, List<Contact> contacts);
        List<Contact> Load(string filePath);
    }
}
