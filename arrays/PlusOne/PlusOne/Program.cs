using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace PlusOne
{
    class Program
    {
        public static int[] PlusOne(int[] digits)
        {
            if (digits == default(int[]) || digits.Length == 0)
            {
                return Array.Empty<int>();
            }

            if (digits.Length == 1 && digits[0] <= 8)
            {
                digits[0] += 1;
                return digits;
            }

            string num = string.Join(string.Empty, digits);

            bool startsWithZeroes = false;
            int leadingZeroCount = 0;
            if (num.StartsWith('0'))
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i] != '0' || (i == num.Length - 1 && num[i] == '0'))
                    {
                        break;
                    }

                    else if (num[i] == '0')
                    {
                        leadingZeroCount += 1;
                    }
                }

                startsWithZeroes = true;
            }

            BigInteger num1 = BigInteger.Parse(num);
            num1 += 1;
            
            string numString = startsWithZeroes
                ? string.Join(string.Empty, new string('0', leadingZeroCount), num1.ToString())
                : num1.ToString();

            return numString.Select(x => Convert.ToInt32(new string(x, 1))).ToArray();
        }

        static void Main(string[] args)
        {
            int[] digits = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 6 };
            int[] res = PlusOne(digits);
        }
    }
}
