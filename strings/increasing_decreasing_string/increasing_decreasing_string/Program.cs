using System;
using System.Linq;
using System.Text;

namespace increasing_decreasing_string
{
    class Program
    {
        /// <summary>
        /// https://leetcode.com/problems/increasing-decreasing-string/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string SortString(string s)
        {
            int[] ranking = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                ranking[s[i] - 'a']++;
            }

            StringBuilder builder = new StringBuilder();
            while (ranking.Any(x => x != 0))
            {
                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (ranking[c - 'a'] != 0)
                    {
                        builder.Append(c);
                        ranking[c - 'a']--;
                    }
                }

                for (char c = 'z'; c >= 'a'; c--)
                {
                    if (ranking[c - 'a'] != 0)
                    {
                        builder.Append(c);
                        ranking[c - 'a']--;
                    }
                }
            }

            return builder.ToString();
        }

        static void Main(string[] args)
        {
            string res1 = SortString("aaaabbbbcccc");
            string res2 = SortString("rat");
            string res3 = SortString("leetcode");
            string res4 = SortString("ggggggg");
            string res5 = SortString("spo");
        }
    }
}
