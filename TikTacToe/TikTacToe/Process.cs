using System.Drawing;
using System.Windows.Forms;

namespace TikTacToe
{
    class Process
    {
        public string[,] steps = new string[3, 3];
        public int Player = 0;
        public bool Win;

        public void Step(Point p)
        {
            if (steps[p.X, p.Y] != null || Win) 
                return;

            steps[p.X, p.Y] = Player == 0 ? "X" : "O";
            if (isWin("X") || isWin("O"))
            {
                Win = true;
                return;
            }
            Player ^= 1;
        }

        private bool isWin(string state)
        {
            if (steps[0, 0] == state && steps[1, 1] == state && steps[2, 2] == state)
                return true;
            if (steps[0, 2] == state && steps[1, 1] == state && steps[2, 0] == state)
                return true;
            for (int i = 0; i < 3; i++)
            {
                if (steps[i, 0] == state && steps[i, 1] == state && steps[i, 2] == state)
                    return true;
                if (steps[0, i] == state && steps[1, i] == state && steps[2, i] == state)
                    return true;
            }
               
            return false;
        }

        public Process Clone()
        {
            Process clone = new Process
            {
                steps = (string[,])steps.Clone(),
                Player = Player,
                Win = Win
            };
            return clone;
        }

    }
}