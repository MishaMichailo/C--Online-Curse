using System;
using System.Collections.Generic;
using static Interface_HomeWork.IDeveloper;

namespace Interface_HomeWork
{

    interface IDeveloper: IComparable <IDeveloper>
    {
        public string Tool { get; set; }

        void Create();
        void Destroy();


        class Programmer:IDeveloper
        {
           public  string? language { get;set; }
            public string? Tool { get; set; }
            public void Create()
            {
                Console.WriteLine($"Create code in {language} using {Tool}");
            }
            public void Destroy()
            {
                Console.WriteLine($"Destroy code {language} using {Tool}");
            }
            public int CompareTo(IDeveloper other)
            {
                if (other == null) return 1;
                return this.language.CompareTo(((Programmer)other).language);
            }
        }

        class Builder : IDeveloper
        {
            public string? Tool { get ; set ; }
            public string? Material { get; set; }

            public void Create()
            {
                Console.WriteLine($"Building {Material} using {Tool}");
            }
            public void Destroy()
            {
                Console.WriteLine($"Destroying {Material} using {Tool}");
            }
            public int CompareTo(IDeveloper other)
            {
                if (other == null) return 1;
                return this.Material.CompareTo(((Builder)other).Material);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer { Tool = "Visual Studio", language = "C#" });
            developers.Add(new Programmer { Tool = "Sublime Text", language = "Python" });
            developers.Add(new Builder { Tool = "Hammer", Material = "Wood" });
            developers.Add(new Builder { Tool = "Crane", Material = "Steel" });

            foreach (var dev in developers)
            {
                dev.Create();
            }

            developers.Sort();

            foreach (var dev in developers)
            {
                dev.Destroy();
            }

            Console.ReadLine();
        }
    }
}