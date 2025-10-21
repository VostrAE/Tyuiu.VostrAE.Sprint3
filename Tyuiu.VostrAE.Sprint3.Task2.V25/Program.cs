using Tyuiu.VostrAE.Sprint3.Task2.V25.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        int value = 5;
        int startValue = 1;
        int endValue = 13;
        Console.WriteLine("Переменная n = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + endValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, endValue));
        Console.ReadKey();
    }
}