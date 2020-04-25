using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTacToe
{
    class AITicTacToe
    {
        public Step BestStep(Process process)
        {
            if (!GetFreeSteps(process).Any())
                return null;
            else
                return GetFreeSteps(process).Select(p => GetFitness(process, p)).Max();
        }

        public Step GetFitness(Process process, Point p)
        {
            var res = new Step() 
            { 
                Point = p 
            };
            var pr = process.Clone();
            pr.Step(p);

            if (pr.Win)
                res.Fit = 1;
            else
            {
                Step best = BestStep(pr);
                if (best != null)
                    res.Fit = -best.Fit;
            }

            return res;
        }

        public IEnumerable<Point> GetFreeSteps(Process process)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (process.steps[i, j] == null)
                        yield return new Point(i, j);
                }
            }
        }
    }
}
