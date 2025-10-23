using Tyuiu.VostrAE.Sprint3.Task4.V3.Lib;
namespace Tyuiu.VostrAE.Sprint3.Task4.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double res = ds.Calculate(startValue, stopValue);
            double wait = -0.274;
            Assert.AreEqual(res, wait);

        }
    }
}
