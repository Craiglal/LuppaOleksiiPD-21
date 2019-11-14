using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    class Picture : IDraw
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
            type = "Lab9_1." + type;
            shapes.Remove(shapes.Find(x => x.GetType().ToString() == type));
        }

        public void DeleteByLength(string type)
        {
            shapes.RemoveAll(x => x.Area > 100);
        }
        void IDraw.Draw()
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                shapes[i].Draw();
            }
        }
    }
}
