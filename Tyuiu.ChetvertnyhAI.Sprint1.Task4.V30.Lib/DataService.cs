using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task4.V30.Lib
{
    public class DataService : ISprint1Task4V30
    {
        public double Calculate(double x, double y)
        {
            var res = (x + Math.Pow(y, 3))/(Math.Exp(2-y));
            return res;
        }
    }
}
