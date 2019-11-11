using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    class Circle : Shape
    {
        public Circle(string name) : base(name) { }
        public Circle(string name, double len) : base(name, len) { }
        public Circle(string name, double len, string color) : base(name, len, color) { }
        public override double area()
        {
            Area = Length * Length * Math.Sqrt(3) / 4;
            return Area;
        }
        public override double perimeter()
        {
            Perimeter = 3 * Length;
            return Perimeter;
        }
    }
    interface IDraw<Circle>
    {
        public void Draw()
        {
            Console.WriteLine();
        }
    }
}
