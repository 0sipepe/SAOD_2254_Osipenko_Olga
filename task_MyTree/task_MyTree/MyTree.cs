using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace task_MyTree
{
    internal class MyTree<T> where T : IComparable
    {
        MyTreeNode<T> root;
        //public static List<MyTreeNode<T>> nods = new List<MyTreeNode<T>>();
        int count = 0;

       
        public void Add(T val)
        {
            MyTreeNode<T> node = new MyTreeNode<T>(val);
            if (root == null)
                root = node;
            else
                this.Add(node, root);

            //nods.Add(node);
            count++;
        }
        private void Add(MyTreeNode<T> n, MyTreeNode<T> r)
        {

            if (r.Value.CompareTo(n.Value) == 0)
            {
                throw new Exception();
            }
            if (r.Value.CompareTo(n.Value) > 0)
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
        public bool Contains(T value)
        {
            return Contains(value, root);
        }

        private bool Contains(T value, MyTreeNode<T> r)
        {

            if (r == null)
            {
                return false;
            }
            else
            {
                if (r.Value.CompareTo(value) == 0)
                {
                    return true;
                }
                else if (r.Value.CompareTo(value) > 0)
                {
                    return Contains(value, r.Left);
                }
                else
                {
                    return Contains(value, r.Right);
                }
            }
        }

        public void Remove(T value)
        {
            if (this.Find(value, root) != null)
            {
                MyTreeNode<T> node = this.Find(value, root);
                if (node.Left != null && node.Right != null)
                {
                    bool flag = false;
                    MyTreeNode<T> tempNode = node;
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
                        if (node.Parent.Value.CompareTo(node.Value) > 0)
                            node.Parent.Left = tempNode;                             //меняем родительскую ссылку с удаленного на лист
                        else
                            node.Parent.Right = tempNode;

                        tempNode.Left = node.Left;                                   //меняем характеристики листа на х-и удаленного
                        tempNode.Right = node.Right;
                        tempNode.Parent = node.Parent;

                        if (tempNode.Parent.Value.CompareTo(tempNode.Value) > 0)
                            tempNode.Parent.Left = null;                             //удаляем родительскую ссылку на лист
                        else
                            tempNode.Parent.Right = null;
                    }


                }
                else if (node.Left == null && node.Right == null)
                {
                    if (node == root)
                    {
                        root = null;
                    }
                    else if (node.Parent.Value.CompareTo(node.Value) > 0)
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
                {
                    if (node == root)
                    {
                        root.Right.Parent = null;
                        root = root.Right;
                    }
                    else
                    {
                        if (node.Parent.Value.CompareTo(node.Value) > 0)
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
                {
                    if (node == root)
                    {
                        root.Left.Parent = null;
                        root = root.Left;
                    }
                    else
                    {
                        if (node.Parent.Value.CompareTo(node.Value) > 0)
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
                //nods.Remove(node);
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
        }
        
        private MyTreeNode<T> Find(T value, MyTreeNode<T> r)
        {
            if (r == null) return null;

            if (r.Value.CompareTo(value) == 0)
                return r;
            if (r.Value.CompareTo(value) > 0)
                return Find(value, r.Left);
            
            return Find(value, r.Right);

        }
        public int GetDeep()
        {
            return GetDeep(root);
        }
        private int GetDeep(MyTreeNode<T> r)
        {
            if (r == null) return 0;

            return 1 + Math.Max(GetDeep(r.Left), GetDeep(r.Right));


        }
        public string LCR()
        {
            return LCR(root);
        }
        private string LCR(MyTreeNode<T> r)
        {

            if (r == null) return "";
            if (r.Left == null && r.Right == null) return r.Value.ToString() + " ";
            
            return LCR(r.Left) + " " + r.Value + " " + LCR(r.Right) + " ";
        }
        public string RCL()
        {
            return RCL(root);
        }
        private string RCL(MyTreeNode<T> r)
        {
            if (r == null) return "";
            if (r.Left == null && r.Right == null) return r.Value.ToString() + " ";
            return RCL(r.Right) + " " + r.Value + " " + RCL(r.Left) + " ";
        }
        public string CLR()
        {
            return CLR(root);
        }
        private string CLR(MyTreeNode<T> r)
        {
            if (r == null) return "";
            if (r.Left == null && r.Right == null) return r.Value.ToString() + " ";
            return r.Value + " " + CLR(r.Left) + " " + CLR(r.Right) + " ";
        }
        public string Across()
        {
            return Across(root);
        }
        private string Across(MyTreeNode<T> r)
        {
            if (r == null) return "";
            string answer = "";

            Queue<MyTreeNode<T>> queue = new Queue<MyTreeNode<T>>(1000);
            queue.Enqueue(r);

            while (queue.Count != 0)
            {
                MyTreeNode<T> node = queue.Dequeue();
                answer += node.Value.ToString() + " ";

                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);

            }

            return answer;


        }
        public List<T> ToList()
        {
            return ToList(root);
        }
        private List<T> ToList(MyTreeNode<T> r)
        {
            List<T> list = new List<T>();

            if (r.Left == null && r.Right == null)
            {
                List<T> tmp = new List<T>();
                tmp.Add(r.Value);
                return tmp;
            }

            if (r.Left != null) list.AddRange(ToList(r.Left));

            list.Add(r.Value);

            if (r.Right != null) list.AddRange(ToList(r.Right));

            return list;
        }
        private class MyTreeNode<T> where T : IComparable
        {
            MyTreeNode<T> parent;
            MyTreeNode<T> left;
            MyTreeNode<T> right;
            T value;

            internal MyTreeNode(T val, MyTreeNode<T> left = null, MyTreeNode<T> right = null, MyTreeNode<T> parent = null)
            {
                value = val;
                this.left = left;
                this.right = right;
            }

            internal MyTreeNode<T> Left
            {
                get { return left; }
                set { left = value; }
            }
            internal MyTreeNode<T> Right
            {
                get { return right; }
                set { right = value; }
            }
            internal MyTreeNode<T> Parent
            {
                get { return parent; }
                set { parent = value; }
            }
            internal T Value
            {
                get { return value; }
                set { this.value = value; }
            }
        }

    }
}
