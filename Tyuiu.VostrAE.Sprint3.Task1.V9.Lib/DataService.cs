using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VostrAE.Sprint3.Task1.V9.Lib
{
    public class DataService : ISprint3Task1V9
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MultiplySeries = 1;
            while (startValue <= stopValue)
            {
                MultiplySeries = MultiplySeries* Math.Pow(300 / (Math.Cos(value)+Math.Pow(value, startValue)), startValue);
                startValue++;
            }
            return Math.Round(MultiplySeries, 3);
        }
    }
}
