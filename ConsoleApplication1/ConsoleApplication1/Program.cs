using System.IO;
using System;

namespace Project1{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Smallestmultiple(20));
            Console.ReadKey();
        }


        // Public: method that find number that can be divided by all divisors
        //
        // maxDividor - the highest divisor
        //
        // Examples
        //
        //   Smallestmultiple(20)
        //   // => 232792560
        //
        // Returns the lowest number that can be divided by numbers from 1 to maxDivisor.
        public static long Smallestmultiple(int maxDivisor)
        {
            long dividedNumber = 0;
            bool dividable = false;

            while (dividable == false)
            {
                dividedNumber += maxDivisor;
                dividable = CheckIfDividable(dividedNumber, maxDivisor);

                if (dividable == true)
                {
                    return (dividedNumber);
                }
            }
            return 0;
        }




        // method that check if dividedNumber can be divided by numbers from maxDivisor to 1 
        public static bool CheckIfDividable(long dividedNumber, int maxDivisor)
        {
            for (int divisor = maxDivisor; divisor > 1; divisor--)
            {
                if (dividedNumber % divisor != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }


}