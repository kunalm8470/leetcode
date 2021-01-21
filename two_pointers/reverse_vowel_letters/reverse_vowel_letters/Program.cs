using System;
using System.Text;

namespace reverse_vowel_letters
{
    class Program
    {
        public static bool IsVowel(char ch)
        {
            ch = char.ToUpperInvariant(ch);
            if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                return true;
            }

            return false;
        }

        public static string ReverseVowels(string s)
        {
            StringBuilder builder = new StringBuilder(s);

            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                if (IsVowel(builder[i]) && IsVowel(builder[j]))
                {
                    char temp = builder[i];
                    builder[i] = builder[j];
                    builder[j] = temp;
                    i += 1;
                    j -= 1;
                }
                else
                {
                    if (!IsVowel(builder[i]))
                    {
                        i += 1;
                    }

                    if (!IsVowel(builder[j]))
                    {
                        j -= 1;
                    }
                }
            }
            
            return builder.ToString();
        }

        static void Main(string[] args)
        {
            string res1 = ReverseVowels("leetcode");
            string res2 = ReverseVowels("hello");
        }
    }
}
