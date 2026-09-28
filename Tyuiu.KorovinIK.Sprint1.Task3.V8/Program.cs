using Tyuiu.KorovinIK.Sprint1.Task3.V8.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнлил: Коровин И. К. | ИСНТб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #1                                                               c *");

            Console.WriteLine("* Тема: Операторы составного присваивания                          *");

            Console.WriteLine("* Задание #3                                                              *");

            Console.WriteLine("* Вариант #8                                                               *");

            Console.WriteLine("* Выполнил: Коровин Илья Константиновичч | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("*  Написать программу вычисления величины дохода по вкладу.   *");

            Console.WriteLine("*                                                                           *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            double x, y, z;

            Console.WriteLine("Величина вклада (руб.)");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Срок вклада (дней)");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Процентная ставка (годовых)");
            z = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Сумма по окончании срока вклада: = " + ds.IncomeAmount(x, y, z));

            Console.ReadLine();
        }

    }
}
