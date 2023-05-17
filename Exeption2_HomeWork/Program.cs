namespace Exeption2_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start: ");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter end: ");
            int end = int.Parse(Console.ReadLine());

            int[] number = new int[10];

            for (int i = 0; i < number.Length;i++)
            {
                try
                {
                    number[i++] = ReadNumber(start, end);
                    start = number[i-1];

                }




                catch (ArgumentException ex)
                {
                    Console.WriteLine("The num should be greater than previous number entered:" + ex.Message);
                    i--;
                }


            }
            Console.WriteLine("You have entered the following numbers: ");
            Console.WriteLine(String.Join("\t", number));
        }
      private  static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            if (number < start || number > end)
            {
                throw new ArgumentException($"The number should be between {start} and {end}.");
            }
            Console.ResetColor();

            return number;
        }
    }
}


            
        

