using System;
using System.Linq;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
          int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int panichka = 0;
            int len = arr.Length;
            for (int i = 0; i < arr.Length/2; i++)
            {
                panichka = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = panichka;
            }

         Console.WriteLine(String.Join("; ", arr)); 


        }
    }
}
