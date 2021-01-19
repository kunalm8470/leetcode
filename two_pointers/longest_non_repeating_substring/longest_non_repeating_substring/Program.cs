using System;
using System.Collections.Generic;

namespace longest_non_repeating_substring
{
    class Program
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int i = 0, j = 0;
            int max = 0;
            HashSet<char> hs = new HashSet<char>();

            while (j < s.Length)
            {
                if (!hs.Contains(s[j]))
                {
                    hs.Add(s[j]);
                    j += 1;
                    max = Math.Max(max, hs.Count);
                }
                else
                {
                    hs.Remove(s[i]);
                    i += 1;
                }
            }

            return max;
        }

        static void Main(string[] args)
        {
            int res1 = LengthOfLongestSubstring("abcabcbb");
            int res2 = LengthOfLongestSubstring("bbbbb");
            int res3 = LengthOfLongestSubstring("pwwkew");
            int res4 = LengthOfLongestSubstring("");
        }
    }
}
