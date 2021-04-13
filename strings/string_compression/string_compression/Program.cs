using System;
using System.Collections.Generic;

namespace string_compression
{
    class Program
    {
        public static int Compress(char[] chars)
        {
            List<(char, int)> groups = new List<(char, int)>();

            int cnt = 1;
            char currentChar = chars[0];
            for (int i = 1; i < chars.Length; i++)
            {
                if (chars[i - 1] == chars[i])
                {
                    cnt++;
                }
                else
                {
                    groups.Add((currentChar, cnt));
                    cnt = 1;
                    currentChar = chars[i];
                }
            }
            groups.Add((currentChar, cnt));

            if (groups.Count == 1 && groups[0].Item2 == 1) return 1;

            List<char> res = new List<char>();
            for (int i = 0; i < groups.Count; i++)
            {
                res.Add(groups[i].Item1);
                char[] temp = groups[i].Item2.ToString().ToCharArray();
                if (temp.Length == 1 && temp[0] == '1')
                {
                    continue;
                }

                res.AddRange(temp);
            }

            for (int i = 0; i < res.Count; i++)
            {
                chars[i] = res[i];
            }

            return res.Count;
        }

        static void Main(string[] args)
        {
            char[] c1 =  { 'a', 'a', 'b', 'b', 'c', 'c', 'c' };
            int res1 = Compress(c1);

            char[] c2 = { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' };
            int res2 = Compress(c2);
        }
    }
}
