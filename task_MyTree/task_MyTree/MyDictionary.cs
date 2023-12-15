using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_MyTree
{
    internal class MyDictionary<TKey, TValue> : IEnumerable where  TKey: IComparable
    {
        int count = 0;
        MyDictNode<TKey, TValue> root;
        

        public void Add(TKey key, TValue val)
        {
            MyDictNode<TKey, TValue> node = new MyDictNode<TKey, TValue>(key, val);
            if (root == null)
                root = node;
            else
                this.Add(node, root);

            count++;
            
        }
        private void Add(MyDictNode<TKey, TValue> n, MyDictNode<TKey, TValue> r)
        {

            if (r.Pair.Key.CompareTo(n.Pair.Key) == 0)
            {
                throw new Exception();
            }
            if (r.Pair.Key.CompareTo(n.Pair.Key) > 0)
            {
                if (r.Left == null)
                {
                    r.Left = n;
                    n.Parent = r;
                }

                else
                {
                    Add(n, r.Left);
                }
            }
            else
            {
                if (r.Right == null)
                {
                    r.Right = n;
                    n.Parent = r;
                }

                else
                {
                    Add(n, r.Right);
                }

            }

        }
        public bool ContainsValue(TValue value)
        {
            return ContainsValue(value, root);
        }

        private bool ContainsValue(TValue value, MyDictNode<TKey, TValue> r)
        {

            List<TValue> list = this.ToListValues();
            foreach(TValue val in list)
            {
                if (val.Equals(value))
                {
                    return true;
                }
            }
            return false;

           
        }
        public bool ContainsKey(TKey key)
        {
            return ContainsKey(key, root);
        }
        private bool ContainsKey(TKey key, MyDictNode<TKey, TValue> r)
        {
            if (r == null)
            {
                return false;
            }
            else
            {
                if (r.Pair.Key.CompareTo(key) == 0)
                {
                    return true;
                }
                else if (r.Pair.Key.CompareTo(key) > 0)
                {
                    return ContainsKey(key, r.Left);
                }
                else
                {
                    return ContainsKey(key, r.Right);
                }
            }
        }

        public void Remove(TKey key)
        {
            if (this.FindByKey(key, root) != null)
            {
                MyDictNode<TKey, TValue> node = this.FindByKey(key, root);
                if (node.Left != null && node.Right != null)
                {                                                                            //обе ветки
                    bool flag = false;
                    MyDictNode<TKey, TValue> tempNode = node;
                    while (tempNode.Left != null && tempNode.Right != null)
                    {
                        if (flag == false)
                        {
                            tempNode = tempNode.Left;
                            flag = true;
                        }
                        else
                        {
                            tempNode = tempNode.Right;
                            flag = false;
                        }
                    }

                    if (node == root)
                    {
                        if (tempNode != root.Left)
                        {
                            tempNode.Left = root.Left;
                            root.Left.Parent = tempNode;
                        }
                        tempNode.Right = root.Right;
                        root.Right.Parent = tempNode;
                        root = tempNode;

                    }
                    else
                    {
                        if (node.Parent.Pair.Key.CompareTo(node.Pair.Key) > 0)
                            node.Parent.Left = tempNode;                             //меняем родительскую ссылку с удаленного на лист
                        else
                            node.Parent.Right = tempNode;

                        tempNode.Left = node.Left;                                   //меняем характеристики листа на х-и удаленного
                        tempNode.Right = node.Right;
                        tempNode.Parent = node.Parent;

                        if (tempNode.Parent.Pair.Key.CompareTo(tempNode.Pair.Key) > 0)
                            tempNode.Parent.Left = null;                             //удаляем родительскую ссылку на лист
                        else
                            tempNode.Parent.Right = null;
                    }


                }
                else if (node.Left == null && node.Right == null)
                {                                                                          //нет веток
                    if (node == root)
                    {
                        root = null;
                    }
                    else if (node.Parent.Pair.Key.CompareTo(node.Pair.Key) > 0)
                    {
                        node.Parent.Left = null;
                        node.Parent = null;
                    }
                    else
                    {
                        node.Parent.Right = null;
                        node.Parent = null;
                    }


                }
                else if (node.Left == null && node.Right != null)
                {                                                                           //ветка справа
                    if (node == root)
                    {
                        root.Right.Parent = null;
                        root = root.Right;
                    }
                    else
                    {
                        if (node.Parent.Pair.Key.CompareTo(node.Pair.Key) > 0)
                        {
                            node.Parent.Left = node.Right;
                            node.Right.Parent = node.Parent;
                        }
                        else
                        {
                            node.Parent.Right = node.Right;
                            node.Right.Parent = node.Parent;
                        }
                    }
                }
                else if (node.Left != null && node.Right == null)
                {                                                                           //ветка слева
                    if (node == root)
                    {
                        root.Left.Parent = null;
                        root = root.Left;
                    }
                    else
                    {
                        if (node.Parent.Pair.Key.CompareTo(node.Pair.Key) > 0)
                        {
                            node.Parent.Left = node.Left;
                            node.Left.Parent = node.Parent;
                        }
                        else
                        {
                            node.Parent.Right = node.Left;
                            node.Left.Parent = node.Parent;
                        }
                    }

                }
                
                count--;
            }
            else
            {
                throw new Exception();
            }

        }
        public void Clear()
        {
            root.Left = null;
            root.Right = null;
            root = null;
        }

        public MyDictNode<TKey, TValue> FindByKey(TKey key, MyDictNode<TKey, TValue> r)
        {
            if (r == null) return null;

            if (r.Pair.Key.CompareTo(key) == 0)
                return r;
            if (r.Pair.Key.CompareTo(key) > 0)
                return FindByKey(key, r.Left);
           
            return FindByKey(key, r.Right);

        }
        public MyDictNode<TKey, TValue> FindByValue(TValue value, MyDictNode<TKey, TValue> r)
        {
            if (r == null) return null;
            if (r.Pair.Value.Equals(value)) return r;

            if(FindByValue(value, r.Left) == null)
            {
                if(FindByValue(value, r.Right) == null)
                {
                    return null;
                }
                return (FindByValue(value, r.Right));
            }
            return (FindByValue(value, r.Left));



        }
        public int GetDeep()
        {
            return GetDeep(root);
        }
        private int GetDeep(MyDictNode<TKey, TValue> r)
        {
            if (r == null) return 0;

            return 1 + Math.Max(GetDeep(r.Left), GetDeep(r.Right));


        }

        public TValue this[TKey key]
        {
            get
            {
                return FindByKey(key, root).Pair.Value;
            }
            
        }

        public string LCR()
        {
            return LCR(root);
        }
        private string LCR(MyDictNode<TKey, TValue> r)
        {

            if (r == null) return "";
            if (r.Left == null && r.Right == null) return r.Pair.Value.ToString() + " ";
            return LCR(r.Left) + " " + r.Pair.Value + " " + LCR(r.Right) + " ";
        }
        public string RCL()
        {
            return RCL(root);
        }
        private string RCL(MyDictNode<TKey, TValue> r)
        {
            if (r == null) return "";
            if (r.Left == null && r.Right == null) return r.Pair.Value.ToString() + " ";
            return RCL(r.Right) + " " + r.Pair.Value + " " + RCL(r.Left) + " ";
        }
        public string CLR()
        {
            return CLR(root);
        }
        private string CLR(MyDictNode<TKey, TValue> r)
        {
            if (r == null) return "";
            if (r.Left == null && r.Right == null) return r.Pair.Value.ToString() + " ";
            return r.Pair.Value + " " + CLR(r.Left) + " " + CLR(r.Right) + " ";
        }
        public string Across()
        {
            return Across(root);
        }
        private string Across(MyDictNode<TKey, TValue> r)
        {
            if (r == null) return "";
            string answer = "";

            Queue<MyDictNode<TKey, TValue>> queue = new Queue<MyDictNode<TKey, TValue>>(count);
            queue.Enqueue(r);

            while (queue.Count != 0)
            {
                MyDictNode<TKey, TValue> node = queue.Dequeue();
                answer += node.Pair.Value.ToString() + " ";

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);

            }

            return answer;


        }
        private List<MyDictNode<TKey, TValue>> ToList(MyDictNode<TKey, TValue> r)
        {
            List<MyDictNode<TKey, TValue>> list = new List<MyDictNode<TKey, TValue>>();

            if (r.Left == null && r.Right == null)
            {
                List<MyDictNode<TKey, TValue>> tmp = new List<MyDictNode<TKey, TValue>>();
                tmp.Add(r);
                return tmp;
            }

            if (r.Left != null) list.AddRange(ToList(r.Left));

            list.Add(r);

            if (r.Right != null) list.AddRange(ToList(r.Right));

            return list;
        }
        public List<TValue> ToListValues()
        {
            return ToListValues(root);
        }
        private List<TValue> ToListValues(MyDictNode<TKey, TValue> r)
        {
            List<TValue> list = new List<TValue>();

            if (r.Left == null && r.Right == null)
            {
                List<TValue> tmp = new List<TValue>();
                tmp.Add(r.Pair.Value);
                return tmp;
            }

            if (r.Left != null) list.AddRange(ToListValues(r.Left));

            list.Add(r.Pair.Value);

            if (r.Right != null) list.AddRange(ToListValues(r.Right));

            return list;
        }
        public List<TKey> ToListKeys()
        {
            return ToListKeys(root);
        }
        private List<TKey> ToListKeys(MyDictNode<TKey, TValue> r)
        {
            List<TKey> list = new List<TKey>();

            if (r.Left == null && r.Right == null)
            {
                List<TKey> tmp = new List<TKey>();
                tmp.Add(r.Pair.Key);
                return tmp;
            }

            if (r.Left != null) list.AddRange(ToListKeys(r.Left));

            list.Add(r.Pair.Key);

            if (r.Right != null) list.AddRange(ToListKeys(r.Right));

            return list;
        }

        public IEnumerator GetEnumerator()
        {
            return new MyDictEnum(this.ToList(root));
        }
        private class MyDictNode<TKey, TValue> where TKey : IComparable
        {
            MyDictNode<TKey, TValue> parent;
            MyDictNode<TKey, TValue> left;
            MyDictNode<TKey, TValue> right;
            KeyValuePair<TKey,TValue> pair;

            internal MyDictNode(TKey key, TValue val, MyDictNode<TKey, TValue> left = null, MyDictNode<TKey, TValue> right = null, MyDictNode<TKey, TValue> parent = null)
            {
                this.pair = new KeyValuePair<TKey,TValue>(key,val);
                this.left = left;
                this.right = right;
            }
            

            internal MyDictNode<TKey, TValue> Left
            {
                get { return left; }
                set { left = value; }
            }
            internal MyDictNode<TKey, TValue> Right
            {
                get { return right; }
                set { right = value; }
            }
            internal MyDictNode<TKey, TValue> Parent
            {
                get { return parent; }
                set { parent = value; }
            }
            internal KeyValuePair<TKey, TValue> Pair
            {
                get { return pair; }
                set { this.pair = value; }
            }
        }

        private class MyDictEnum : IEnumerator
        {
            List<MyDictNode<TKey, TValue>> list;
            int index = -1;
            public MyDictEnum(List<MyDictNode<TKey, TValue>> l) 
            {
                list = l;
            }
            public bool MoveNext()
            {
                if (index < list.Count) return true; 
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
                    return (list[index].Pair.Value);
                }
                
            }
        }

    }
}