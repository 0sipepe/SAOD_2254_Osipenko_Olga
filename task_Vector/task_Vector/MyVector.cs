using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_Vector
{
    internal class MyVector<T> : IEnumerable
    {
        T[] data;
        int capacity = 0;
        int size = 0;
        T defaultValue;

        public T DefaultValue
        {
            get { return defaultValue; }
        }
        public int Size
        {
            private set 
            { 
                size = value; 
            }
            get
            {
                return size;
            }
        }
        public int Capacity
        {
            private set 
            { 
                capacity = value; 
            }
            get 
            { 
                return capacity; 
            }
        }
        
        public MyVector(T defaultVal, int length = 0)
        {
            if (length < 0)
            {
                throw new Exception();
            }
            this.Capacity = 1 + length * 2;
            this.Size = length;
            this.defaultValue = defaultVal;

            data = new T[length];
            data = FillVector(Capacity, defaultVal, Size);

            
        }
        private T[] FillVector(int cap, T def, int size)
        {
            T[] array = new T[cap];
            for(int i = 0; i < size; i++)
            {
                array[i] = def;
            }
            return array;
        }
        internal T At(int index)
        {
            if (((index - 1 > this.Size - 1) || (index - 1 < 0)))
            {
                throw new IndexOutOfRangeException();
            }
            return data[index - 1];
        }
        internal void SetValue(int index, T value)
        {
            if (((index - 1 > this.Size - 1) || (index - 1 < 0)))
            {
                throw new IndexOutOfRangeException();
            }
            data[index - 1] = value;
        }
        internal void Add(T value)
        {
            if (size == this.Capacity)
            {
                this.Reserve(this.Capacity * 2 + 1);
                data[size] = value;
            }
            data[size++] = value;
            
        }

        internal void Reserve(int newCap)
        {
            if (newCap < 0)
            {
                return;
            }
            if (newCap < this.Size)
            {
                this.Capacity = this.Size;
            }
            else
            {
                this.Capacity = newCap;
            }
            T[] array = new T[this.Capacity];
            for(int i = 0; i < this.Size; i++)
            {
                array[i] = data[i];
            }
            data = array;
        }

        internal void Resize(int newSize)
        {
            T[] array = new T[this.Capacity];

            if (newSize < 0)
            {
                throw new IndexOutOfRangeException();
            }
            else if (newSize < this.Capacity)
            {
                for (int i = 0; i < newSize; i++)
                {
                    if (i < this.Size)
                    {
                        array[i] = data[i];
                    }
                    else
                    {
                        array[i] = DefaultValue;
                    }
                }
            }
            else
            {
                this.Reserve(newSize * 2);

                for (int i = 0; i < newSize; i++)
                {
                    if (i < this.Size)
                    {
                        array[i] = data[i];
                    }
                    else
                    {
                        array[i] = DefaultValue;
                    }
                }
            }

            this.Size = newSize;
            data = array;
        
        }
        internal void ShtinkToFit()
        {

            T[] array = new T[this.Size];
            this.Capacity = this.Size;
            for (int i = 0; i < this.Size; i++)
            {
                array[i] = data[i];
            }
            data = array;
        }
        public T this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }


        public IEnumerator GetEnumerator()
        {
            return new MyVectorEnum(data, this.Size);
        }
        class MyVectorEnum : IEnumerator
        {
            T[] arrayEnum;
            int index = -1;
            int sizeEnum = 0;
               

            public MyVectorEnum(T[] arr, int s)
            {
                arrayEnum = arr;
                sizeEnum = s - 1;

            }
            public bool MoveNext()
            {
                
                if (index++ < sizeEnum)
                {
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
                get {  return arrayEnum[index]; }
            }
        }
        
        
    }
}
 