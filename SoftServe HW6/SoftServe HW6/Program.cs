using System;

namespace SoftServe_HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 1;
            int secondNum = 1;
            try
            {

                Console.WriteLine("Enter first number: ");
                firstNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("It is double value,so firstnum=1 by default");
            }
            try
            {
                Console.WriteLine("Enter first number: ");
                secondNum = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine($"It is double value, so secondnum=1 by default");
            }

            Dev(firstNum, secondNum);
            //numRange(1, 100);

        }
        static public void Dev(int first, int second)
        {
            try
            {
                Console.WriteLine($"{first}/{second}={first / second}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divider cannot be 0!");
            }
        }
        static public void numRange(int a, int b)
        {
            int num = 0;
            int tempNum=0;
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine($"Enter {i} num ");
                    num = int.Parse(Console.ReadLine());
                    if (num >= 100 | num <= 1)
                    {
                        throw new Exception("The num is out of range!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The num must be int!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error the num has to be <=100 and >=1", ex.Message);
                }
            }
        }
    }
}
