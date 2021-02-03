using System;
using System.Collections.Generic;

namespace isomorphic_strings
{
    class Program
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            int[] lookupS = new int[256];
            int[] lookupT = new int[256];
            int counter = 1;
            for (int i = 0; i < s.Length; i++)
            {
                // Not matching early-exit
                if (lookupS[s[i]] != lookupT[t[i]])
                {
                    return false;
                }

                // First time huh ?
                if (lookupS[s[i]] == 0)
                {
                    lookupS[s[i]] = counter;
                    lookupT[t[i]] = counter;
                    counter += 1;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            bool res1 = IsIsomorphic("egg", "add");
            bool res2 = IsIsomorphic("foo", "bar");
            bool res3 = IsIsomorphic("paper", "title");
            bool res4 = IsIsomorphic("badc", "baba");
        }
    }
}
