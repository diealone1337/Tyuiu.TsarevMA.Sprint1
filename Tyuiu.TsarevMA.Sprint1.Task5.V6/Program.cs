using Tyuiu.TsarevMA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.TsarevMA.Sprint1.Task5.V6
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
            Console.WriteLine("********************************************************************************");

            int k;

            Console.WriteLine("Введите номер дня года (k от 1 до 365):");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("День недели (1-Пн, 2-Вт, 3-Ср, 4-Чт, 5-Пт, 6-Сб, 7-Вс) = " + ds.Calculate(k));

            Console.ReadLine();
        }
    }
}