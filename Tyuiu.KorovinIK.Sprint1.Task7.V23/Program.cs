using Tyuiu.KorovinIK.Sprint1.Task7.V23.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #1                                                               c *");

            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                           *");

            Console.WriteLine("* Задание #7                                                            *");

            Console.WriteLine("* Вариант #23                                                              *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных, вводимых пользователем.   *");

            Console.WriteLine("*      z = x - 10^(sin(x)) + (20*x^2)/(3*x^3) + cos(x^2 - y)                                                                     *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение X");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y");
            y = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            

            Console.WriteLine(("z = x - 10^(sin(x)) + (20*x^2)/(3*x^3) + cos(x^2 - y) =") + ds.Calculate(x,y));


            Console.ReadLine();
        }
    }
}

