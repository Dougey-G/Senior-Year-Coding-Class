using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        List<int> holder = new List<int>();

        public Stack()
        {
           
        }

        //Push
        public void Push(int val)
        {
            holder.Add(val);
        }

        //Pop
        public int Pop()
        {
            // holds the number, then deletes the "top" or first number from the stack
            int Top = holder[holder.Count - 1];
            holder.RemoveAt(holder.Count - 1);

            return Top;
        }

        //Peek
        public int Peek()
        {
            int Top = holder[holder.Count - 1];
            return Top;
        }
    
        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++) 
            {
                Console.WriteLine("The stack currently has " + holder[i]);
            }
        }
    }
}
