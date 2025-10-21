using Tyuiu.VostrAE.Sprint3.Task0.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        int startValue = 1;
        int endValue = 10;
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + endValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Cумма ряда = " + ds.GetSumSeries(startValue, endValue));
        Console.ReadKey();
    }
}

