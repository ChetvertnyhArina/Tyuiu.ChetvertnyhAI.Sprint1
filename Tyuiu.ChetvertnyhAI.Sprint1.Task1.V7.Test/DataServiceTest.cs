﻿using Tyuiu.ChetvertnyhAI.Sprint1.Task1.V7.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2, res);
        }
    }
}
