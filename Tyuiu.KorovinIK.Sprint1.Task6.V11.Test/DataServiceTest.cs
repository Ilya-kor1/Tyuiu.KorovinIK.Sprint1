using Tyuiu.KorovinIK.Sprint1.Task6.V11.Lib;
namespace Tyuiu.KorovinIK.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString1()
        {
            DataService ds = new DataService();
            string srtTest = "Hi ticher";

            bool res = ds.CheckeFirstLetterRepetition(srtTest);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidString2()
        {
            DataService ds = new DataService();

            string srtTest = "Hi Hunter";

            bool res = ds.CheckeFirstLetterRepetition(srtTest);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
