using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.P0025
{
    public class TreeNode
    {
        public TreeNode Left;
        public TreeNode Right;

        public string Value;
    }

    class P0025 : IProblemSolver
    {
        LinkedList<TreeNode> getNextLevelParents(LinkedList<TreeNode> nodes)
        {
            LinkedList<TreeNode> nextLvl = new LinkedList<TreeNode>();
            foreach (var node in nodes)
            {

            }
            return nextLvl;
        }

        TreeNode breadthFirstSearch(TreeNode head, Func<string, bool> comparison)
        {
            if (head == null)
                return null;
            LinkedList<TreeNode> curParents = new LinkedList<TreeNode>();

            curParents.AddLast(head);
            while (curParents.Count > 0)
            {
                LinkedList<TreeNode> nextLvl = new LinkedList<TreeNode>();

                foreach (var parent in curParents)
                {
                    Console.WriteLine(parent.Value);
                    if (comparison(parent.Value))
                        return parent;

                    if (parent.Left != null)
                        nextLvl.AddLast(parent.Left);
                    if (parent.Right != null)
                        nextLvl.AddLast(parent.Right);
                }
                curParents = nextLvl;
            }
            return null;
        }


        static int _countDigits(string s)
        {
            return s.Length;
        }

        public void Run()
        {
            TreeNode nodeA = new TreeNode();
            TreeNode nodeB = new TreeNode();
            TreeNode nodeC = new TreeNode();
            TreeNode nodeD = new TreeNode();
            TreeNode nodeE = new TreeNode();
            TreeNode nodeF = new TreeNode();
            TreeNode nodeG = new TreeNode();

            nodeA.Value = "A";
            nodeB.Value = "B";
            nodeC.Value = "C";
            nodeD.Value = "D";
            nodeE.Value = "E";
            nodeF.Value = "F";
            nodeG.Value = "G";

            nodeA.Left = nodeB;
            nodeA.Right = nodeC;

            nodeB.Left = nodeD;
            nodeB.Right = nodeE;


            nodeC.Left = nodeF;
            nodeC.Right = nodeG;


            var ret = breadthFirstSearch(nodeA, (s) => { return s == "z"; });
            Console.WriteLine(ret==null);
            Console.ReadKey();
            return;

            BigInteger lastI = new BigInteger(1);
            BigInteger curI = new BigInteger(1);
            int i = 3;
            while (true)
            {
                var saveLastI = curI;
                curI = curI + lastI;
                lastI = saveLastI;
                int count = _countDigits(curI.ToString());
                if ((i % 1000) == 0)
                    Console.WriteLine("{0} {1}", i, count);
                if (count > 100000000)
                {
                    Console.WriteLine("Solution is {0} {1}", i, curI.ToString());
                    break;
                }
                i++;
            }
            Console.ReadKey();
            // Ok
        }
    }
}
