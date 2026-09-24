using Tyuiu.KorovinIK.Sprint1.Task0.V21.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнлил: Коровин И. К. | ИСНТб-26-1";

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* Спринт #1                                                               c *");

        Console.WriteLine("* Тема: Создание итогового решения по спринту                               *");

        Console.WriteLine("* Задание #0                                                                *");

        Console.WriteLine("* Вариант #21                                                               *");

        Console.WriteLine("* Выполнил: Коровин Илья Константиновичч | ИСТНб-26-1                       *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* УСЛОВИЕ:                                                                  *");

        Console.WriteLine("* Написать программу, которая вычесляет выражение 3 * 4 + 10 / 2  *");

        Console.WriteLine("* одинаковых массивов по длинне.                                           *");

        Console.WriteLine("*                                                                           *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* 3 * 4 + 10 / 2                                                             *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");

        Console.WriteLine("*****************************************************************************");

        Console.WriteLine(ds.Calculate());

        Console.ReadLine();

    }
}