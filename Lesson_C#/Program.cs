internal class Program
{
    private static void Main(string[] args)
    {
        // Task 1
        Console.WriteLine("Enter  side a: ");
        float a = float.Parse(Console.ReadLine());
        while (a <=0)
        {
            Console.WriteLine("Enter value >0 :  ");
            a = float.Parse(Console.ReadLine());
        }
        Console.WriteLine("Area square is " + a*a);
        Console.WriteLine("Perimeter " + 4*a);


        //Task 2
        int num;
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        while( name == "" ||  int.TryParse(name, out num))
        {
            Console.WriteLine("You don`t enter your name,please enter again");
            name = Console.ReadLine();
        }
        Console.WriteLine($"How old are you,{name}?");
        int age;
        string? line = Console.ReadLine();
        
        while (!int.TryParse(line,out age) || age <= 0) 
        {
           
            Console.WriteLine("You don`t enter your age,please enter again");
            line = Console.ReadLine();

        }
        Console.WriteLine($"Your name is  {name}, you are  {age} year old");

        //Task 3
        double radius;
        double pi = 3.14;
        Console.WriteLine("Enter radius");
        string? p_i = Console.ReadLine();
        while (!double.TryParse(p_i,out radius) || radius <= 0)
        {
            Console.WriteLine("Enter radius");
             p_i = Console.ReadLine();
        }
        Console.WriteLine("length is: " + 2 * pi * radius);
        Console.WriteLine("area is : " + pi * (int)Math.Pow(radius, 2));
        Console.WriteLine("volume is : " + 4/3 * pi * (int)Math.Pow(radius, 3));
     

    }
}