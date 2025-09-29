using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task7.V26.Lib
{
    public class DataService : ISprint1Task7V26
    {
        public double Calculate(double x, double y)
        {
            double res = (((Math.Pow(Math.Sin(x), 2)) + y) / (y + 1)) - (((x * y) - 12) / (34 + Math.Pow(x, 2)));
            return res;
        }
    }
}
