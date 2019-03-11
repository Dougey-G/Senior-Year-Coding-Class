using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringSplosion_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string");
            string result = Console.ReadLine();

            for (int x = 0; x < result.Length; x++)
            {
                for (int y = 0; y < x + 1; y++)
                {
                    Console.Write(result[y]);
                }
            }
            Console.ReadLine();        
        }
    }

    
}
