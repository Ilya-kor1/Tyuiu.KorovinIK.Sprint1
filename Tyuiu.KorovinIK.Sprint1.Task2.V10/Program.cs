using Tyuiu.KorovinIK.Sprint1.Task2.V10.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнлил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #1                                                               c *");

            Console.WriteLine("* Тема: Арифметические операторы C#                          *");

            Console.WriteLine("* Задание #2                                                               *");

            Console.WriteLine("* Вариант #10                                                               *");

            Console.WriteLine("* Выполнил: Коровин Илья Константиновичч | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("*  Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.  *");

            Console.WriteLine("*                                                                           *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            int x;

            Console.WriteLine("Расстояние в метрах (целое число)");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Расстояние в дюймах = " + ds.ConvertMetreToInchs(x));

            Console.ReadLine();
        }
    }
}
