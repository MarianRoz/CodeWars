using System;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/62c93765cef6f10030dfa92b/csharp
    /// </summary>
    public partial class Tasks
    {
        public static int WhiteCats(int start, int finish)
        {
            int result;
            int division = (finish - start) / 3;
            int remainderFromDivision = (finish - start) % 3;

            return result = (remainderFromDivision == 0) ? division : ((remainderFromDivision == 1) ? division += 1 : division += 2);
        }
    }
}
