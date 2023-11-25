using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Spriint3.TaskReview.V25.Lib;

namespace Tyuiu.MolodykhVY.Sprint3.TaskReview.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int l = stopValue - startValue + 1;
            double[] num = new double[l];
            num[0] = 4.67;
            num[1] = 0.43;
            num[2] = -8.26;
            num[3] = -9.87;
            num[4] = -3.98;
            num[5] = 0.00;
            num[6] = 0.02;
            num[7] = -1.87;
            num[8] = 3.74;
            num[9] = 16.43;
            num[10] = 24.67;
            double[] res = new double[l];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(num, res);
        }
    }
}
