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
            var n = int.Parse(Console.ReadLine());



            Console.WriteLine(CalkFactorial(n));
        }
        private static int CalkFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * CalkFactorial(n - 1);
        }

    }

}

