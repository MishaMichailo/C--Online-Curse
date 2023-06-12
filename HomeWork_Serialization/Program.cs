using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;

namespace HomeWork_Serialization
{
    class Person
    {
        private string? name;
        private DateTime birthyear;

        public string? Name { get { return name; } }

        public DateTime Year { get { return birthyear; } }


        public Person() : this("Uknown", default)
        {
        }
        public Person(string name, DateTime birthyear)
        {
            this.name = name;
            this.birthyear = birthyear;
        }

        public void Age()
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthyear.Year;
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public void Input()
        {
            Console.Write("Enter the person's name: ");
            name = Console.ReadLine();

            Console.Write("Enter the person's birth year (YYYY): ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year > DateTime.Now.Year)
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                Console.Write("Enter the person's birth year (YYYY): ");
            }
            Console.WriteLine(new String('-', 40));
            birthyear = new DateTime(year, 1, 1);


        }
        public void ChangeName(string newName)
        {
            name = newName;
        }
        public override string ToString()
        {
            return $"Person: {name}, Year of birth: {birthyear.ToShortDateString()} ";
        }
        public void Output()
        {
            Console.WriteLine(this.ToString());
        }
        public static bool operator ==(Person p1, Person p2)
        {
            if (ReferenceEquals(p1, p2)) return true;
            if (ReferenceEquals(p1, null)) return false;
            if (ReferenceEquals(p2, null)) return false;
            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
        public void SerializeJson(string filePath)
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText(filePath, json);
        }

        public static Person DeserializeJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Person>(json);
        }
    }

    
    internal class Program
    {
        private static Person deserializedPerson;

        static void Main(string[] args)
        {
            Person[] people = new Person[3];

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Enter information for person {i + 1}:");
                people[i] = new Person();
                people[i].Input();
            }

            foreach (Person p in people)
            {
                p.Age();
                if ((DateTime.Now - p.Year).TotalDays < 16 * 365)
                {
                    p.ChangeName("Very Young");
                }
            }

            Console.WriteLine("\nInformation about all persons:");
            foreach (Person p in people)
            {
                Console.WriteLine("\n");
                p.Output();
            }

            Console.WriteLine("\nInformation about persons with the same names:");
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Person {i + 1} and person {j + 1} have the same name.");

                    }
                }
            }
            string jsonFilePath = "person.json";
            people[0].SerializeJson(jsonFilePath);
            deserializedPerson = Person.DeserializeJson(jsonFilePath);
            Console.WriteLine("\nDeserialized person from JSON:");
            deserializedPerson.Output();
        }
    }
}