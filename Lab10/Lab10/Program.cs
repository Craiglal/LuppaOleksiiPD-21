using System;

namespace Lab10
{
    static class Program
    {
        static void Reverse(this int input)
        {
            string result = "";

            int counter = input.ToString().Length;

            for (int i = 0; i < counter; i++)
            {
                int temp = input % 10;
                input = input / 10;
                result += temp;
            }

            int.TryParse(result, out int output);

            Console.WriteLine(output);
        }

        static void Reverse(this string input)
        {
            string output = "";

            int counter = input.Length;

            for (int i = counter - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine(output);
        }

        static void ReverseSplit(this string input)
        {
            string output = "";

            string[] temp = input.ToString().Split(',');

            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = temp[i].Length - 1; j >= 0; j--)
                    output += temp[i][j];
                if (temp.Length != i + 1)
                    output += ',';
            }

            Console.WriteLine(output);
        }

        static void ReverseSplit(double input)
        {
            string result = "";

            string[] temp = input.ToString().Split('.', ',');

            for (int i = temp[0].Length - 1; i >= 0; i--)
                result += temp[0][i];

            result += ",";

            for (int i = temp[1].Length - 1; i >= 0; i--)
                result += temp[1][i];

            double.TryParse(result, out double output);

            Console.WriteLine(output);
        }

        static int[] Reverse(this int[] input, int N)
        {
            int[] temp = new int[N];

            for (int i = N - 1, j = 0; i >= 0; i--, j++)
            {
                temp[j] = input[i];
            }

            return temp;
        }
        static void SortArray(this int[] input)
        {
            Array.Sort(input);
        }

        static void Main(string[] args)
        {
            
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = new Random().Next(10, 100);
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine(arr[i]);
            Console.WriteLine();

            arr.SortArray();

            for (int i = 0; i < 10; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
