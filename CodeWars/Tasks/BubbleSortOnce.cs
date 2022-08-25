using System;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/56b97b776ffcea598a0006f2/train/csharp
    /// </summary>
    public static class BubbleSortOnce
    {
        public static int[] BubbleSortOnceResolve(int[] input)
        {

            int[] newArray = new int[input.Length];
            Array.Copy(input, newArray, input.Length);
            // Code the Bubblesort Algorithm here :D
            for (int i = 0; i < input.Length; i++)
            {
                for (int e = 0; e < input.Length - 1; e++)
                {
                    if (input[e] > input[e + 1])
                    {
                        var temp = input[e];
                        input[e] = input[e + 1];
                        input[e + 1] = temp;
                    }
                }
            }
            return input;
        }
    }
}