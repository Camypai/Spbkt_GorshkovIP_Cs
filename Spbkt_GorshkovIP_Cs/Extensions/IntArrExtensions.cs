using System;


namespace Spbkt_GorshkovIP_Cs.Extensions
{
    public static class IntArrExtensions
    {
        public static void FillRand(this int[,] arr, int min = 0, int max = 1)
        {

            var rand = new Random(DateTime.Now.Millisecond);
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(min, max+1);
                }
            }
        }

        public static void ReplaceBy(this int[,] arr, Func<int, int, bool> predicate)
        {
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = predicate(i, j) ? 0 : arr[i, j];
                }
            }
        }

        public static string Show(this int[,] arr)
        {
            var result = string.Empty;
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    result +=  $"{arr[i, j]} ";
                }

                result += "\n";
            }

            return result;
        }

        public static int SumByMainDiagonal(this int[,] arr)
        {
            var result = 0;
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        result += arr[i, j];
                    }
                }
            }


            return result;
        }

        public static int FindMin(this int[,] arr)
        {
            var result = int.MaxValue;
            
            for (var i = 0; i < arr.GetLength(0); i++)
            {
                for (var j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < result)
                    {
                        result = arr[i, j];
                    }
                }
            }


            return result;
        }
    }
}