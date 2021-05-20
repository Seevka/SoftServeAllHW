using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace SoftServeHW9
{
    class Program
    {

        public static void Main()
        {
            List<Shape> listOfShapes = new List<Shape>();
            Console.WriteLine("Working with square");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name of square: ");
                var addName = Console.ReadLine();
                Console.WriteLine("Enter the side lenght: ");
                var addSide = double.Parse(Console.ReadLine());
                listOfShapes.Add(new Square(addName, addSide));
            }

            Console.WriteLine("Working with circle");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter name of circle: ");
                var addName = Console.ReadLine();
                Console.WriteLine("Enter the radius: ");
                var addSide = double.Parse(Console.ReadLine());
                listOfShapes.Add(new Circle(addName, addSide));
            }

            OutPut(listOfShapes);

            var listInRange = from shape in listOfShapes where shape.Area() <= 100 & shape.Area() >= 10 select shape;
            using (StreamWriter file = new StreamWriter(@"C:\Users\Sevka\source\repos\SoftServeHW9\SoftServeHW9\ListInRange.txt"))
                foreach (var shape in listInRange)
                {
                    file.WriteLine(shape);
                }

            var containsLetter = from shape in listOfShapes where shape.Name.Contains("a") select shape;
            using (StreamWriter file = new StreamWriter(@"C:\Users\Sevka\source\repos\SoftServeHW9\SoftServeHW9\ContainsLetter.txt"))
                foreach (var shape in containsLetter)
                {
                    file.WriteLine(shape);
                }
            Console.WriteLine("Less then 5: ");
            for(int i= listOfShapes.Count-1; i>=0;i--)
            {
              if(listOfShapes[i].Area()<5)
                {
                    listOfShapes.RemoveAt(i);
                }
            }
            OutPut(listOfShapes);


            //var theLargestPerimetr = listOfShapes.Single(x => x.Perimetr() == listOfShapes.Max(x => x.Perimetr()));
            //Console.WriteLine(theLargestPerimetr.Name);
            //var sortedShapes = listOfShapes.OrderBy(x => x.Area());
            //OutPut(sortedShapes.ToList());

        }
        public static void OutPut(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
