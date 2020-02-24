using System;

namespace ConsoleApp6
{
    public delegate void Go(ref int Player2Pos);

    class Game
    {
        public event Go Player1 = null;
        public event Go Player2 = null;

        public void Player1Event(ref int Player1Pos)
        {
            if (Player1 != null)
                Player1.Invoke(ref Player1Pos);
        }

        public void Player2Event(ref int Player2Pos)
        {
            if (Player2 != null)
                Player2.Invoke(ref Player2Pos);
        }

        public void Start(ref int Player1Pos, ref int Player2Pos)
        {
            bool run = true;
            while (run)
            {
                ConsoleKeyInfo s = Console.ReadKey();
                switch (s.KeyChar)
                {
                    case '1':
                        Player1Event(ref Player1Pos);
                        break;
                    case '2':
                        Player2Event(ref Player2Pos);
                        break;
                    case 'q':
                        run = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }

    class Program
    {
        static private void Player1_Handler(ref int Player1Pos)
        {
            if (Player1Pos > 100)
            {
                Console.Clear();
                Console.WriteLine("Player 1 win!");
            }
            else
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(Player1Pos, 1);
                Player1Pos += 1;
                Console.Write("#");
            }
        }

        static private void Player2_Handler(ref int Player2Pos)
        {
            if (Player2Pos > 100)
            {
                Console.Clear();
                Console.WriteLine("Player 2 win!");
            }
            else
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Console.Write(" ");
                Console.SetCursorPosition(Player2Pos, 9);
                Player2Pos += 1;
                Console.Write("#");
            }
        }

        static void Main(string[] args)
        {
            int Player1Pos = 9;
            int Player2Pos = 9;
            string finish = "FINISH";

            Console.WriteLine("        |");
            Console.WriteLine("Player 1|");
            Console.WriteLine("        |");
            Console.WriteLine("        S");
            Console.WriteLine("        T");
            Console.WriteLine("        A");
            Console.WriteLine("        R");
            Console.WriteLine("        T");
            Console.WriteLine("        |");
            Console.WriteLine("Player 2|");
            Console.WriteLine("        |");

            for (int i = 0; i < 11; i++)
            {
                if (i > 1 && i < 8)
                {
                    Console.SetCursorPosition(102, i);
                    Console.WriteLine(finish[i - 2]);
                }
                else
                {
                    Console.SetCursorPosition(102, i);
                    Console.WriteLine("|");
                }
            }

            Game game = new Game();

            game.Player1 += new Go(Player1_Handler);
            game.Player2 += Player2_Handler;

            game.Start(ref Player1Pos, ref Player2Pos);
        }
    }
}