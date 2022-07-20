using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_and_Backtracking
{
    class Program
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(SumRecursively(arr, 0));
        }
        private static int SumRecursively(int[] arr, int index)
        {
            if (index >= arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] + SumRecursively(arr, index + 1);
        }
        
    }
   
}
