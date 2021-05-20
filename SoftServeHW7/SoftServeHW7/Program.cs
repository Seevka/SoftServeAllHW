using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace SoftServeHW7
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();

            myDict = File.ReadAllLines(@"C:\Users\Sevka\source\repos\SoftServeHW7\SoftServeHW7\phones.txt")
                                       .Select(x => x.Split('-'))
                                       .ToDictionary(x => x[0], x => x[1]);

            var onlyPhoneNumbers = myDict.Values.ToList();
            var onlyPhoneNames = myDict.Keys.ToList();
            List<string> newOnlyPhoneNumbers = new List<String>();

            using (StreamWriter file = new StreamWriter(@"C:\Users\Sevka\source\repos\SoftServeHW7\SoftServeHW7\Phoness.txt"))
                foreach (var entry in myDict)
                {
                    file.WriteLine($"{entry.Value}");
                }

            Console.WriteLine("Enter Id of the user u wanna to find: ");
            var userSearch = Console.ReadLine();
            var foundUserPhone = myDict.FirstOrDefault(x => x.Key == userSearch).Value;
            if (foundUserPhone == null)
            {
                Console.WriteLine("No such user!");
            }
            else
            {
                Console.WriteLine($"The number of  {userSearch} is: {foundUserPhone}");
            }

            List<string> listToChange = new List<string>();
            foreach (var tempKey in myDict.Keys)
            {
                if (myDict[tempKey].StartsWith("80"))
                {
                    listToChange.Add(tempKey);
                }
            }

            foreach(var item in listToChange)
            {
                myDict[item] = "+3" + myDict[item];
            }

            //foreach (var number in onlyPhoneNumbers)
            //{
            //    if (number[0] != '+')
            //    {
            //        var firstTempNum = number;
            //        var tempNum = "+3";
            //        newOnlyPhoneNumbers.Add(tempNum + firstTempNum);
            //    }
            //    else
            //    {
            //        newOnlyPhoneNumbers.Add(number);
            //    }
            //}

            //var dict = onlyPhoneNames.Zip(newOnlyPhoneNumbers, (k, v) => new { Key = k, Value = v })
            //         .ToDictionary(x => x.Key, x => x.Value);

            using (StreamWriter file = new StreamWriter(@"C:\Users\Sevka\source\repos\SoftServeHW7\SoftServeHW7\New.txt"))
                foreach (var entry in myDict)
                {
                    file.WriteLine($"{entry.Key}-{entry.Value}");
                }
        }
    }
}
