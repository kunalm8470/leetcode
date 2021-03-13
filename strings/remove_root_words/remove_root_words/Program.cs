using System;
using System.Collections.Generic;

namespace remove_root_words
{
    class Program
    {
        /// <summary>
        ///  https://leetcode.com/problems/string-matching-in-an-array/
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IList<string> StringMatching(string[] words)
        {
            IList<string> result = new List<string>();

            Array.Sort(words, (a, b) => a.Length - b.Length);

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[j].IndexOf(currentWord) != -1)
                    {
                        result.Add(currentWord);
                        break;
                    }
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            IList<string> res1 = StringMatching(new[] { "mass", "as", "hero", "superhero" });
            IList<string> res2 = StringMatching(new[] { "leetcode", "et", "code" });
            IList<string> res3 = StringMatching(new[] { "blue", "green", "bu" });
        }
    }
}
