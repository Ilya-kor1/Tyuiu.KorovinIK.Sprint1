using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorovinIK.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            char firstLetter = value[0];

            return value.IndexOf(firstLetter, 1) != -1;
        }
    }
}
