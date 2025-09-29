using Tyuiu.ChetvertnyhAI.Sprint1.Task7.V26.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 1.1884054251388094;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
