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
            double x = 5;
            double y = 5;
            double wait = 0.591;
            var res = Math.Round(ds.Calculate(x, y), 3);
            Assert.AreEqual(wait, res);

        }
    }
}
