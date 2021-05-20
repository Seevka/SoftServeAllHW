using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServeHW5
{
    public class Programmer:IDeveloper
    {
        public string Tool { get; set; }
        public void Create(List<string> developers)
        {
            Console.WriteLine("Enter the tool for programmer");
            var builderTool = Console.ReadLine();
            bool alreadyExist = developers.Contains(builderTool);
            if (alreadyExist == true)
            {
                Console.WriteLine("Such tool exists!");
            }
            else
            {
                developers.Add(builderTool);
            }
        }

        public void Destroy(List<string> developers)
        {
            Console.WriteLine("Enter the tool for programmer to delete");
            var builderTool = Console.ReadLine();
            bool wasDelete = false;
            for (int i = 0; i < developers.Count; i++)
            {
                if (developers[i] == builderTool)
                {
                    developers.RemoveAt(i);
                    wasDelete = true;
                }
            }
            if (wasDelete == false)
            {
                Console.WriteLine("No such tool!");
            }
        }
        public void OutPut(List<string> developers)
        {
            foreach(var developer in developers)
            {
                Console.WriteLine($"Tool: {developer}");
            }
        }
    }
}
