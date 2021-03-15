using System;
using System.Collections.Generic;
using System.Text;

namespace goal_parser
{
    class Program
    {
        public static string Interpret(string command)
		{
			StringBuilder builder = new StringBuilder();

			Stack<char> stk = new Stack<char>();
			for (int i = 0; i < command.Length; i++)
			{
				if (command[i] == '(' && command[i + 1] == ')')
				{
					stk.Push('(');
				}
				else if (
					(command[i] == '(' && command[i + 1] != ')')
					|| (command[i] == ')' && command[i - 1] != '(')
				)
                {
					continue;
                }
				else if (stk.Count != 0 && command[i] == ')' && stk.Pop() == '(')
				{
					builder.Append('o');
				}
				else
				{
					builder.Append(command[i]);
				}
			}

			return builder.ToString();
		}

		static void Main(string[] args)
        {
            string res1 = Interpret("G()(al)");
            string res2 = Interpret("G()()()()(al)");
			string res3 = Interpret("(al)G(al)()()G");
        }
    }
}
