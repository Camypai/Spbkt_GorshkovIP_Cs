using System;


namespace Spbkt_GorshkovIP_Cs.Extensions
{
    public static class IntExtension
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static int Pow(this int number, int grade)
        {
            var result = 1;

            for (var i = 0; i < grade; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}