using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;

            Queue<Currencies> myQueue = new Queue<Currencies>();
            do
            {
                Console.WriteLine("1. EnQueue");
                Console.WriteLine("2. DeQueue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Print");
                Console.WriteLine("5. Exit");

                result = Console.ReadLine();

                if (result == "1")
                {
                    Console.WriteLine("Please enter number you would like to add.");
                    myQueue.EnQueue(new Currencies(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    Console.WriteLine();
                }

                if (result == "2")
                {
                    int Popval = myQueue.DeQueue();
                    Console.WriteLine("The top number in the queue is a " + Popval);
                    Console.WriteLine();
                }

                if (result == "3")
                {
                    Console.WriteLine("The top value of the queue is " + myQueue.Peek());
                    Console.WriteLine();
                }

                if (result == "4")
                {
                    myQueue.Print();
                    Console.WriteLine();
                }
            } while (result != "5");
        }
    }
}
