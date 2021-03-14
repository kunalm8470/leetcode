using System;
using System.Collections.Generic;

namespace backspace_string_compare
{
    class Program
    {
		public static bool BackspaceCompare(string S, string T)
		{
			Stack<char> stkS = new Stack<char>();
			for (int i = 0; i < S.Length; i++)
			{
				if (S[i] != '#')
				{
					stkS.Push(S[i]);
				}
				else if (stkS.Count != 0)
				{
					stkS.Pop();
				}
			}

			Stack<char> stkT = new Stack<char>();
			for (int i = 0; i < T.Length; i++)
			{
				if (T[i] != '#')
				{
					stkT.Push(T[i]);
				}
				else if (stkT.Count != 0)
				{
					stkT.Pop();
				}
			}

			while (stkS.Count != 0)
            {
				char currentS = stkS.Pop();

				if (stkT.Count == 0 || currentS != stkT.Pop())
                {
					return false;
                }
            }

			return stkS.Count == 0 && stkT.Count == 0;
		}

		static void Main(string[] args)
        {
            bool res0 = BackspaceCompare("bxj##tw", "bxj###tw");
            bool res1 = BackspaceCompare("ab#c", "ad#c");
            bool res2 = BackspaceCompare("ab##", "c#d#");
            bool res3 = BackspaceCompare("a##c", "a##c");
            bool res4 = BackspaceCompare("aaa###a", "aaaa###a");
		}
    }
}
