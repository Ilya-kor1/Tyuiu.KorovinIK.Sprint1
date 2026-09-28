using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorovinIK.Sprint1.Task3.V8.Lib;

public class DataService : ISprint1Task3V8
{

    public double IncomeAmount(double startAmount, double percent, double timeDays)
    {
        double income = startAmount * (percent / 100) * (timeDays / 365);
        double result = startAmount + income;

        return Math.Round(result, 3);
    }

}
