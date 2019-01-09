using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string result;
                
            Stack myStack = new Stack();
            do
            { 
            Console.WriteLine("1. Push");
            Console.WriteLine("2. Pop");
            Console.WriteLine("3. Peek");
            Console.WriteLine("4. Print");
            Console.WriteLine("5. Exit");

            result = Console.ReadLine();
            
                if (result == "1")
                {
                    Console.WriteLine("Please enter number you would like to add.");
                    int Add = int.Parse(Console.ReadLine());
                    myStack.Push(Add);
                    Console.WriteLine();
                }

                if (result == "2")
                {
                    int Popval = myStack.Pop();
                    Console.WriteLine("The top number in the stack is a " + Popval);
                    Console.WriteLine();
                }

                if (result == "3")
                {
                    Console.WriteLine("The top value of the stack is " + myStack.Peek());
                    Console.WriteLine();
                }

                if (result == "4")
                {
                    myStack.Print();
                    Console.WriteLine();
                }
            } while (result != "5");
            
        }
    }
}