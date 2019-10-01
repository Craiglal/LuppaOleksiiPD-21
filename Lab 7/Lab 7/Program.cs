using System;

namespace Lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            bool a;

            do
            {
                Console.Write("Enter the number: ");
                a = int.TryParse(Console.ReadLine(), out number);
                if (number <= 0 || !a)
                    Console.WriteLine("Wrong number!");
            } while (number <= 0 || !a);

            Console.WriteLine(number);
            Console.WriteLine();

            int counter = number.ToString().Length;
            for (int i = 0; i < counter; i++)
            {
                int temp = number % 10;
                number = number / 10;
                Console.Write(temp);
            }
            Console.WriteLine();

            string str = Console.ReadLine();

            counter = str.Length;
            for (int i = counter - 1; i >= 0 ; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }
    }
}
