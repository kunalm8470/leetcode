using System;

namespace maximum_nesting_depth_of_the_parentheses
{
    class Program
    {
        /// <summary>
        /// https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int MaxDepth(string s)
        {
            if (string.IsNullOrEmpty(s) || s == "1") return 0;

            int depth = 0;
            int openParens = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') openParens++;
                else if (s[i] == ')') openParens--;
                depth = Math.Max(depth, openParens);
            }

            return depth;
        }

        static void Main(string[] args)
        {
            int res1 = MaxDepth("()()");
            int res2 = MaxDepth("()(()())");
            int res3 = MaxDepth("");
            int res4 = MaxDepth("1");
            int res5 = MaxDepth("(1+(2*3)+((8)/4))+1");
            int res6 = MaxDepth("(1)+((2))+(((3)))");
            int res7 = MaxDepth("1+(2*3)/(2-1)");
        }
    }
}
