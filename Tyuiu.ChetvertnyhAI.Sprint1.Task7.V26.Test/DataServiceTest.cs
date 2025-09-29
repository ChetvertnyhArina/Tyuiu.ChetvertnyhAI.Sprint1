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
            double x = 2;
            double y = 4;
            double wait = 0.753902659;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}
