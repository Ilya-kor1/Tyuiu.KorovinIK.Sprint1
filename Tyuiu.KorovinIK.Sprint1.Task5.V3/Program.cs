using Tyuiu.KorovinIK.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнлил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #1                                                               c *");

            Console.WriteLine("* Тема: Преобразование типов и класс Convert                          *");

            Console.WriteLine("* Задание #5                                                              *");

            Console.WriteLine("* Вариант #3                                                               *");

            Console.WriteLine("* Выполнил: Коровин Илья Константиновичч | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("*  Написать программу, которая решает следующую задачу:Присвоить целой переменной h третью от конца цифру в записи положительного целого числа k.   *");

            Console.WriteLine("*                                                                           *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            int k;

            Console.WriteLine("Введите значение K");
            k = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Значение h = " + ds.Calculate(k));

            Console.ReadLine();
        }
    }
}
