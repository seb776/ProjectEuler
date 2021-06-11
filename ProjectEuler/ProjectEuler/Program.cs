using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            IProblemSolver solver = new P0025.P0025();

            solver.Run();
        }
    }
}
