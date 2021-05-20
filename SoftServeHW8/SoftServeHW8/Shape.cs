using System;

namespace SoftServeHW8
{
    abstract class Shape
    {
        public string Name;
        public string _Name
        {
            get { return Name; }
            set { Name = value; }
        }
        public Shape(string modelName)
        {
            Name = modelName;
        }
        public abstract double Area();

        public abstract double Perimetr();

        public abstract override string ToString();
    }
}
