﻿using Tyuiu.VostrAE.Sprint3.Task0.V5.Lib;
namespace Tyuiu.VostrAE.Sprint3.Task0.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int endValue = 10;
            double res = ds.GetSumSeries(startValue, endValue);
            double wait = 81.083;
            Assert.AreEqual(res, wait);
        }
    }
}

