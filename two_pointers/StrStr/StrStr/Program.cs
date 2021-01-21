using System;

namespace StrStr
{
    class Program
    {
        public static int StrStr(string haystack, string needle)
        {
            if (haystack == null || needle == null)
            {
                return -1;
            }

            if (haystack == string.Empty && needle == string.Empty)
            {
                return 0;
            }

            int len = haystack.Length - needle.Length;
            for (int i = 0; i <= len; i++)
            {
                int j = 0;
                while (j < needle.Length)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else
                    {
                        j += 1;
                    }
                }

                if (j == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";

            int idx1 = StrStr(haystack, needle);
        }
    }
}
