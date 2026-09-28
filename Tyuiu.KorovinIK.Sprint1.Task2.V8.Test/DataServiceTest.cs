using Tyuiu.KorovinIK.Sprint1.Task2.V8.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2500;
            double y = 20;
            double z = 30;
            double wait = 2541.096;
            var res = ds.IncomeAmount(x, y, z);
            Assert.AreEqual(wait, res);

        }
    }
}
