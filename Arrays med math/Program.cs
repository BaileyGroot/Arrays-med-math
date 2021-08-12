using System;
using System.Collections.Generic;
using System.Linq;

namespace Arrays_med_math
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listeB = new List<int>();

            for (int i = 2; i <= 20; i = i + 2)
            {
                listeB.Add(i);
            }
            PrintList(listeB, "Just created the list");

            int index = 0;
            while(true)
            {
                if (listeB[index] % 3 == 0)
                {
                    listeB.RemoveAt(index);
                }
                else
                {
                    index++;
                }
                if (index >= listeB.Count) break;
             }

            PrintList(listeB, "After removing those that mod 3");
            listeB[3] = 17;

            PrintList(listeB, "After changing pos 4");


            listeB.Reverse();

            PrintList(listeB, "After Reverse");
            Console.ReadLine();
        }

        static void PrintList(List<int> list, string label)
        {
            Console.WriteLine(label);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
