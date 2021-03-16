using System;
using System.Collections;
using System.Collections.Generic;

namespace ShuffleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r1 = new Random();

            int Length = r1.Next(10, 100);

            List<int> arr = new List<int>();
            for(int i=0;i<Length;i++)
            {
                arr.Add(i);
            }
            outArr(ref arr);
            for(int i=0;i<arr.Count;i++)
            {
                int ex = r1.Next(0, arr.Count - 1);

                int tmp = arr[i];
                arr[i] = arr[ex];
                arr[ex] = tmp;
            }
            outArr(ref arr);
        }

        static void outArr(ref List<int> outPut)
        {
            foreach (int i in outPut)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
