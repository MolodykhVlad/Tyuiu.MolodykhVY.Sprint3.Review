using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolodykhVY.Spriint3.TaskReview.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            double m; int r = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (i == 0) m = 0;
                else m = Math.Round(Math.Cos(i) + ((4*i)/2) -( Math.Sin(i) * (3 * i)), 2);
                num[r] = m;
                r++;
            }
            return num;
        }
    }
}
