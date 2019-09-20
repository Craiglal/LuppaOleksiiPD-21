using System;
using System.Linq;

namespace Lab_4._28
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, k, option;
            bool a, b, c;
            Random random = new Random();

            do
            {
                Console.Write("Enter N: ");
                a = int.TryParse(Console.ReadLine(), out N);
                if (N <= 0 || !a)
                    Console.WriteLine("ERROR!");
            } while (N <= 0 || !a);
            int[] arr = new int[N];

            do
            {
                Console.Write("Enter k: ");
                b = int.TryParse(Console.ReadLine(), out k);
                if (k <= 0 || !b)
                    Console.WriteLine("ERROR!");
            } while (k <= 0 || !b);

            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(0, 100);
            }

            do
            {
                if(arr.Length != 0)
                {
                    Console.WriteLine("Array: ");
                    for (int i = 0; i < N; i++)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                    Console.WriteLine();

                    Console.WriteLine("Choose the option: ");
                    Console.WriteLine("1) Del everything less then k;");
                    Console.WriteLine("2) Del everything == k;");
                    Console.WriteLine("3) Del everything more then k;");
                    Console.WriteLine("0) Exit;");
                    do
                    {
                        c = int.TryParse(Console.ReadLine(), out option);
                        if (option < 0 || !c)
                            Console.WriteLine("ERROR!");
                    } while (option < 0 || !c);
                }
                else
                {
                    Console.WriteLine("Array is empty!");
                    Console.WriteLine("0) Exit;");
                    do
                    {
                        c = int.TryParse(Console.ReadLine(), out option);
                        if (option != 0 || !c)
                            Console.WriteLine("ERROR!");
                    } while (option != 0 || !c);
                }

                switch (option)
                {
                    case 1:
                        for (int i = 0; i < N; i++)
                        {
                            if (arr[i] < k)
                            {
                                arr = arr.Where(val => val != arr[i]).ToArray();
                                i--;
                                N--;
                            }
                        }
                        break;
                    case 2:
                        for (int i = 0; i < N; i++)
                        {
                            if (arr[i] == k)
                            {
                                arr = arr.Where(val => val != arr[i]).ToArray();
                                i--;
                                N--;
                            }
                        }
                        break;
                    case 3:
                        for (int i = 0; i < N; i++)
                        {
                            if (arr[i] > k)
                            {
                                arr = arr.Where(val => val != arr[i]).ToArray();
                                i--;
                                N--;
                            }
                        }
                        break;
                    default:
                        break;
                }
            } while (option != 0);
        }
    }
}
