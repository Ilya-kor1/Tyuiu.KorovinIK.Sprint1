using Tyuiu.KorovinIK.Sprint1.Task4.V26.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task4.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнлил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #1                                                               c *");

            Console.WriteLine("* Тема: Class Math                          *");

            Console.WriteLine("* Задание #4                                                              *");

            Console.WriteLine("* Вариант #26                                                               *");

            Console.WriteLine("* Выполнил: Коровин Илья Константиновичч | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("*  Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле и печатает его на экране.   *");

            Console.WriteLine("*                                                                           *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("(arctg(x)+y)/e^(x+y) =  " + ds.Calculate(x, y));

            Console.ReadLine();
        }

    }
}
