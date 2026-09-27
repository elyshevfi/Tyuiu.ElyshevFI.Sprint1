using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElyshevFI.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            var res = Math.Round(1 / Math.Sqrt(x - 5 * y), 3);
            return res;
        }
    }
}
