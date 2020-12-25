using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3._1
{
    public class NewtonSqrtN
    {
        NewtonPow pow = new NewtonPow();
        public double SqrtN(double n, double A, double eps = 0.001)
        {
            var x0 = A / n;
            var x1 = (1 / n) * ((n - 1) * x0 + A / pow.Pow(x0, (int)n - 1));

            while (Math.Abs(x1 - x0) > eps)
            {
                x0 = x1;
                x1 = (1 / n) * ((n - 1) * x0 + A / pow.Pow(x0, (int)n - 1));
            }

            return x1;
        }

    }
}
