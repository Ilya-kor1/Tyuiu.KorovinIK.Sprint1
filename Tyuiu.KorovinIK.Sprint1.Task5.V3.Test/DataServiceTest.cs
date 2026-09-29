using Tyuiu.KorovinIK.Sprint1.Task5.V3.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 130985;
            int h = 9;

            var result = ds.Calculate(k);

            Assert.AreEqual(h, result);

        }

    }
}
