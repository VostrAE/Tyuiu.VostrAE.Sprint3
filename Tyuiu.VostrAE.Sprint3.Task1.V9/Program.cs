using Tyuiu.VostrAE.Sprint3.Task1.V9.Lib;
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
        int endValue = 4;
        Console.WriteLine("Переменная x = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + endValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Произведение ряда = " + ds.GetMultiplySeries(value,startValue, endValue));
        Console.ReadKey();
    }
}