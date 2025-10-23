using Tyuiu.VostrAE.Sprint3.Task4.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        Console.WriteLine("Старт шага: " + startValue);
        Console.WriteLine("Конец шага: " + stopValue);



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма ряда: " + ds.Calculate(startValue, stopValue));
        Console.ReadKey();
    }
}