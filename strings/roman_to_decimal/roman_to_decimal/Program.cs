using System;
using System.Collections.Generic;

namespace roman_to_decimal
{
    class Program
    {
		/// <summary>
		/// <para>https://leetcode.com/problems/roman-to-integer</para>
		/// <para>https://www.mathsisfun.com/roman-numerals.html</para>
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int RomanToInt(string s)
		{
			Dictionary<char, int> digitLookup = new Dictionary<char, int>
			{
				['I'] = 1,
				['V'] = 5,
				['X'] = 10,
				['L'] = 50,
				['C'] = 100,
				['D'] = 500,
				['M'] = 1000
			};

			List<int> digits = new List<int>();
			for (int i = 0; i < s.Length; i++)
			{
				digits.Add(digitLookup[s[i]]);
			}

			int sum = 0;
			for (int i = 0; i < digits.Count; i++)
			{
				if (i == digits.Count - 1)
                {
					sum += digits[i];
				}

				else
                {
					if (digits[i] < digits[i + 1])
					{
						sum -= digits[i];
					}

					else if (digits[i] >= digits[i + 1])
					{
						sum += digits[i];
					}
				}

			}

			return sum;
		}

		static void Main(string[] args)
        {
			int res1 = RomanToInt("III");
			int res2 = RomanToInt("IV");
			int res3 = RomanToInt("IX");
			int res4 = RomanToInt("LVIII");
			int res5 = RomanToInt("MCMXCIV");
			int res6 = RomanToInt("DCXXI");
			int res7 = RomanToInt("CXLIV");
		}
    }
}
