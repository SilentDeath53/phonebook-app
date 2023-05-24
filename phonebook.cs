using System;
using System.Collections.Generic;

class PhonebookEntry
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
}

class Phonebook
{
    private List<PhonebookEntry> entries;

    public Phonebook()
    {
        entries = new List<PhonebookEntry>();
    }

    public void AddEntry(string name, string phoneNumber)
    {
        var entry = new PhonebookEntry
        {
            Name = name,
            PhoneNumber = phoneNumber
        };

        entries.Add(entry);
        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Phonebook is empty.");
            return;
        }

        Console.WriteLine("Phonebook Entries:");
        foreach (var entry in entries)
        {
            Console.WriteLine($"Name: {entry.Name}, Phone Number: {entry.PhoneNumber}");
        }
    }
}

class Program
{
    static void Main()
    {
        Phonebook phonebook = new Phonebook();

        while (true)
        {
            Console.WriteLine("\nPhonebook Menu:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Phone Number: ");
                    string phoneNumber = Console.ReadLine();
                    phonebook.AddEntry(name, phoneNumber);
                    break;
                case "2":
                    phonebook.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
