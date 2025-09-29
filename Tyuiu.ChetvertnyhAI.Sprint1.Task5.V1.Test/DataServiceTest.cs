using Tyuiu.ChetvertnyhAI.Sprint1.Task5.V1.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 4;
            double y1 = 3;
            double x2 = 8;
            double y2 = 6;

            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, result);


        }
    }
}
