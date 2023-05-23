namespace HomeWork_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            // Read the phone book data from file
            string[] lines = File.ReadAllLines("phones.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(':');
                if (parts.Length == 2)
                {
                    string name = parts[0].Trim();
                    string phoneNumber = parts[1].Trim();
                    phoneBook[name] = phoneNumber;
                }
            }

            // Write phone numbers to "Phones.txt" file
            using (StreamWriter writer = new StreamWriter("Phones.txt"))
            {
                foreach (string phoneNumber in phoneBook.Values)
                {
                    writer.WriteLine(phoneNumber);
                }
            }

            // Find and print phone number by name
            Console.Write("Enter a name to search for: ");
            string searchName = Console.ReadLine();
            if (phoneBook.ContainsKey(searchName))
            {
                string phoneNumber = phoneBook[searchName];
                Console.WriteLine("Phone number for {0}: {1}", searchName, phoneNumber);
            }
            else
            {
                Console.WriteLine("Phone number not found for {0}", searchName);
            }

            // Change phone numbers in the specified format and write to "New.txt" file
            using (StreamWriter writer = new StreamWriter("New.txt"))
            {
                foreach (KeyValuePair<string, string> entry in phoneBook)
                {
                    string name = entry.Key;
                    string phoneNumber = entry.Value;

                    if (phoneNumber.StartsWith("80") && phoneNumber.Length == 11)
                    {
                        phoneNumber = "+380" + phoneNumber.Substring(2);
                    }

                    writer.WriteLine("{0}: {1}", name, phoneNumber);
                }
            }
        }
    }
    
}