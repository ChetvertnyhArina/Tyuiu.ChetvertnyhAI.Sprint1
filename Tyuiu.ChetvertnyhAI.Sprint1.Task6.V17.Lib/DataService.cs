using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ChetvertnyhAI.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            
            string original = value;

            
            char[] s = value.ToCharArray();
            Array.Reverse(s);
            string reversed = new string(s);

            
            return original.Equals(reversed);
        }
    }
}
