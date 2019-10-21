using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class P0005 : IProblemSolver
    {
        static bool _divisibleBy1To20(ulong n)
        {
            for (ulong i = 2; i < 21; ++i)
            {
                if ((n % i) != 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        ///What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public void Run()
        {
            ulong i = 1;

            while (true)
            {
                bool res = _divisibleBy1To20(i);
                //if ((i%100000)==0)
                //    Console.WriteLine("Testing {0} : {1}", i, res);
                if (res)
                    break;
                ++i;
            }
            Console.WriteLine("Solution is {0}", i);
            Console.ReadKey();
            // Ok
        }
    }
}
