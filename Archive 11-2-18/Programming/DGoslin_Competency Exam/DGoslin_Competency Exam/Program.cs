using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGoslin_Competency_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while (done == false)
            //int i = 0;
            //i = 0;
            {
                Console.WriteLine("********************************");
                Console.WriteLine("1. Conditionals");
                Console.WriteLine("2. For Loops");
                Console.WriteLine("3. While Loops");
                Console.WriteLine("4. Arrays");
                Console.WriteLine("5. Lists");
                Console.WriteLine("-1. Exit");
                Console.WriteLine("********************************");
                string result = Console.ReadLine();
                int input = 0;
                //input = int.Parse(Console.ReadLine());

                int gradeLevel;
                int readingProficiencyLevel;
                
                // int[] ReProLv = readingProficiencyLevel

                // Conditionals
                if (result == "1")
                {
                    Console.WriteLine("What is your grade?");
                     gradeLevel = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is your reading level?");
                    readingProficiencyLevel = int.Parse(Console.ReadLine());
                    //int.Parse();
                    // gradeLevel = new
                    // readingProficiencyLevel() = new

                    //if (gradeLevel <= readingProficiencyLevel);
                }
                //input = 

                // For Loops (* by N number)
                if (result == "2")
                {
                    int i = 0;
                    Console.WriteLine();
                    Multiplyiand3();
                    // Multiply by n*3
                }

                // While loops
                if (result == "3")
                {
                    while (input != 0)
                    {
                        int.Parse(Console.ReadLine());

                    }
                    do
                    {
                        input = 0;
                        Console.WriteLine("Your final count is " + input);
                    } while (input != 0);
                }


                // Arrays
                if (result == "4")
                {
                    int[] ints = new int[10];
                    //n = number.input(n + n + n + n + n); etc) 
                    for (int.Parse(Console.ReadLine()); ;) ;

                }

                // Lists
                if (result == "5")
                {
                    List<string> myInput = new List<string>();
                    do
                    {
                        //input = something kind of like int.Parse(Console.ReadLine();, 
                        myInput.Add(Console.ReadLine());
                        // Console.WriteLine(myInput);
                    } while (myInput[myInput.Count-1]!= "end");
                }

                if (result == "-1")
                {
                    Console.WriteLine("Ok, Good Bye.");
                    done = true;
                }
            }
        }

        static void Multiplyiand3()
        {
            //Console.WriteLine(i * 6);
        }
        static void Add1and2()
        {
            Console.WriteLine(1 + 2);
        }
        static void Add2and3()
        {
            Console.WriteLine(2 + 3);
        }
        static void Add3and4()
        {
            Console.WriteLine(3 + 4);
        }
        static void Add4and5()
        {
            Console.WriteLine(1 + 2);
        }
        static void Add5and4()
        {
            Console.WriteLine(1 + 2);
        }

    }
}