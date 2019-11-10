using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    public class Square : Shape
    {
        public Square(string name) : base(name) { }
        public Square(string name, double len) : base(name, len) { }
        public Square(string name, double len, string color) : base(name, len, color) { }
        public override double area()
        {
            Area = Length * Length;
            return Area;
        }
        public override double perimeter()
        {
            Perimeter = 4 * Length;
            return Perimeter;
        }
    }
}
