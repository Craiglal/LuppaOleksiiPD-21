using Lab9_1;
using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square("Квадрат");
            Console.WriteLine($"Периметр {s.Name}а = {s.Perimeter}");
            Console.WriteLine($"Площадь {s.Name}а = {s.Area}");
            Console.WriteLine($"Цвет {s.Name}а = {s.Color}");
            Console.WriteLine();

            Picture picture = new Picture();
            picture.AddShape(s);
            picture.DeleteByType("Square");
        }
    }
}
