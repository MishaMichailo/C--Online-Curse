using System;

namespace Statements_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //------Task 1
            Console.WriteLine("Enter word: ");
           string? str = Console.ReadLine();

           int countA = 0, countO = 0, countI = 0, countE = 0;

            foreach (char c in str)
            {
                if (c == 'a' || c == 'A')
                {
                    countA++;
                }
                else if (c == 'o' || c == 'O')
                {
                    countO++;
                }
                else if (c == 'i' || c == 'I')
                {
                    countI++;
                }
                else if (c == 'e' || c == 'E')
                {
                    countE++;
                }
            }

            Console.WriteLine("Count of 'a': {0}", countA);
            Console.WriteLine("Count of 'o': {0}", countO);
            Console.WriteLine("Count of 'i': {0}", countI);
            Console.WriteLine("Count of 'e': {0}", countE);


            //------ Task 2
            Console.WriteLine("Enter number: ");
            int month = int.Parse(Console.ReadLine());
            int days = DateTime.DaysInMonth(DateTime.Now.Year, month);

            Console.WriteLine("Number of days in month {0}: {1}", month, days);



            //----- Task 3

            int[] numbers = new int[10];

            Console.WriteLine("Enter 10 integer numbers:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0, product = 1;

            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                }
            }

            for (int i = 5; i < 10; i++)
            {
                if (numbers[i] <= 0)
                {
                    product *= numbers[i];
                }
            }

            if (sum > 0)
            {
                Console.WriteLine("Sum of first 5 positive numbers: {0}", sum);
            }
            else
            {
                Console.WriteLine("Product of last 5 non-positive numbers: {0}", product);
            }

        }
    }
}