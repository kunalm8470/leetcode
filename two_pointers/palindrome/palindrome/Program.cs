using System;
using System.Text.RegularExpressions;

namespace palindrome
{
    class Program
    {
        public static bool IsPalindrome(string s)
        {
            if (s == string.Empty)
            {
                return true;
            }

            s = Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty);

            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (char.ToUpperInvariant(s[i]) != char.ToUpperInvariant(s[length - 1 - i]))
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            bool res1 = IsPalindrome("A man, a plan, a canal: Panama");
            bool res2 = IsPalindrome("");
            bool res3 = IsPalindrome("kayak");
            bool res4 = IsPalindrome("race a car");
            bool res5 = IsPalindrome("0P");
        }
    }
}
