using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3._1
{
    public class NewtonPow
    {
        public double Pow(double a, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}
