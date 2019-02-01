using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue<T> : IEmptyable, IPrintable, ICountable where T : IComparable<T>, IPrintable
    {
        public void Count()
        {
            throw new NotImplementedException();
        }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        //Print
        public void Print()
        {
            foreach (T t in queue)
            {
                t.Print();
            }
        }

        List<T> queue = new List<T>();

        ////EnQueue
        public void EnQueue(T val)
        {
            queue.Insert(0, val);
        }

        //DeQueue
        public T DeQueue()
        {
            // holds the number, then deletes the "top" or first number from the queue
            T temp = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return temp;
        }

        //Peek
        public T Peek()
        {
            return queue[queue.Count - 1];
        }
    }
}
