using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTacToe
{
    class Step : IComparable<Step>
    {
        public Point Point;
        public float Fit;
        public int CompareTo(Step other)
        {
            var result = Fit.CompareTo(other.Fit);

            if (result == 0 && Point.X == 1 && Point.Y == 1)
                return 1;
            else
                return result;
        }
    }
}
