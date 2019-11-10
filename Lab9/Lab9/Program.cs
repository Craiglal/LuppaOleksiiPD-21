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

            Triangle t = new Triangle("Треуголник", 10);
            Console.WriteLine($"Периметр {t.Name}а = {t.Perimeter}");
            Console.WriteLine($"Площадь {t.Name}а = {t.Area}");
            Console.WriteLine($"Цвет {t.Name}а = {t.Color}");
            Console.WriteLine();

            Circle c = new Circle("Круг", 5, "Grey");
            Console.WriteLine($"Периметр {c.Name}а = {c.Perimeter}");
            Console.WriteLine($"Площадь {c.Name}а = {c.Area}");
            Console.WriteLine($"Цвет {c.Name}а = {c.Color}");
            Console.WriteLine();
        }
    }
}
