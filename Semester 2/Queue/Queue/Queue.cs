using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        
        List<int> holder = new List<int>();

        public Queue()
        {

        }

        //EnQueue
        public void EnQueue(int val)
        {
            holder.Add(val);
        }

        //DeQueue
        public int DeQueue()
        {
            // holds the number, then deletes the "top" or first number from the queue
            int Top = holder[0];
            holder.RemoveAt(0);

            return Top;
        }

        //Peek
        public int Peek()
        {
            int Top = holder[0];
            return Top;
        }

        //Print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.WriteLine("The queue currently has " + holder[i]);
            }
        }
    }
}
