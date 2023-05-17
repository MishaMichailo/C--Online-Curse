namespace Exeption_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter first num: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second num : ");
                int num2 = Convert.ToInt32(Console.ReadLine());


                double res = Divide(num1, num2);
                Console.WriteLine($"Result of division: {res}");

                if (num1 == ',' && num2 == ',')
                {
                    throw new Exception("Throwing exception if dividing of two double numbers");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Throwing exception if dividing of two double numbers: {ex.Message}");
            }



        }
        static double Divide(double num1, double num2)
        {
            if (num1 == 0.0 || num2 == 0.0)
            {
                throw new DivideByZeroException("dividing of two double numbers not allowed");
            }

            return num1 / num2;
        }

    }

    
}
      
        
    
