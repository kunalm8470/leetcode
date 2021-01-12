using System;
using System.Numerics;

namespace string_multiply
{
    class Program
    {
        public static string Multiply(string num1, string num2)
        {
            BigInteger b1 = BigInteger.Parse(num1);
            BigInteger b2 = BigInteger.Parse(num2);
            return (b1 * b2).ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply("2", "3"));
        }
    }
}
