using System;
using System.Collections.Generic;
using System.Linq;

namespace is_anagram
{
    class Program
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> lookup = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!lookup.ContainsKey(s[i]))
                {
                    lookup[s[i]] = 1;
                }
                else
                {
                    lookup[s[i]] += 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!lookup.ContainsKey(t[i]))
                {
                    return false;
                }
                else
                {
                    lookup[t[i]] -= 1;
                }
            }

            return lookup.Values.All(x => x == 0);
        }

        static void Main(string[] args)
        {
            bool res1 = IsAnagram("anagram", "nagaram");
            bool res2 = IsAnagram("rat", "car");
        }
    }
}
