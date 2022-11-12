using System;
namespace CodeWars.Tasks
{
    public static partial class Tasks
    {
        public static int[] BubbleSortAlgorithm(int[] input)
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