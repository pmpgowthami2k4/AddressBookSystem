using System.Collections.Generic;
using AddressBookSystem.Model;

namespace AddressBookSystem.Interface
{
    internal interface IAddressBookStorage
    {
        void Save(string filePath, List<Contact> contacts);
        List<Contact> Load(string filePath);
    }
}
