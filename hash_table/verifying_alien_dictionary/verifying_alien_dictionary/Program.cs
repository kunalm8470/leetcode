using System;
using System.Collections.Generic;

namespace verifying_alien_dictionary
{
    class Program
    {
        public static bool IsAlienSorted(string[] words, string order)
        {
            Dictionary<char, int> lookup = new Dictionary<char, int>();
            for (int i = 0; i < order.Length; i++)
            {
                lookup[order[i]] = i;
            }

            for (int i = 1; i < words.Length; i++)
            {
                // Iterate for compareValue <= 0
                if (Compare(words[i - 1], words[i], ref lookup) > 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int Compare(string word1, string word2, ref Dictionary<char, int> lookup)
        {
            int i = 0, j = 0;
            int compareValue = 0;

            while (
                (i < word1.Length && j < word2.Length)
                && compareValue == 0
            )
            {
                compareValue = lookup[word1[i++]] - lookup[word2[j++]];
            }

            if (compareValue == 0)
            {
                return word1.Length - word2.Length;
            }

            return compareValue;
        }

        static void Main(string[] args)
        {
            bool res1 = IsAlienSorted(new[] { "hello", "leetcode" }, "hlabcdefgijkmnopqrstuvwxyz");
            bool res2 = IsAlienSorted(new[] { "word", "world", "row" }, "worldabcefghijkmnpqstuvxyz");
            bool res3 = IsAlienSorted(new[] { "apple", "app" }, "abcdefghijklmnopqrstuvwxyz");
        }
    }
}
