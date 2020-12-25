using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSorting
{
    class SortingAlgorithm
    {
       
        public int SumUpNumbers(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

     
        public int TakeRowWithMaxNumber(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }

            return max;
        }

   
        public int TakeRowWithMinNumber(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            return min;
        }

     
        public int[][] SwapRows(int[][] arr, int i1, int i2)
        {
            var temp = arr[i2];
            arr[i2] = arr[i1];
            arr[i1] = temp;
            return arr;
        }

        public int[][] SortByRowSum(int[][] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (this.SumUpNumbers(arr[i]) > this.SumUpNumbers(arr[i - 1]))
                    {
                        this.SwapRows(arr, i, i - 1);
                    }
                }
            }

            return arr;
        }

    
        public int[][] SortByRowMax(int[][] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (this.TakeRowWithMaxNumber(arr[i]) > this.TakeRowWithMaxNumber(arr[i - 1]))
                    {
                        this.SwapRows(arr, i, i - 1);
                    }
                }
            }

            return arr;
        }

        public int[][] SortByRowMin(int[][] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    if (this.TakeRowWithMinNumber(arr[i]) < this.TakeRowWithMinNumber(arr[i - 1]))
                    {
                        this.SwapRows(arr, i, i - 1);
                    }
                }
            }

            return arr;
        }
    }
}
