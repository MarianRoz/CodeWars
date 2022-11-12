using System;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/62c93765cef6f10030dfa92b/csharp
    /// </summary>
    public static partial class Tasks
    {
        public static int Cats(int start, int finish)
        {

            int way = 0;

            for (int i = start; i < finish; )
            {
                
                if (i <= finish && (i + 3 == finish))
                {
                    way += 1;
                    i += 3;
                }

                if (i <= finish && (i + 2 == finish))
                {
                    way += 2;
                    i += 3;
                }

                if (i <= finish && (i + 1 == finish))
                {
                    way += 1;
                    i += 3;
                }

                if (i < finish)
                {
                    way += 1;
                    i += 3;
                }
            }

            return way;

        }
    }
}
