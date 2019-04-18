using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class BinaryTreePrinter
    {
        public static void PrintNode(Node root)
        {
            int maxLevel = BinaryTreePrinter.MaxLevel(root);

            PrintNodeInternal(new List<Node>() { root }, 1, maxLevel);
        }

        private static void PrintNodeInternal(List<Node> nodes, int level, int maxLevel)
        {
            if (nodes.Count == 0 || BinaryTreePrinter.IsAllElementsNull(nodes))
                return;

            int floor = maxLevel - level;
            int endgeLines = (int)Math.Pow(2, (Math.Max(floor - 1, 0)));
            int firstSpaces = (int)Math.Pow(2, (floor)) - 1;
            int betweenSpaces = (int)Math.Pow(2, (floor + 1)) - 1;

            BinaryTreePrinter.PrintWhitespaces(firstSpaces);

            List<Node> newNodes = new List<Node>();
            foreach (var node in nodes)
            {
                if (node != null)
                {
                    Console.Write(node.Value);
                    newNodes.Add(node.LeftChild);
                    newNodes.Add(node.RightChild);
                }
                else
                {
                    newNodes.Add(null);
                    newNodes.Add(null);
                    Console.Write(" ");
                }

                BinaryTreePrinter.PrintWhitespaces(betweenSpaces);
            }
            Console.WriteLine("");

            for (int i = 1; i <= endgeLines; i++)
            {
                for (int j = 0; j < nodes.Count; j++)
                {
                    BinaryTreePrinter.PrintWhitespaces(firstSpaces - i);
                    if (nodes[j] == null)
                    {
                        BinaryTreePrinter.PrintWhitespaces(endgeLines + endgeLines + i + 1);
                        continue;
                    }

                    if (nodes[j].LeftChild != null)
                        Console.Write("/");
                    else
                        BinaryTreePrinter.PrintWhitespaces(1);

                    BinaryTreePrinter.PrintWhitespaces(i + i - 1);

                    if (nodes[j].RightChild != null)
                        Console.Write("\\");
                    else
                        BinaryTreePrinter.PrintWhitespaces(1);

                    BinaryTreePrinter.PrintWhitespaces(endgeLines + endgeLines - i);
                }

                Console.WriteLine("");
            }

            PrintNodeInternal(newNodes, level + 1, maxLevel);
        }

        private static void PrintWhitespaces(int count)
        {
            for (int i = 0; i < count; i++)
                Console.Write(" ");
        }

        private static int MaxLevel(Node node)
        {
            if (node == null)
                return 0;

            return Math.Max(BinaryTreePrinter.MaxLevel(node.LeftChild), BinaryTreePrinter.MaxLevel(node.RightChild)) + 1;
        }

        private static bool IsAllElementsNull(List<Node> list)
        {
            foreach (var node in list)
            {
                if (node != null)
                    return false;
            }
            return true;
        }
    }
}
