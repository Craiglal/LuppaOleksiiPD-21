using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, ch = 0, str = 0, intt = 0, dbl = 0, bl = 0;
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
                string inp = Console.ReadLine();

                if (int.TryParse(inp, out int inputInt))
                {
                    list.Add(inputInt);
                    intt++;
                }
                else if(double.TryParse(inp, out double inputDbl))
                {
                    list.Add(inputDbl);
                    dbl++;
                }  
                else if (char.TryParse(inp, out char inputCh))
                {
                    list.Add(inputCh);
                    ch++;
                }
                else if (bool.TryParse(inp, out bool inputBl))
                {
                    list.Add(inputBl);
                    bl++;
                }
                else
                {
                    list.Add(inp);
                    str++;
                }
            }

            Console.WriteLine($"Char = {ch}, string = {str}, int = {intt}, double = {dbl}, bool = {bl}");
            Console.ReadKey();
        }
    }
}
