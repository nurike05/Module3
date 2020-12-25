using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3._1
{
    public class Program
    {
        public static void Main()
        {
            NewtonPow pow = new NewtonPow();
            NewtonSqrtN sqrt = new NewtonSqrtN();
            Console.WriteLine(sqrt.SqrtN(2, 5));
            Console.ReadKey();
        }
    }
}

