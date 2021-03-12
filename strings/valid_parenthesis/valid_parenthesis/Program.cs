using System;
using System.Collections.Generic;
using System.Linq;

namespace valid_parenthesis
{
    class Program
    {
        public static bool IsValid(string s)
        {
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char currentToken = s[i];
                bool isOpening = (currentToken == '(' || currentToken == '[' || currentToken == '{');
                bool isClosing = (currentToken == ')' || currentToken == ']' || currentToken == '}');

                // Edge case for closing paren
                if (isClosing && stk.Count == 0)
                {
                    return false;
                }

                if (isOpening)
                {
                    stk.Push(currentToken);
                }

                else if (isClosing)
                {
                    char top = stk.Peek();
                    if (currentToken == ')' && top != '(')
                    {
                        return false;
                    }

                    if (currentToken == ']' && top != '[')
                    {
                        return false;
                    }

                    if (currentToken == '}' && top != '{')
                    {
                        return false;
                    }

                    stk.Pop();
                }
            }

            return stk.Count == 0;
        }

        static void Main(string[] args)
        {
            bool res1 = IsValid("(]");
            bool res2 = IsValid("]");
        }
    }
}
