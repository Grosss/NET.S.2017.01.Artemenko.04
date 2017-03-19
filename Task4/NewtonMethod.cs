using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public static class NewtonMethod
    {
        public static double ComputeNthRoot(double number, int power, double eps)
        {
            if (power < 1 || eps > 1)
                throw new ArgumentOutOfRangeException();
            if (number < 0 && (power % 2 == 0))
                throw new ArgumentException();

            double x0, x1 = number / power;
            do
            {
                x0 = x1;
                x1 = 1.0 / power * ((power - 1.0) * x0 + number / Math.Pow(x0, power - 1));
            } while (Math.Abs(x1 - x0) > eps);
            return x1;
        }
    }
}
