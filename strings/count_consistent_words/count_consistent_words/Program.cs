using System;
using System.Collections.Generic;

namespace count_consistent_words
{
    class Program
    {
        /// <summary>
        /// https://leetcode.com/problems/count-the-number-of-consistent-strings/
        /// </summary>
        /// <param name="allowed"></param>
        /// <param name="words"></param>
        /// <returns></returns>
        public static int CountConsistentStrings(string allowed, string[] words)
        {
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            for (int i = 0; i < allowed.Length; i++)
            {
                if (!lookup.ContainsKey(allowed[i]))
                {
                    lookup[allowed[i]] = 1;
                }
                else
                {
                    lookup[allowed[i]] += 1;
                }
            }

            int consistentWords = 0;
            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                bool isConsistentWord = true;
                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (!lookup.ContainsKey(currentWord[j]))
                    {
                        isConsistentWord = false;
                        break;
                    }
                }

                if (isConsistentWord) consistentWords++;
            }

            return consistentWords;
        }

        static void Main(string[] args)
        {
            int res1 = CountConsistentStrings("ab", new string[] { "ad", "bd", "aaab", "baa", "badab" });
            int res2 = CountConsistentStrings("abc", new string[] { "a", "b", "c", "ab", "ac", "bc", "abc" });
            int res3 = CountConsistentStrings("cad", new string[] { "cc", "acd", "b", "ba", "bac", "bad", "ac", "d" });
        }
    }
}
