using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P0004 : IProblemSolver
    {
        static bool _isPalindrome(ulong n)
        {
            var origStr = n.ToString();
            return new string(origStr.Reverse().ToArray()) == origStr;
        }

        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        ///What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public void Run()
        {
            ulong max = 0;

            for (ulong i = 999; i > 0; --i)
            {
                for (ulong j = i; j > 0; --j)
                {
                    ulong prod = i * j;

                    if (_isPalindrome(prod))
                    {
                        Console.WriteLine("palindrome  {0}", prod);
                        if (prod > max)
                            max = prod;
                        break;
                    }
                }
                if ((i % 100) == 0)
                    Console.WriteLine("{0}", i);
            }
            Console.WriteLine("Solution is {0}", max);
            Console.ReadKey();
            // Ok
        }
    }
}
