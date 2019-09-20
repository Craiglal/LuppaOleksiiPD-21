using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int M;
            bool a;
            List<object> list = new List<object>();

            do
            {
                Console.Write("Enter the number of objects: ");
                a = int.TryParse(Console.ReadLine(), out M);
                if (M <= 0 || !a)
                    Console.WriteLine("ERROR!");
            } while (M <= 0 || !a);

            for (int i = 0; i < M; i++)
            {
                Console.Write("Enter the object: ");
                list.Add(object.)
            }
        }
    }
}
