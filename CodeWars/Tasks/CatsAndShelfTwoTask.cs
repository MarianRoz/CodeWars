using System;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/62c93765cef6f10030dfa92b/csharp
    /// </summary>
    public partial class Tasks
    {
        public static int CatsTwoTask(int start, int finish)
        {
            int Result;
            int Division = (finish - start) / 3;
            int RemainderFromDivision = (finish - start) % 3;

            return Result = (RemainderFromDivision == 0) ? Division : ((RemainderFromDivision == 1) ? Division += 1 : Division += 2);
        }
    }
}
