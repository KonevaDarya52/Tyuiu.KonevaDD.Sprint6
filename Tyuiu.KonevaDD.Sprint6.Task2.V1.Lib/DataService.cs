using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KonevaDD.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] output = new double[stopValue - startValue + 1];
            for (int x = startValue, i = 0; i < output.Length; i++, x++)
            {
                double result = Math.Round (Math.Cos(x) + Math.Sin(x) / 2 - 2 * x - 4 * x,2);
                if (!double.IsNaN(result))
                {
                    output[i] = result;
                }
                else
                {
                    output[i] = 0;
                }
            }
            return output;
        }
    }
}
