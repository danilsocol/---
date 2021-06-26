using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Больше_делегатов
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,0
            };
            
            Taimer(list, cycleFor);
            Taimer(list, cycleForeach);
            Taimer(list, cycleWhile);

        }

        static void Taimer(List<int> list,Action<List<int>> f)
        {
            var watch = new Stopwatch();
            watch.Start();
            f(list);
            watch.Stop();
        }
        static void cycleFor(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += 1;
            }
        }
        static void cycleForeach(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void cycleWhile(List<int> list)
        {
            int i = 0;
            while (i == list.Count - 1)
            {
                list[i] += 100;
                i++;
            }
        }
    }
}

