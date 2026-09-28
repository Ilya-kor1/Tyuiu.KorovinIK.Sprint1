using Tyuiu.KorovinIK.Sprint1.Task3.V8.Lib;

namespace Tyuiu.KorovinIK.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2500;
            double y = 30;
            double z = 20;

            double wait = 2541.096;

            var res = ds.IncomeAmount(x, z, y);

            Assert.AreEqual(wait, res);
        }
    }
}
