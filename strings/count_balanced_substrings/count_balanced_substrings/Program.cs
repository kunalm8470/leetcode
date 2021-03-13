using System;
using System.Collections.Generic;
using System.Text;

namespace count_balanced_substrings
{
    class Program
    {
		public static int BalancedStringSplit(string s)
		{
			int balancedPairCount = 0;

			int counter = 0;
			for (int i = 0; i < s.Length; i++)
            {
				if (s[i] == 'R')
                {
					counter++;
                }
				else if (s[i] == 'L')
                {
					counter--;
                }

				if (counter == 0)
                {
					balancedPairCount++;
                }
            }

			return balancedPairCount;
		}

		static void Main(string[] args)
        {
			int res1 = BalancedStringSplit("RLRRLLRLRL");
			int res2 = BalancedStringSplit("RLLLLRRRLR");
			int res3 = BalancedStringSplit("LLLLRRRR");
			int res4 = BalancedStringSplit("RLRRRLLRLL");
		}
    }
}
