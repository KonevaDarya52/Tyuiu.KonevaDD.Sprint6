
using Tyuiu.KonevaDD.Sprint6.Task0.V13.Lib;

namespace Tyuiu.KonevaDD.Sprint6.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService dataService = new DataService();
            int x = 3;
            double expected = 4.5;

            double actual = dataService.Calculate(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
