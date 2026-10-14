using Tyuiu.TsarevMA.Sprint1.Task4.V19.Lib;
namespace Tyuiu.TsarevMA.Sprint1.Task4.V19
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            double res = ds.Calculate(x, y);
            Console.WriteLine("(x + y) / |x - 2| = " +res);

            Console.ReadKey();
        }
    }
}