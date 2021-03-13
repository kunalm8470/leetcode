using System;
using System.Collections.Generic;
using System.Text;

namespace count_good_numbers
{
    class Program
    {
		/// <summary>
		/// https://leetcode.com/problems/rotated-digits/
		/// </summary>
		/// <param name="N"></param>
		/// <returns></returns>
		public static int RotatedDigits(int N)
		{
			int goodNumberCounter = 0;
			for (int i = 1; i <= N; i++)
			{
				if (ValidateGoodNumber(i))
                {
					goodNumberCounter++;
                }
			}

			return goodNumberCounter;
		}

		public static bool ValidateGoodNumber(int num)
        {
			bool isGoodNumber = false;
			while (num > 0)
            {
				int rem = num % 10;
				num /= 10;

				switch (rem)
                {
					case 2:
					case 5:
					case 6:
					case 9:
						isGoodNumber = true;
						break;

					case 0:
					case 1:
					case 8:
						continue;

					default:
						return false;
                }
            }

			return isGoodNumber;
		}

		static void Main(string[] args)
        {
			int res1 = RotatedDigits(10);
			int res2 = RotatedDigits(2);
			int res3 = RotatedDigits(857);
		}
    }
}
