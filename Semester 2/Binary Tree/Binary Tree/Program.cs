using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Console.ReadLine();
            //Console.WriteLine("1. Insert");
            //Console.WriteLine("2. Search");
            //Console.WriteLine("3. Print");
            //Console.WriteLine("4. Random");

            //if (result == "1")
            //{
                BinaryTree newtree = new BinaryTree();
                newtree.Insert('a');
                newtree.Insert('b');
                newtree.Insert('c');
                newtree.Insert('d');

                newtree.Print();
            //}
            

        }
    }
}
