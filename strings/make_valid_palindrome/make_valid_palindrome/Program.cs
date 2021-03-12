using System;

namespace make_valid_palindrome
{
    class Program
    {
        public static bool ValidPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    /*
                     * Move one character to left
                     * or 
                     * Move one character to right
                    */
                    bool isLeftRemoval = IsPalindromeString(s, left + 1, right);
                    bool isRightRemoval = IsPalindromeString(s, left, right - 1);
                    return isLeftRemoval || isRightRemoval;
                }

                left++;
                right--;
            }

            return true;
        }

        public static bool IsPalindromeString(string s, int left, int right)
        {
            while (left < right)
            {
                if (s[left++] != s[right--])
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            bool res0 = ValidPalindrome("deeee");
            bool res1 = ValidPalindrome("aba");
            bool res2 = ValidPalindrome("abca");
        }
    }
}
