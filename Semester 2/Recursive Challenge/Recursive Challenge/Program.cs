using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursive_Challenge
{
    class Program
    {
        static Random rand = new Random(1234);
        static void Main(string[] args)
        {
            List<int> integers = new List<int>();
            for (int i = 0; i < 1000; i++)
                integers.Add(rand.Next(0, 1000));
            integers.Sort();
            bool result = SearchIntList(integers, 0);
        }

        //Helper function that makes it easier to call
        public static bool SearchIntList(List<int> integers, int n)
        {
            // return a call to SearchIntListRecursive that starts at a specific index.
            return SearchIntListRecursive(integers, n, 0, integers.Count - 1);
        }

        public static bool SearchIntListRecursive(List<int> integers, int n, int lowerBound, int upperBound)
        {
            //If the lowerbound are upperbound are the same thing, return false

            //Store the midpoint between lowerbound and upperbound

            //If the integer at index is equal to n, we can return true because we found n!

            //If the upperbound and lowerbound are 1 unit apart, return false

            //If the integers at index is greater than n, we know n will be to the left
                //Return the recursive call but modify bounds to ignore everything > index

            //If the integer is at index is less than n, we know that n will be to the right
                //Return the recursive call but modify bounds to ignore everything < index

            //We haven't found it, return false
            return false;
        }
    }
}

