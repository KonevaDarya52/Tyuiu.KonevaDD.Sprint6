using tyuiu.cources.programming.interfaces.Sprint6;
using System;

namespace Tyuiu.KonevaDD.Sprint6.Task2.V1.Lib
{
    public class DataService : ISprint6Task2V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] output = new double[stopValue - startValue + 1];
            for (int x = startValue, i = 0; i < output.Length; i++, x++)
            {
                double denominator = 2 - 2 * x;
                double result;

                if (Math.Abs(denominator) < 1e-10)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Cos(x) + (Math.Sin(x) / denominator) - 4 * x;
                }

                output[i] = Math.Round(result, 2);
            }
            return output;
        }
    }
}
