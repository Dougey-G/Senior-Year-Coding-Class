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
            BinaryTree tree = new BinaryTree();
            string result;
            do
            {
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Search");
                Console.WriteLine("3. Remove");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. PreOrderPrint");
                Console.WriteLine("6. InOrderPrint");
                Console.WriteLine("7. PostOrderPrint");
                Console.WriteLine("8. Exit");
                result = Console.ReadLine();

                if (result == "1")
                {
                    Console.WriteLine("what do you want to insert?");
                    char inserted = char.Parse(Console.ReadLine());
                    tree.Insert(inserted);
                    Console.WriteLine();
                }

                if (result == "2")
                {
                    Console.WriteLine("What letter do you want to search for?");
                    char Searched = char.Parse(Console.ReadLine());
                    if (tree.Search(Searched) == false)
                    {
                        Console.WriteLine("Sorry, the letter doesn't exist.");
                    }

                    if (tree.Search(Searched) == true)
                    {
                        Console.WriteLine("Yay, " + Searched + " exists");
                    }
                    tree.Search(Searched);
                }

                if (result == "3")
                {
                    Console.WriteLine("What letter do you want to remove?");
                    tree.Remove(char.Parse(Console.ReadLine()));
                    Console.WriteLine();
                }

                if (result == "4")
                {
                    tree.Print();
                }

                if (result == "5")
                {
                    tree.PreOrderPrint();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (result == "6")
                {
                    tree.InOrderPrint();
                    Console.WriteLine();
                    Console.WriteLine();
                }

                if (result == "7")
                {
                    tree.PostOrderPrint();
                    Console.WriteLine();
                    Console.WriteLine();
                }

            } while (result != "8");
        }
    }
}
