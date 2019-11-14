using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    enum Colors
    {
        White = 0,
        Black,
        Blue,
        Orange,
        Red,
        Green
    }
    public abstract class Shape : IDraw
    {
        public double Area;
        public double Perimeter;
        public string Name { get; }
        public ConsoleColor Color { get; set; }
        public double Length { get; set; }
        public abstract double area();
        public abstract double perimeter();
        public abstract void Draw();

        public Shape(string name)
        {
            Random rand = new Random();
            this.Name = name;
            this.Length = rand.Next(0, 100);
            int temp = rand.Next(0, 6);
            var color = Enum.Parse(typeof(ConsoleColor), ((Colors)temp).ToString());
            this.Color = (ConsoleColor)color;

            Area = area();
            Perimeter = perimeter();
        }
        public Shape(string name, double len)
        {
            Random rand = new Random();
            this.Name = name;
            this.Length = len;
            int temp = rand.Next(0, 6);
            var color = Enum.Parse(typeof(ConsoleColor), ((Colors)temp).ToString());
            this.Color = (ConsoleColor)color;

            Area = area();
            Perimeter = perimeter();
        }
        public Shape(string name, double len, string _color)
        {
            Random rand = new Random();
            this.Name = name;
            this.Length = len;
            var color = Enum.Parse(typeof(ConsoleColor), _color);
            this.Color = (ConsoleColor)color;

            Area = area();
            Perimeter = perimeter();
        }
    }
}
