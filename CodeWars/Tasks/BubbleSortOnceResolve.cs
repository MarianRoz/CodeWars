using System;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/56b97b776ffcea598a0006f2/train/csharp
    /// </summary>
    public static partial class Tasks
    {
        public static int[] BubbleSortOnceResolve(int[] input)
        {
            int[] newArray = new int[input.Length];
            Array.Copy(input, newArray, input.Length);
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] > input[i + 1])
                {
                    var temp = input[i];
                    input[i] = input[i + 1];
                    input[i + 1] = temp;
                }
            }
            return input;
        }
    }
}