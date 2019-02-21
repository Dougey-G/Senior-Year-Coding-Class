using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringTimes_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(stringTimes("Hi", 2));
            Console.WriteLine(stringTimes("Hi", 3));
            Console.WriteLine(stringTimes("Hi", 1));
            Console.ReadLine();
        }

        static public string stringTimes(string Word, int Times)
        {
            string times = "";

            for (int i = 0; i < Times; i++)
            {
                times += Word;
            }
            return times;
        }
    }
}