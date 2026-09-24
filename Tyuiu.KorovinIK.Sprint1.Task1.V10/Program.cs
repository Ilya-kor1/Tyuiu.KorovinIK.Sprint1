using Tyuiu.KorovinIK.Sprint1.Task1.V10.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task1.V10;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнлил: Коровин И. К. | ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* Спринт #1                                                               c *");

        Console.WriteLine("* Тема: Организация ввода/вывода в консольных приложениях                          *");

        Console.WriteLine("* Задание #1                                                               *");

        Console.WriteLine("* Вариант #10                                                               *");

        Console.WriteLine("* Выполнил: Коровин Илья Константиновичч | ИСТНб-26-1                       *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* УСЛОВИЕ:                                                                  *");

        Console.WriteLine("* Написать программу, которая вычесляет выражение (x + y) / (1 + x)  *");

        Console.WriteLine("* одинаковых массивов по длинне.                                           *");

        Console.WriteLine("*                                                                           *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* (x + y) / (1 + x)                                                             *");

        Console.WriteLine("*****************************************************************************");

       
        double x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));

        Console.WriteLine();
    }
}
