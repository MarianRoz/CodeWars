using System;
using System.Linq;

namespace CodeWars.Tasks

{
    /// <summary>
    /// https://www.codewars.com/kata/55caef80d691f65cb6000040/train/csharp
    /// </summary>
    public partial class Tasks
    {
        public static string GeometricSequenceElements(int a, int r, int n)
        {
            return string.Join(", ", Enumerable.Range(0, n).Select(i => Math.Pow(r, i) * a));
        }

    }
}

