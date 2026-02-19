using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using AddressBookSystem.Interface;
using AddressBookSystem.Model;

namespace AddressBookSystem.Service
{
    internal class JsonStorageService : IAddressBookStorage
    {
        public void Save(string filePath, List<Contact> contacts)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(filePath, json);
        }

        public List<Contact> Load(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("JSON file not found.");

            string json = File.ReadAllText(filePath);

            var contacts = JsonSerializer.Deserialize<List<Contact>>(json);

            return contacts ?? new List<Contact>();
        }
    }
}
