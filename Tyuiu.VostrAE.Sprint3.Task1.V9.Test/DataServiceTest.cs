using Tyuiu.VostrAE.Sprint3.Task1.V9.Lib;
namespace Tyuiu.VostrAE.Sprint3.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 4;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(res, wait);
        }
    }
}
