using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    class Triangle : Shape
    {
        public Triangle(string name) : base(name) { }
        public Triangle(string name, double len) : base(name, len) { }
        public Triangle(string name, double len, string color) : base(name, len, color) { }
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
        public override void Draw()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine(Name);
            Console.WriteLine(Length);
            Console.WriteLine(Area);
            Console.WriteLine(Perimeter);
        }
    }
}
