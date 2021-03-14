using System;
using System.Collections.Generic;

namespace long_pressed_name
{
    class Program
    {
        /// <summary>
        /// https://leetcode.com/problems/long-pressed-name
        /// </summary>
        /// <param name="name"></param>
        /// <param name="typed"></param>
        /// <returns></returns>
        public static bool IsLongPressedName(string name, string typed)
		{
			if (name[0] != typed[0]) return false;
			if (name == typed) return true;

			int i = 0;
			int j = 0;

			/*
			 * Iterate over the larger string as it encompasses
			 * the smaller string
			*/
			while (j < typed.Length)
			{
				if (i < name.Length && name[i] == typed[j])
				{
					i++;
					j++;
				}

				// Check if long pressed or no, by comparing with previous character
				else if (typed[j] == typed[j - 1])
				{
					j++;
				}

				else
                {
					return false;
                }
			}

			return i == name.Length;
		}

		static void Main(string[] args)
        {
            bool res0 = IsLongPressedName("xnhtq", "xhhttqq");
            bool res1 = IsLongPressedName("alex", "aaleex");
            bool res2 = IsLongPressedName("saeed", "ssaaedd");
            bool res3 = IsLongPressedName("leelee", "lleeelee");
            bool res4 = IsLongPressedName("laiden", "laiden");
            bool res5 = IsLongPressedName("rick", "kric");
            bool res6 = IsLongPressedName("a", "b");
            bool res7 = IsLongPressedName("bdad", "bbbd");
		}
    }
}
