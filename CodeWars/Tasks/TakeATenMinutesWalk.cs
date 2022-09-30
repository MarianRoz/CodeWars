using System;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/54da539698b8a2ad76000228
    /// </summary>
    public partial class Tasks
    {
        public static bool IsValidWalk(string[] walk)
        {
            int n=0, s=0, w=0, e=0;
            bool result;

            for (int i = 0; i < walk.Length; i++)
            {
                switch (walk[i])
                {
                    case "n":
                        n++;
                        break;
                    case "s":
                        s++;
                        break;
                    case "w":
                        w++;
                        break;
                    case "e":
                        e++;
                        break;
                }
            }
            return result = (n == s && w == e && walk.Length==10) ? true : false;
        }
    }
}