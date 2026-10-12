using Tyuiu.TsarevMA.Sprint1.Task0.V20.Lib;
namespace Tyuiu.TsarevMA.Sprint1.Task0.V20
{ 
        class Programm
        {
            static void Main(string[] args)
        {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Царёв М. А. | СМАРТб-26-1";
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #1                                                                 *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                          *");
        Console.WriteLine("* Задание #0                                                                 *");
        Console.WriteLine("* Вариант #20                                                                *");
        Console.WriteLine("* Выполнил: Царёв Максим Александрович | СМАРТб-26-1                        *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать одну программу, которая вычисляет выражение 10 + (9 / 3)         *");
        Console.WriteLine("* и печатает результат на экране.                                           *");
        Console.WriteLine("*                                                                           *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* 10 + (9 / 3)                                                              *");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
        }
    }
}
