using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, sum, option;
            bool a, b;
            Random random = new Random();

            do
            {
                Console.Write("Enter M: ");
                a = int.TryParse(Console.ReadLine(), out M);
                if (M <= 0 || !a)
                    Console.WriteLine("ERROR!");
            } while (M <= 0 || !a);
            int[,] arr = new int[M, M];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = random.Next(0, 100);
                }
            }

            do
            {
                Console.WriteLine("Array: ");
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                Console.WriteLine("Choose the option: ");
                Console.WriteLine("1) Sum of the main diagonal;");
                Console.WriteLine("2) Sum of the side diagonal;");
                Console.WriteLine("0) Exit;");

                do
                {
                    b = int.TryParse(Console.ReadLine(), out option);
                    if (option < 0 || !b)
                        Console.WriteLine("ERROR!");
                } while (option < 0 || !b);

                switch (option)
                {
                    case 1:
                        sum = 0;
                        for (int i = 0; i < M; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if (i == j)
                                    sum += arr[i, j];
                            }
                        }
                        Console.WriteLine($"Sum 1 = {sum}");
                        Console.WriteLine();
                        break;
                    case 2:
                        sum = 0;
                        for (int i = 0; i < M; i++)
                        {
                            for (int j = 0; j < M; j++)
                            {
                                if(i + j == M - 1)
                                    sum += arr[i, j];
                            }
                        }
                        Console.WriteLine($"Sum 2 = {sum}");
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            } while (option != 0);
        }
    }
}
