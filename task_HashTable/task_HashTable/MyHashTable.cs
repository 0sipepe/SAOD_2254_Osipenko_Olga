using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_HashTable
{
    internal class MyHashTable<TKey, TValue> : IEnumerable
    {
        List<LinkedList<KeyValuePair<TKey, TValue>>> data = new List<LinkedList<KeyValuePair<TKey, TValue>>>(10);
        int countElem = 0;
        int count;

        public MyHashTable()
        {
            for(int i = 0; i < 10; i++)
            {
                data.Add(new LinkedList<KeyValuePair<TKey, TValue>>());
            }
        }
        private int GetMyHashCode(TKey key)
        {
            return Math.Abs(key.GetHashCode() % data.Capacity);
        }
        public int Count
        {

            get 
            { 
                foreach(LinkedList < KeyValuePair < TKey, TValue >> list in data)
                {
                    if (list.Count != 0 )
                    {
                        count++;
                    }
                }
                return count; 
            }
        }
        public int CountElem
        {
            get { return countElem; }
        }
        public void Add(TKey key, TValue value)
        {
            if (!(ContainsPair(key, value)))
            {
                Console.WriteLine(GetMyHashCode(key));
                data[GetMyHashCode(key)].AddLast(new KeyValuePair<TKey, TValue>(key, value));
                countElem++;
            }
            else
            {
                throw new Exception();
            }

        }
        public void Remove(TKey key)
        {
            if (!ContainsKey(key))
            {
                throw new Exception();
            }
            KeyValuePair<TKey, TValue> p = new KeyValuePair<TKey, TValue>();
            int index = GetMyHashCode(key);
            foreach (KeyValuePair<TKey, TValue> pair in data[index])
            {
                if (pair.Key.Equals(key))
                {
                    data[index].Remove(pair);
                    countElem--;
                    break;
                }
            }
            


        }
        public void Clear()
        {
            data.Clear();
            countElem++;
        }
        public TValue ValueByKey(TKey key)
        {
            foreach(KeyValuePair<TKey, TValue> pair in data[GetMyHashCode(key)])
            {
                if (pair.Key.Equals(key))
                {
                    return pair.Value;
                }
            }
            throw new Exception();
        }
        public TKey KeyByValue(TValue value)
        {
            foreach (LinkedList<KeyValuePair<TKey, TValue>> list in data)
            {
                foreach(KeyValuePair<TKey, TValue> pair in list)
                {
                    if (pair.Value.Equals(value))
                    {
                        return pair.Key;
                    }
                }
                    
            }
            throw new Exception();
        }

        private bool ContainsPair(TKey key, TValue value)
        {
            foreach (LinkedList<KeyValuePair<TKey, TValue>> list in data)
            {
                foreach (KeyValuePair<TKey, TValue> pair in list)
                {
                    if (pair.Value.Equals(value) && pair.Key.Equals(key))
                    {
                        return true;
                    }
                }

            }
            return false;
        }
        public TValue this[TKey index]
        {
            get { return ValueByKey(index); }
        }
        public bool ContainsKey(TKey key)
        {
            try
            {
                this.ValueByKey(key);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ContainsValue(TValue value)
        {
            try
            {
                this.KeyByValue(value);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<TKey> GetKeys()
        {
            List<TKey> list = new List<TKey>();
            foreach(KeyValuePair<TKey, TValue> pair in this)
            {
                list.Add(pair.Key);
            }
            return list;
        }

        public List<TValue> GetValues()
        {
            List<TValue> list = new List<TValue>();
            foreach(KeyValuePair<TKey, TValue> pair in this)
            {
                list.Add(pair.Value);
            }
            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyTableEnum(data, Count);
        }
        public class MyTableEnum : IEnumerator
        {
                      
            int listIndex = 0;
            int pairIndex = 0;
            int count = 0;
            List<LinkedList<KeyValuePair<TKey, TValue>>> data;

            public MyTableEnum(List<LinkedList<KeyValuePair<TKey, TValue>>> data,int count)
            {
                this.data = data;
                this.count = count;
            }
            public bool MoveNext()
            {
               
                if (listIndex < data.Count)
                {
                    if (pairIndex < data[listIndex].Count - 1)
                    {
                        pairIndex++;
                        return true;
                    }
                    if (data[listIndex].Count == 0)
                    {
                        while (data[listIndex].Count == 0)
                        {
                            pairIndex = 0;
                            listIndex++;
                        }
                    }
                    else
                    {
                        int countNotZero = 0;
                        int tmp = listIndex + 1;
                        while(tmp != data.Count)
                        {
                            if (data[tmp].Count != 0) countNotZero++;
                            tmp++;
                        }
                        if (countNotZero == 0)
                        {
                            return false;
                        }
                        
                        listIndex++;
                    }
                        
                    return true;
                }
                return false;
               
            }
            public void Reset()
            {
                pairIndex = 0;
                listIndex = 0;
            }
            public object Current
            {
                get { return data[listIndex].ElementAt(pairIndex); }

            }

        }
    }
}
