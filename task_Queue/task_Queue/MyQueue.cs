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
        T[] data;
        

        public MyQueue(int capacity)
        {
            data = new T[capacity];
        }
        public int Capacity
        {
            get { return data.Length; }
        }
        public int Count
        {
            get { return counter; }
        }
        internal void Enqueue(T item)
        {
            if (counter == this.Capacity) 
            {
                throw new IndexOutOfRangeException(); 
            }
            data[ind_add] = item;
            ind_add = (ind_add + 1) % data.Length;

            counter++;
        }
        internal T Decueue()
        {
            if (counter == 0) 
            { 
                throw new IndexOutOfRangeException(); 
            }
            T item = data[ind_remove];

            ind_remove = (ind_remove + 1) % data.Length;
            counter--;
            return item;
        }

        internal T[] Values()
        {
            T[] arr = new T[this.Count];
            if (ind_add  > ind_remove)
            {
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
                for (int i = me; i < this.Count; i++)
                {
                    arr[i] = data[i - me];
                }
            }
            return arr;
        }
        internal bool IsEmpty
        {
            get
            {
                if (counter == 0)  return true;     
                else return false;
            }
            
        }

        internal T First()
        {
            if (!this.IsEmpty) return data[ind_remove];
            throw new IndexOutOfRangeException(); 
        }

        internal T Last()
        {
            
            if (!this.IsEmpty)
            {
                if (ind_add != 0) return data[ind_add - 1]; 
                else  return data[Count - 1]; 
            }
            throw new IndexOutOfRangeException();
        }
    }
}
