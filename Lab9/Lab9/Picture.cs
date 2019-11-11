using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    class Picture
    {
        List<Shape> shapes;
        int amount { get; set; }

        public Picture() 
        {
            shapes = new List<Shape>(0);
        }
        public Picture(int n) 
        {
            shapes = new List<Shape>(n);
        }

        public Shape this[int index]
        {
            get
            {
                if (index >= 0 && index < shapes.Count)
                    return shapes[index];
                else
                {
                    Console.WriteLine("Попытка обращения за пределы массива.");
                    return null;
                }
            }
            set
            {
                if (index >= 0 && index < shapes.Count)
                    shapes[index] = value;
                else
                    Console.WriteLine("Попытка записи за пределами массива.");
            }
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DeleteByName(string name)
        {
            shapes.Remove(shapes.Find(x => x.Name == name));
        }

        public void DeleteByType(string type)
        {
            shapes.Remove(shapes.Find(x => x.GetType().ToString() == type.ToString()));
        }

        public void DeleteByLength(string type)
        {
            shapes.RemoveAll(x => x.Area > 100);
        }

        interface IDraw<Circle>
        {
            public void Draw()
            {
                Console.WriteLine();
            }
        }
    }
}
