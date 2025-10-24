using Tyuiu.VostrAE.Sprint3.Task6.V22.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        int startValue = 19;
        int stopValue = 31;
        Console.WriteLine("Старт шага суммы ряда: " + startValue);
        Console.WriteLine("Конец шага суммы ряда: " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Разультат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Сумма делителей: " + ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();
    }
}