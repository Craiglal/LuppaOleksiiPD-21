using System;

namespace Lab_7_task_7
{
    class Program
    {
        static int[] Reverse(int[] input, int N)
        {
            int[] temp = new int[N];

            for (int i = N - 1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = input[i];
            }

            return temp;
        }

        static int[] Reverse(ref int[] input, int N)
        {
            int[] temp = new int[N];

            for (int i = N - 1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = input[i];
            }

            return temp;
        }

        static void Reverse(int[] input, int N, out int[] temp)
        {
            temp = new int[N];

            for (int i = N - 1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = input[i];
            }
        }

        static void Main(string[] args)
        { 
            int N;
            bool a;
            Random random = new Random();

            do
            {
                Console.Write("Enter the number: ");
                a = int.TryParse(Console.ReadLine(), out N);
                if (N <= 0 || !a)
                    Console.WriteLine("Wrong number!");
            } while (N <= 0 || !a);
            int[] arr = new int[N];


            for (int i = 0; i < N; i++)
            {
                arr[i] = random.Next(10, 100);
                Console.Write(arr[i] + " ");
            }

            arr = Reverse(arr, N);
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " ");
            }

            arr = Reverse(ref arr, N);
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Reverse(arr, N, out arr);
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
