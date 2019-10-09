using System;

namespace Lab_7
{
    class Program
    {
        static int NumberOne(int input)
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

            return output;
        }

        static string StrOne(string input)
        {
            string output = "";
            int counter = input.Length;

            for (int i = counter - 1; i >= 0; i--)
            {
                output += input[i];
            }

            return output;
        }

        static double NumberTwo(double input)
        {
            string result = "";
            string[] temp = input.ToString().Split('.', ',');

            for (int i = temp[0].Length - 1; i >= 0; i--)
            {
                result += temp[0][i];
            }

            result += ",";

            for (int i = temp[1].Length - 1; i >= 0; i--)
            {
                result += temp[1][i];
            }

            double.TryParse(result, out double output);

            return output;
        }

        static string StrTwo(string input)
        {
            string output = "";
            string[] temp = input.ToString().Split(',');
            for (int i = 0; i < temp.Length; i++)
            {
                for (int j = temp[i].Length - 1; j >= 0; j--)
                {
                    output += temp[i][j];
                    
                }
                if (temp.Length != i + 1)
                    output += ',';
            }

            return output;
        }

        static void Main(string[] args)
        {
            int numberOne;                                  //Перше завдання,початок 
            bool a;

            do                                             
            {
                Console.Write("Enter the number: ");
                a = int.TryParse(Console.ReadLine(), out numberOne);
                if (!a)
                    Console.WriteLine("Wrong number!");
            } while (!a);

            Console.WriteLine(NumberOne(numberOne));         //Перше завдання, кінець   


            string str = Console.ReadLine();              //Друге завдання, початок 

            Console.WriteLine(StrOne(str));                  //Друге завдання, кінець 


            double numberTwo;                               //Третє завдання, початок 

            do
            {
                Console.Write("Enter the number: ");
                a = double.TryParse(Console.ReadLine(), out numberTwo);
                if (!a)
                    Console.WriteLine("Wrong number!");
            } while (!a);

            Console.WriteLine(NumberTwo(numberTwo));        //Третє завдання, кінець 


            str = Console.ReadLine();                       //Четверте завдання, початок 

            Console.WriteLine(StrTwo(str));                 //Четверте завдання, кінець 

        }
    }
}
