using System;
using CodeWars.Tasks;

namespace BubblesortOnce
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in BubbleSortOnce.BubbleSortOnceResolve(new int[] { 10, 7, 5, 3, 1, 2, 4, 6, 8, 9 }))
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();

        }
    }
}
//CodeWars