using System;
using System.Collections.Generic;
using System.Linq;

namespace word_pattern
{
    class Program
    {
        public static bool WordPattern(string pattern, string s)
        {
            string[] splitArr = s.Split(' ');
            if (pattern.Length != splitArr.Length)
            {
                return false;
            }

            Dictionary<char, string> lookup = new Dictionary<char, string>();

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!lookup.ContainsKey(pattern[i]))
                {
                    if (lookup.Values.Contains(splitArr[i]))
                    {
                        return false;
                    }

                    lookup[pattern[i]] = splitArr[i];
                }
                else if (lookup[pattern[i]] != splitArr[i])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            bool res1 = WordPattern("abba", "dog cat cat dog");
            bool res2 = WordPattern("abba", "dog cat cat fish");
            bool res3 = WordPattern("aaaa", "dog cat cat dog");
            bool res4 = WordPattern("abba", "dog dog dog dog");
            bool res5 = WordPattern("e", "eureka");
            bool res6 = WordPattern("aba", "dog cat cat");
        }
    }
}
