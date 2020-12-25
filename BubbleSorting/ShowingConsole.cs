using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class ShowingConsole
    {
        public static void ShowConsole(int[][] jaggedArray)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                System.Console.Write("Row number {0}: ", i);

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    System.Console.Write("{0}{1}", jaggedArray[i][j], j == (jaggedArray[i].Length - 1) ? "" : " ");
                }
                System.Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
