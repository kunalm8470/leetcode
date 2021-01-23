using System;
using System.Collections.Generic;

namespace happy_number
{
    class Program
    {
        public static int find_pdi(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int rem = n % 10;
                sum += rem * rem;
                n /= 10;
            }
            return sum;
        }

        public static bool IsHappy(int n)
        {
            HashSet<int> hs = new HashSet<int>();
            while (n != 1 && !hs.Contains(n))
            {
                hs.Add(n);
                n = find_pdi(n);
            }

            return n == 1;
        }

        static void Main(string[] args)
        {
            bool res1 = IsHappy(19);
            bool res2 = IsHappy(2);
            bool res3 = IsHappy(7);
        }
    }
}
