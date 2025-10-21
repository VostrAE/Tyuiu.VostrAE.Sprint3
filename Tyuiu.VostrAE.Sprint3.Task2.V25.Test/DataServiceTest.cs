using Tyuiu.VostrAE.Sprint3.Task2.V25.Lib;
namespace Tyuiu.VostrAE.Sprint3.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int StartValue = 1;
            int EndValue = 13;
            double res = ds.GetSumSeries(value, EndValue, StartValue);
            double wait = 16;
            Assert.AreEqual(wait, res);
        }
    }
}
