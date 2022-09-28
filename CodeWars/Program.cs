using System;
using CodeWars.Tasks;

namespace CodeWars.Tasks
{
    public partial class Tasks
    {
        public static void Main(string[] args)
        {

            foreach (var item in Tasks.BubbleSortOnceResolve(new int[] { 10, 7, 5, 3, 1, 2, 4, 6, 8, 9 }))
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();


            Console.WriteLine(Tasks.MaxResolve(new int[] { 1, 5, 3, 9, 7 }));
            Console.ReadLine();


            int a = 2, r = 4, n = 5;
            Console.WriteLine($"Result: {GeometricSequenceElements(a, r, n)}");


            int start = 1; int finish = 6;
            Cats(start, finish);
            

        }
    }
}