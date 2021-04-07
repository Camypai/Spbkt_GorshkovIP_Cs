using System;
using System.Collections.Generic;
using System.Linq;


namespace Spbkt_GorshkovIP_Cs.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }



        public Point( IEnumerable<int> ints)
        {
            var enumerable = ints as int[] ?? ints.ToArray();
            X = enumerable[0];
            Y = enumerable[1];
        }

        public int Compare(Point point)
        {
            var result = 0;

            var sumSqrCat1 = Math.Pow(X, 2)       + Math.Pow(Y, 2);
            var sumSqrCat2 = Math.Pow(point.X, 2) + Math.Pow(point.Y, 2);
            
            var gip1 = Math.Sqrt(sumSqrCat1);
            var gip2 = Math.Sqrt(sumSqrCat2);

            if (gip1 > gip2)
            {
                result = 1;
            }
            else if (gip1 < gip2)
            {
                result = -1;
            }
            
            return result;
        }
    }
}