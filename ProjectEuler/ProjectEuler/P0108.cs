using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P0108
{
    class Fract
    {
        public long A;
        public long B;
        public Fract(long a, long b)
        {
            A = a;
            B = b;
        }

        public void Mult(long a)
        {
            A *= a;
            B *= a;
        }

        public bool IsReducible()
        {
            return IsDivisible(B, A);
        }

        public Fract Minus(Fract r)
        {
            if (B != r.B)
                throw new Exception();
            return new Fract(A - r.A, B);
        }

        public static bool IsDivisible(long a, long b)
        {
            return (a % b) == 0;
        }
    }

    class P0108 : IProblemSolver
    {
        public static int GetSolutionCount(long n, long nPassStop)
        {
            int solCnt = 1;
            long failed = 0;
            for (long i = n + 1; i < n * 2; ++i)
            {
                Fract A = new Fract(n, n * i);
                Fract B = new Fract(i, n * i);
                var res = B.Minus(A);
                //failed++;
                if (res.IsReducible())
                {
                    solCnt++;
                    //failed = 0;
                }
                //if (failed > (n*nPassStop))
                //    return -solCnt;
            }

            return solCnt;
        }
        public void Run()
        {
            long n = 2;
            long max = 0;
            long maxN = 0;
            //Parallel.For((long)2000000, long.MaxValue, (n, stop) =>
            while (true)
            {
                var solCnt = GetSolutionCount((long)n, 1000);

                if (max == 0 || solCnt > max)
                {
                    max = solCnt;
                    maxN = n;
                }
                if ((n % 100) == 0)
                    Console.WriteLine("For 1/{0} : {1}\t solutions best 1/{2} : {3}", n, solCnt, maxN, max);

                if (solCnt > 1000)
                {
                    Console.WriteLine("For 1/{0} : {1} solutions", n, solCnt);
                    Console.WriteLine("SolutionFound");
                    //stop.Stop();
                    break;
                }
                ++n;
            }//);
            Console.ReadKey();
            // Ok
        }
    }
}
