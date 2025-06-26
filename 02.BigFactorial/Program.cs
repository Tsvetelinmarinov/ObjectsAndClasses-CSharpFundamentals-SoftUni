/*
 * 02.BigFactorial
 */

using System.Numerics;

namespace _02.BigFactorial
{
    class Program
    {
        static void Main()
        {  
            ushort number = ushort.Parse(Console.ReadLine() ?? "666");
            Console.WriteLine(Factorial(number));
        }

        static BigInteger Factorial(ushort number = 666)
        {
            BigInteger baseNumber = 1;
            for (int i = 2; i <= number; i++)
            {
                baseNumber *= i;
            }

            return baseNumber;
        }
    }
}
