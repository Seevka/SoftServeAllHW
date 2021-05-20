using System;
using System.Linq;
using System.Web;

namespace SoftServe_HW2
{
    class Program
    {
        struct Dog
        {
            public string name { get; set; }
            public string mark { get; set; }
            public int age { get; set; }

            public void ToString()
            {
                Console.WriteLine($"Name: {name}  Mark: {mark} Age: {age}");
            }

        }

        static void ifBelongMaxMin(float[] nums)
        {
            foreach (var num in nums)
            {
                if (num <= 5 & num >= -5)
                {
                    Console.WriteLine($"{num} belongs to the range [-5;5]");
                }
                else
                {
                    Console.WriteLine($"{num} does not belong to the range [-5;5]");
                }
            }
            Console.WriteLine($"Max: {nums.Max()}\r\n Min: {nums.Min()}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------FirstTask-----------------------");
            float[] nums = new float[3];
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine($"Enter {i + 1} num: ");
                float num = float.Parse(Console.ReadLine());
                nums[i] = num;
            }
            ifBelongMaxMin(nums);

            Console.WriteLine("-------------------------SecondTask--------------------\r\nEnter the error number: ");
            int errorNum;
            errorNum = int.Parse(Console.ReadLine());
            switch ((HTTTPError)errorNum)
            {
                case HTTTPError.First:
                    Console.WriteLine("HTTP 400 Bad Request");
                    break;
                case HTTTPError.Second:
                    Console.WriteLine("401 Unauthorized Error");
                    break;
                case HTTTPError.Third:
                    Console.WriteLine("402 Payment Required");
                    break;
                default:
                    Console.WriteLine("Try again, uknown operation!");
                    break;
            }

            Console.WriteLine("-------------------------ThirdTask--------------------\r\n");
            string name;
            string mark;
            int age;
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter mark: ");
            mark = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
            Dog myDog = new Dog();
            myDog.name = name;
            myDog.mark = mark;
            myDog.age = age;
            myDog.ToString();

        }
    }
}
