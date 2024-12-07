using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KonevaDD.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int length = stopValue - startValue + 1;
            double[] result = new double[length];

            for (int i = 0; i < length; i++)
            {
                double x = startValue + i;
                double denominator = 2 - 2 * x;
                double value;

                if (Math.Abs(denominator) < 1e-10)
                {
                    value = 0;
                }
                else
                {
                    value = Math.Cos(x) + (Math.Sin(x) / denominator) - 4 * x;
                }

                result[i] = value;
            }

            return result;
        }
    }
}
