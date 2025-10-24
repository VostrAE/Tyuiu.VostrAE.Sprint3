using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.VostrAE.Sprint3.Task5.V20.Lib
{
    public class DataService : ISprint3Task5V20
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSumSeries= 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++) {
                for (k = startValue2; k <= stopValue2; k++) {
                    SumSumSeries = SumSumSeries + Math.Pow((x/Math.Sin(x)), startValue2);
                }
            }
            return Math.Round(SumSumSeries,3);
            
        }

    }
}
