using System;

namespace reverse_string_array
{
    class Program
    {
        public static void ReverseString(string[] s)
        {
            int i = 0, length = s.Length;
            while (i < (length / 2))
            {
                string temp = s[i];
                s[i] = s[length - 1 - i];
                s[length - 1 - i] = temp;
                i += 1;
            }
        }
        static void Main(string[] args)
        {
            string[] inp1 = { "h","e","l","l","o" };
            ReverseString(inp1);
        }
    }
}
