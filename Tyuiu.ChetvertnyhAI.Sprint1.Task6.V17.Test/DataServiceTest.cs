using Tyuiu.ChetvertnyhAI.Sprint1.Task6.V17.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "шалаш";
            DataService ds = new DataService();
            bool res = ds.CheckPalindrome(strTest);
            bool expected = true;
            Assert.AreEqual(expected, res);
        }
    }
}
