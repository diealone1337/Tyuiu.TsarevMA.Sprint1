using Tyuiu.TsarevMA.Sprint1.Task3.V16.Lib;
namespace Tyuiu.TsarevMA.Sprint1.Task3.V16
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* Вариант 16                                                                   *");
            Console.WriteLine("* Задание: Вычисление коэффициента приведенного квадратного уравнения          *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            double x1, x2;

            Console.WriteLine("Введите значение корня x1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение корня x2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double res = ds.CoeffOfQuadraticEquation(x1, x2);

            Console.WriteLine("Коэффициент b приведенного квадратного уравнения = " + res);

            Console.ReadKey();
        }
    }
}
