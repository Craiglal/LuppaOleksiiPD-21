using System;

namespace Lab_7_task_6
{
    class Program
    {
        static void Reverse(int input, int counter, string result, int i)
        {           
            if (i < counter)
            {
                int temp = input % 10;
                input = input / 10;
                result += temp;
                i++;

                Reverse(input, counter, result, i);
            }
            else
            {
                int.TryParse(result, out int output);

                Console.WriteLine(output);
            }
        }

        static void Reverse(string input, int counter, string result)
        {
            if (counter >= 0)
            {
                result += input[counter];
                counter--;

                Reverse(input, counter, result);
            }
            else
            {
                Console.WriteLine(result);
            } 
        }

        static void ReverseSplit(string result, string[] temp, int counterOne, int counterTwo)
        {
            if (counterOne >= 0)
            {
                result += temp[0][counterOne];
                if (counterOne == 0)
                    result += ',';

                counterOne--;

                ReverseSplit(result, temp, counterOne, counterTwo);
            }
            else if (counterTwo >= 0)
            {
                result += temp[1][counterTwo];
                counterTwo--;

                ReverseSplit(result, temp, counterOne, counterTwo);
            }
            else
            {
                double.TryParse(result, out double output);

                Console.WriteLine(output);
            }
        }

        static void ReverseSplit(string input, string result, int counter, string[] temp, int i)
        {
            if (i >= 0 && counter < temp.Length)
            {
                result += temp[counter][i];
                i--;
                ReverseSplit(input, result, counter, temp, i);
            }
            else if (counter == temp.Length)
            {
                Console.WriteLine(result);
            }
            else
            {
                if(counter < temp.Length - 1)
                    result += ',';
                i = temp[counter].Length - 1;
                counter++;
                ReverseSplit(input, result, counter, temp, i);
            }
        }

        static void Main(string[] args)
        {
            int numberOne;
            bool a;

            do
            {
                Console.Write("Enter the number: ");
                a = int.TryParse(Console.ReadLine(), out numberOne);
                if (!a)
                    Console.WriteLine("Wrong number!");
            } while (!a);
            string result = "";
            int counter = numberOne.ToString().Length;
            int i = 0;

            Reverse(numberOne, counter, result, i);

            string str = Console.ReadLine();
            result = "";
            counter = str.Length - 1;

            Reverse(str, counter, result); ;

            double numberTwo;
            do
            {
                Console.Write("Enter the number: ");
                a = double.TryParse(Console.ReadLine(), out numberTwo);
                if (!a)
                    Console.WriteLine("Wrong number!");
            } while (!a);
            result = "";
            string[] temp = numberTwo.ToString().Split('.', ',');
            int counterOne = temp[0].Length - 1, counterTwo = temp[1].Length - 1;

            ReverseSplit(result, temp, counterOne, counterTwo);

            str = Console.ReadLine();
            result = "";
            temp = str.ToString().Split(',');
            counter = 0;
            i = temp[0].Length - 1;

            ReverseSplit(str, result, counter, temp ,i);
        }
    }
}
