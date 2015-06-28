using System.IO;
using System;

namespace Project1{
    public class Program
    {
        static void Main()
        {

            Console.ReadKey();
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