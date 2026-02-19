using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookSystem
{
    internal class CsvStorageService : IAddressBookStorage
    {
        public void Save(string filePath, List<Contact> contacts)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Header
                writer.WriteLine("FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email");

                foreach (var contact in contacts)
                {
                    writer.WriteLine(
                        $"{contact.FirstName}," +
                        $"{contact.LastName}," +
                        $"{contact.Address}," +
                        $"{contact.City}," +
                        $"{contact.State}," +
                        $"{contact.Zip}," +
                        $"{contact.PhoneNumber}," +
                        $"{contact.Email}"
                    );
                }
            }
        }

        public List<Contact> Load(string filePath)
        {
            List<Contact> contacts = new List<Contact>();

            if (!File.Exists(filePath))
                throw new FileNotFoundException("CSV file not found.");

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] parts = line.Split(',');

                    if (parts.Length == 8)
                    {
                        contacts.Add(new Contact(
                            parts[0],
                            parts[1],
                            parts[2],
                            parts[3],
                            parts[4],
                            parts[5],
                            parts[6],
                            parts[7]
                        ));
                    }
                }
            }

            return contacts;
        }
    }
}
