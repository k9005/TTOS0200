using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    abstract class Shapes
    {
        public string Name { get; set; }


        public abstract double Circumference();

        public abstract double Area();

    }

    class Rectangle : Shapes
    {
        double X { get; set; }
        double Y { get; set; }
        public Rectangle(double x, double y)
        {

            X = x;
            Y = y;
        }
        public override double Circumference()
        {
            return 2 * (X + Y);

        }
        public override double Area()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return "Rectangle Width = " + X + " Height = " + Y + " Area = " + Area() + " Circumference = " + Circumference();
        }
    }
    class Circle : Shapes
    {
        double Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return 3.14 * (2 * Radius);
        }
        public override double Circumference()
        {
            return 2 * 3.14 * Radius;
        }
        public override string ToString()
        {
            return "Circle Radius = " + Radius + " Area = " + Area() + " Circumference = " + Circumference();
        }
    }
}
