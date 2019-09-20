using System;
using System.Linq;

namespace Lab_5._30
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            bool a, b;
            Random random = new Random();

            do
            {
                Console.Write("Enter M: ");
                a = int.TryParse(Console.ReadLine(), out M);
                if (M <= 0 || !a)
                    Console.WriteLine("ERROR!");
            } while (M <= 0 || !a);

            do
            {
                Console.Write("Enter N: ");
                b = int.TryParse(Console.ReadLine(), out N);
                if (N <= 0 || !b)
                    Console.WriteLine("ERROR!");
            } while (N <= 0 || !b);
            int[,] arrA = new int[M, N];
            int[][] arr = new int[M][];
            for (int i = 0; i < M; i++)
            {
                arr[i] = new int[N];
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int.TryParse(Console.ReadLine(), out arr[i][j]);
                    //arr[i][j] = random.Next(0, 50);
                }
            }

            Console.WriteLine("Array: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int max = arr[i].Cast<int>().Max();
                    int min = arr[i][j];
                    for (int k = 0; k < M; k++)
                    {
                        if (min > arr[k][j])
                            min = arr[k][j];
                    }

                    if (max == arr[i][j] && min == arr[i][j])
                        arrA[i, j] = arr[i][j];
                    else
                        arrA[i, j] = 0;

                }
            }

            Console.WriteLine("Result: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{arrA[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
