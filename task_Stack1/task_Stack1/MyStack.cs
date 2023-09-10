using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Stack1
{
    internal class MyStack<T>
    {
        T[] data;
        int capacity;
        int counter = 0;

        public int Capacity
        {
            get { return capacity; }
        }
        public int Count
        {
            get { return counter; }
        }
        public MyStack(int cap)
        {
            this.data = new T[cap];
            capacity = cap;
            counter = 0;
        }
        internal void Push(T item)
        {
            if (counter != capacity)
            { data[counter++] = item; }
            else
            {
                throw new IndexOutOfRangeException();
            }

        }
        internal T Pop()
        {
            if (counter != 0)
            {
                return data[--counter];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }


        }
        internal T Peek()
        {
            if (counter != 0)
            {
                return data[counter - 1];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}
