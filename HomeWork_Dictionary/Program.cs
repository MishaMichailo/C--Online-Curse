using System;
using System.Collections.Generic;
namespace HomeWork_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> personDictionary = new Dictionary<uint, string>();

            
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Enter ID: ");
                uint id = Convert.ToUInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                personDictionary.Add(id, name);
            }

            
            Console.Write("Enter ID to find corresponding Name: ");
            uint searchId = Convert.ToUInt32(Console.ReadLine());

            
            if (personDictionary.ContainsKey(searchId))
            {
                string name = personDictionary[searchId];
                Console.WriteLine($"Name: {name}");
            }
            else
            {
                Console.WriteLine("ID not found.");
            }

            Console.ReadKey();
        }
    }
}