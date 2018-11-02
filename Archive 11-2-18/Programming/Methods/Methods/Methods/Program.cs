using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            bool done = false;
            while (done == false)
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("1. Add 5+6");
                Console.WriteLine("2. Add 11+3");
                Console.WriteLine("3. Add 3+9");
                Console.WriteLine("4. Exit program.");
                Console.WriteLine("*******************************************");
                string result = Console.ReadLine();


                if (result == "1")
                {
                    Console.WriteLine();
                    Add5plus6();
                }
                else if (result == "2")
                {
                    Console.WriteLine();
                    Add11plus3();
                }
                else if (result == "3")
                {
                    Console.WriteLine();
                    Add3plus9();
                }

                else if (result == "4")
                {
                    Console.WriteLine("Ok, Good Bye.");
                    done = true;
                }
            }
        }
        static void Add5plus6()
        {
            Console.WriteLine(5 + 6);
        }
        static void Add11plus3()
        {
            Console.WriteLine(11 + 3);
        }
        static void Add3plus9()
        {
            Console.WriteLine(3 + 9);
        }
    }
}

