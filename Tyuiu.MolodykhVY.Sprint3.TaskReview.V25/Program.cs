using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.MolodykhVY.Spriint3.TaskReview.V25.Lib;

namespace Tyuiu.MolodykhVY.Sprint3.TaskReview.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            int startValue = -5;
            int stopValue = 5;

            int l = ds.GetMassFunction(startValue, stopValue).Length;
            double[] num = new double[l];
            num = ds.GetMassFunction(startValue, stopValue);
            for (int i = 0; i <= l - 1; i++)
            {
                Console.WriteLine("{0,5:d}      {1,6:f2} ", startValue, num[i]);
                startValue++;
            }
            Console.ReadKey();
        }
    }
        
}
