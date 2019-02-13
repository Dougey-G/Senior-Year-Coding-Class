using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_to_LINQ_and_Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> L1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            //List<int> L2 = new List<int>() { 3, 2, 2, 8, 0, 4, 7 };
            //List<int> L3 = new List<int>();

            //l3 = l2.Intersect(L1).ToList();
            //foreach(int i in L3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            List<int> L1 = new List<int>() { 8, 6, 7, 5, 3, 0, 9 };
            List<int> L2 = new List<int>();

            L2 = L1.Where(>= t - 2 == 0).ToList();

            foreach(int i in L2)
            {
                Console.WriteLine(i + ", ");
            }
            Console.ReadLine();
        }
    }
}
