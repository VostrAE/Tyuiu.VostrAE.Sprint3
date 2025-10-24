using Tyuiu.VostrAE.Sprint3.Task3.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(" Исходные данные:                                                         *");
        Console.WriteLine("***************************************************************************");
        string value = "fifa al fall";
        char replaceable = 'a';
        char replacement = '*';
        Console.WriteLine("Исходная строка: " + value);
        Console.WriteLine("Искомый символ: " + replaceable);
        Console.WriteLine("Замененный символ: " + replacement);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Измененная строка: " + ds.ReplaceCharInString(value, replaceable, replacement));
        Console.ReadKey();
    }
}