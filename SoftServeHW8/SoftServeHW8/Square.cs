using System;
using System.Collections.Generic;
using System.Text;

namespace SoftServeHW8
{
    class Square:Shape
    {
        public double side;

        public Square(string modelName,double modelSide):base(modelName)
        {
            side = modelSide;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimetr()
        {
            return 4*side;
        }

        public override string ToString()
        {
            return ($"Name: {Name} Side: {side} Perimetr: {Perimetr()} Area: {Area()}");
        }
    }
}
