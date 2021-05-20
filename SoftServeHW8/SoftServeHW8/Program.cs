using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftServeHW8
{
    class Program
    {
        public static void Main()
        {
            List<Shape> listOfShapes = new List<Shape>();

            Console.WriteLine("Working with square");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter name of square: ");
                var addName = Console.ReadLine();
                Console.WriteLine("Enter the side lenght: ");
                var addSide = double.Parse(Console.ReadLine());
                listOfShapes.Add(new Square("Square", addSide));
            }

            Console.WriteLine("Working with circle");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter name of circle: ");
                var addName = Console.ReadLine();
                Console.WriteLine("Enter the radius: ");
                var addSide = double.Parse(Console.ReadLine());
                listOfShapes.Add(new Circle("Circle", addSide));
            }

            OutPut(listOfShapes);
            var theLargestPerimetr = listOfShapes.Single(x => x.Perimetr() == listOfShapes.Max(x=>x.Perimetr()));
            Console.WriteLine(theLargestPerimetr.Name);
            listOfShapes= listOfShapes.OrderBy(x=>x.Area()).ToList();
            OutPut(listOfShapes);

        }
        public static void OutPut(List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
