using Tyuiu.KorovinIK.Sprint1.Task6.V11.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #1                                                               c *");

            Console.WriteLine("* Тема: Работа со строками класс String                          *");

            Console.WriteLine("* Задание #6                                                             *");

            Console.WriteLine("* Вариант #11                                                              *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что первая буква строки входит в нее еще раз.   *");

            Console.WriteLine("*                                                                           *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            string srtTest;

            Console.WriteLine("Введите слово");
            srtTest = Console.ReadLine();



            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            bool res = ds.CheckeFirstLetterRepetition(srtTest);

            Console.WriteLine("Первая буква входит в строку еще раз: " + res);


            Console.ReadLine();
        }
    }
}