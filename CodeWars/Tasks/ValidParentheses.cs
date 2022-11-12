using System;
namespace CodeWars.Tasks
{
    public static partial class Tasks
    {
        public static bool ValidParentheses(string input)
        {
            var indent = 0;

            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') indent++;
                if (input[i] == ')') indent--;
            }

            return indent == 0;
        }
    }
}
