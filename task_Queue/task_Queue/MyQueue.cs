using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Queue
{
    internal class MyQueue<T>
    {
        int ind_add = 0;
        int ind_remove = 0;
        int counter = 0;
        int capacity;
        T[] data;
        

        public MyQueue(int capacity)
        {
            this.capacity = capacity;
            data = new T[capacity];
        }
        public int Capacity
        {
            get { return capacity; }
        }
        public int Count
        {
            get { return counter; }
        }
        internal void Enqueue(T item)
        {
            if (counter == capacity) { throw new IndexOutOfRangeException();  }
            data[ind_add] = item;
            ind_add = (ind_add + 1) % data.Length;

            //Console.WriteLine(ind_add);
            counter++;
        }
        internal T Decueue()
        {
            if (counter == 0) { throw new IndexOutOfRangeException(); }
            T item = data[ind_remove];

            data[ind_remove] = default(T);
            Console.WriteLine(data[ind_remove] + "R");
            ind_remove = (ind_remove + 1) % data.Length;
            counter--;
            return item;
        }

        internal T[] Values()
        {
            T[] arr = new T[this.Count];
            if (ind_add  > ind_remove)
            {
                Console.WriteLine(this.Count + "C");
                for (int i = 0; i < this.Count; i++)
                {
                    arr[i] =  data[ind_remove + i];
                }
            }
            else
            {
                int me = 0;
                for (int i = 0; i < this.Capacity - ind_remove; i++)
                {
                    try
                    {
                        arr[i] = data[i + ind_remove];
                        me = i;
                    }
                    catch (IndexOutOfRangeException) { return null; }
                }
                me++;
                Console.WriteLine(me + "me");
                for (int i = me; i < this.Count; i++)
                {
                    arr[i] = data[i - me];
                }
            }
            return arr;
        }
        internal bool IsEmpty()
        {
            if (counter == 0) { return true; }
            return false; 
        }

        internal T First()
        {
            if (!IsEmpty()) return data[ind_remove];
            throw new IndexOutOfRangeException(); 
        }

        internal T Last()
        {
            Console.WriteLine(IsEmpty());
            if (!IsEmpty())
            {
                if (ind_add != 0) { return data[ind_add - 1]; }
                else { return data[Count - 1]; }
            }
            throw new IndexOutOfRangeException();
        }
    }
}
