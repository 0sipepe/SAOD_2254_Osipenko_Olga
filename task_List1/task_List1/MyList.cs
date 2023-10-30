using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task_List
{
    internal class MyList<T> : IEnumerable
    {
        MyListNode first;
        MyListNode current;
        int Size = 0;

        MyListNode First
        {
            get { return first; }
            set { first = value; }
        }
        MyListNode Current
        {
            get { return current; }
            set { current = value; }
        }

        public void Append(T item)
        {
            MyListNode node = new MyListNode(item);
            if (Size++ == 0)
            {
                First = node;
                Current = node;
            }
            else
            {
                node.Prev = current;
                Current.Next = node;
                Current = node;
            }

        }
        public void Prepend(T item)
        {
            MyListNode node = new MyListNode(item);
            if (Size++ == 0)
            {
                First = node;
                Current = node;
            }
            else
            {
                First.Prev = node;
                node.Next = First;
                First = node;
            }
        }
        public void Insert(int index, T val)
        {
            if ((index <= Size) && (index >= 0))
            {
                MyListNode tmp = First;
                for (int i = 0; i < index - 1; i++)
                {
                    tmp = tmp.Next;
                }
                MyListNode node = new MyListNode(val, tmp, tmp.Next);
                tmp.Next.Prev = node;
                tmp.Next = node;
                Size++;
            }
            else
            {
                throw new Exception("index out of range");
            }
            

        }
        
        
        public void SetValue(int index, T value)
        {
            if ((index <= Size) && (index >= 0))
            {
                this[index].Value = value;
            }
            else
            {
                throw new Exception("wrong input");
            }
            
        }
        public int Find(T value)
        {
            MyListNode tmp = First;
            for (int i = 0; i < Size; i++)
            {
                if (tmp.Value.Equals(value))
                {
                    return i;
                }
                tmp = tmp.Next;
            }
            throw new Exception("no such value");
        }

        public T FindAt(int index)
        {
            if ((index <= Size) && (index >= 0))
            {
                return this[index].Value;
            }
            throw new Exception("out of range");
                
        }

        public void Remove(T value)
        {
            MyListNode tmp = First;
            if (this.Contains(value))
            {
                for (int i = 0; i < Size; i++)
                {
                    if (tmp.Value.Equals(value))
                    {
                        if (tmp == First && tmp == Current)
                        {
                            First = null;
                            Current = null;
                        }
                        else if (tmp == First)
                        {
                            First = tmp.Next;
                            First.Prev = null;
                        }
                        else if (tmp == Current)
                        {
                            Current = tmp.Prev;
                            Current.Next = null;
                        }
                        
                        else
                        {
                            tmp.Prev.Next = tmp.Next;
                            tmp.Next.Prev = tmp.Prev;
                            
                        }
                        Size--;
                        break;
                    }
                    tmp = tmp.Next;
                }
            }
            else
            {
                throw new Exception("no such value");
            }
            
            
        }
        public void RemoveAt(int index)
        {
            if ((index <= Size) && (index >= 0))
            {
                if (this[index] == First)
                {
                    First = this[index].Next;
                    First.Prev = null;
                }
                else if (this[index] == Current)
                {
                    Current = this[index].Prev;
                    Current.Next = null;
                }
                else
                {
                    this[index].Prev.Next = this[index].Next;
                    this[index].Next.Prev = this[index].Prev;

                }
                Size--;
            }
            else
            {
                throw new Exception("out of range");
            }
           
        }

        public bool Contains(T val)
        {
            MyListNode tmp = First;
            for (int i = 0; i < Size; i++)
            {
                if (tmp.Value.Equals(val))
                    return true;
                tmp = tmp.Next;
            }
            return false;
        }

        public T[] ToArray()
        {
            T[] arr = new T[Size];
            MyListNode tmp = First;
            for (int i = 0; i < Size - 1; i++)
            {
                arr[i] = tmp.Value;
                tmp = tmp.Next;
            }
            return arr;
        }
        MyListNode this[int index]
        {
            get
            {
                MyListNode tmp = First;
                for(int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp;
            }
            set
            {
                MyListNode tmp = First;
                for (int i = 0; i < index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp = value;
            }
        }

        private class MyListNode
        {
            MyListNode prev = null;
            MyListNode next = null;
            T value;

            internal MyListNode(T val, MyListNode prev = null, MyListNode next = null)
            {
                this.value = val;
                this.prev = prev;
                this.next = next;
            }
            public MyListNode Prev
            {
                set { prev = value; }
                get { return prev; }
            }
            public MyListNode Next
            {
                set { next = value; }
                get { return next; }
            }
            public T Value
            {
                get { return value; }
                set { this.value = value; }
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new MyListEnum(First, Size);
        } 
        class MyListEnum : IEnumerator
        {
            int index = -1;
            MyListNode node;
            int size;
            public MyListEnum(MyListNode n, int s)
            {
                node = n;
                size = s;
            }
            public bool MoveNext()
            {
                if (index + 1 < size)
                {
                    index++;
                    return true;
                }
                return false;
            }
            public void Reset()
            {
                index = -1;
                
            }
            public object Current
            {
                get 
                {
                    MyListNode tmp = node;
                    for (int i = 0; i <= index-1; i++)
                    {
                        tmp = tmp.Next;
                    }
                    return tmp.Value;
                }
            }
        }
    }
}
