using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringBits_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string result = Console.ReadLine();

            for (int x = 0; x < result.Length; x++)
            {
                if(x % 2  == 0)
                {
                    Console.Write(result[x]);
                }
            }
            Console.ReadLine();
        }
    }
}
