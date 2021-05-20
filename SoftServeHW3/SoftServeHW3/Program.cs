using System;

namespace SoftServeHW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------FirstTask-----------------");
            Console.WriteLine("Enter your text: ");
            int aCount = 0, oCount = 0, iCount = 0, eCount = 0;
            string text = Console.ReadLine();

            foreach (var letter in text)
            {
                if (letter == 'a')
                {
                    aCount += 1;
                }
                if (letter == 'o')
                {
                    oCount += 1;
                }
                if (letter == 'i')
                {
                    iCount += 1;
                }
                if (letter == 'e')
                {
                    eCount += 1;
                }
            }

            Console.WriteLine($"a count:{aCount}\r\no count:{oCount}\r\ni count:{iCount}\r\ne count:{eCount}");

            Console.WriteLine("--------------------SecondTask-------------------\r\nEnter the num of month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine($"In {month} month {DateTime.DaysInMonth(2021, month)} days");

            Console.WriteLine("--------------------ThirdTask------------------- ");

            double[] nums = new double[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Enter {i + 1} num: ");
                float num = float.Parse(Console.ReadLine());
                nums[i] = num;
            }

            Console.WriteLine("Your numbers: ");
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }

            if (nums[0] > 0 & nums[1] > 0 & nums[2] > 0 & nums[3] > 0 & nums[4] > 0)
            {
                double sum = 0;
                Console.WriteLine("\r\nThe first 5 numbers are positive!");
                for (int i = 0; i <= 4; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine($"Your sum of first 5 numbers {sum}");
            }
            else
            {
                Console.WriteLine("\r\nThe first 5 numbers are not positive!");
                double dob = 1;
                for (int i = 9; i >= 5; i--)
                {
                    dob *= nums[i];
                }
                Console.WriteLine($"Your dob of first 5 numbers {dob}");
            }
        }
    }
}
