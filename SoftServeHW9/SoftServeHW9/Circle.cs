using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServeHW9
{
    class Circle : Shape
    {
        public double radius;

        public Circle(string modelName, double modelRadius) : base(modelName)
        {
            radius = modelRadius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override double Perimetr()
        {
            return 2 * Math.PI * radius;
        }
        public override string ToString()
        {
            return ($"Name: {Name} Radius: {radius} Perimetr: {Perimetr()} Area: {Area()}");
        }
    }
}
