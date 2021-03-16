using System;
using System.Collections.Generic;
using System.Text;

namespace decrypt_string_from_alphabet_to_integer_mapping
{
    class Program
    {
        /// <summary>
        /// https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FreqAlphabets(string s)
        {
            ReadOnlySpan<char> span = s.AsSpan();
            Dictionary<string, char> lookup = new Dictionary<string, char>
            {
                ["1"] = 'a',
                ["2"] = 'b',
                ["3"] = 'c',
                ["4"] = 'd',
                ["5"] = 'e',
                ["6"] = 'f',
                ["7"] = 'g',
                ["8"] = 'h',
                ["9"] = 'i',

                ["10#"] = 'j',
                ["11#"] = 'k',
                ["12#"] = 'l',
                ["13#"] = 'm',
                ["14#"] = 'n',
                ["15#"] = 'o',
                ["16#"] = 'p',
                ["17#"] = 'q',
                ["18#"] = 'r',
                ["19#"] = 's',
                ["20#"] = 't',
                ["21#"] = 'u',
                ["22#"] = 'v',
                ["23#"] = 'w',
                ["24#"] = 'x',
                ["25#"] = 'y',
                ["26#"] = 'z',
            };

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '#')
                {
                    result.Append(lookup[new string(span.Slice(i - 2, 3))]);
                }
                else
                {
                    if (i == s.Length - 1 || i == s.Length - 2)
                    {
                        result.Append(lookup[new string(s[i], 1)]);
                    }
                    else
                    {
                        char next = s[i + 1];
                        char next_next = s[i + 2];

                        if (i == s.Length - 3 && next_next == '#')
                        {
                            i++;
                        }
                        else if (char.IsDigit(next) && char.IsDigit(next_next))
                        {
                            result.Append(lookup[new string(s[i], 1)]);
                        }
                    }
                }
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            string res1 = FreqAlphabets("10#11#12");
            string res2 = FreqAlphabets("1326#");
            string res3 = FreqAlphabets("25#");
            string res4 = FreqAlphabets("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#");
        }
    }
}
