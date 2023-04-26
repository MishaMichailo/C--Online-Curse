internal class Program
{
    enum Error
    {
        Bad_Request=400,
        Unauthorized=401,
        Payment_Required=402,
        Forbidden=403,
        Not_Found=404,
        Method_Not_Allowed=405
    }
    struct Dog
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public int age { get; set; }



        public override string ToString()
        {
            return $"[{Name}] - {Mark} - {age}";
        }
    }
    private static void Main(string[] args)
    {

        ////--------Task 1
        Console.WriteLine("Enter number in range [-5....5]:  ");
        float num = float.Parse(Console.ReadLine());

        if(num >= -5 && num <= 5)
        {
            Console.WriteLine("Your number is in range [-5....5]");
        }
        else
        {
            Console.WriteLine("Your nimber is out of this range  [-5....5]");
        }



        //////-----Task 2

        int max = int.MinValue;
        int min = int.MaxValue;
        Console.WriteLine("Enter 3 number: ");

        for (int i = 1; i <=3 ; i++)
        {
            Console.WriteLine($"Enter number {i}");
            int number = int.Parse(Console.ReadLine());

            if(number > max )

            {
                max = number;
            }
            if( number < min )
            {
                min = number;
            }
        }

        Console.WriteLine("Max value: " + max);
        Console.WriteLine("Min value: " + min);



        //-------Task 3 
        Console.WriteLine("Enter number of HTTP Error (400,401,402,403,404,405): ");
        int? err = int.Parse(Console.ReadLine());
                switch (err)
                {
                    case (int?)Error.Bad_Request:
                        Console.WriteLine(Error.Bad_Request);
                        break;
                    case (int?)Error.Unauthorized:
                        Console.WriteLine(Error.Unauthorized);
                        break;
                    case (int?)Error.Payment_Required:
                        Console.WriteLine(Error.Payment_Required);
                        break;
                    case (int?)Error.Forbidden:
                        Console.WriteLine(Error.Forbidden);
                        break;
                    case (int?)Error.Not_Found:
                        Console.WriteLine(Error.Not_Found);
                        break;
                    case (int?)Error.Method_Not_Allowed:
                        Console.WriteLine(Error.Method_Not_Allowed);
                        break;
                }


        //--------Task 4 

        Dog myDog = new Dog()
        {
            Name = "Jaycee",
            Mark = "York",
            age = 2
            
        };
        Console.WriteLine($"My dog name is {myDog.Name}");
        Console.WriteLine($"His breed is {myDog.Mark}");
        Console.WriteLine($"He is {myDog.age} year");



    }
}