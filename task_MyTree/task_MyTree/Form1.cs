using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_MyTree
{
    public partial class Form1 : Form
    {
        MyTree<int> tree;
        MyDictionary<int, string> dict;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(tree == null)
            {
                tree = new MyTree<int>();
            }
            try 
            {
                tree.Add(Convert.ToInt32(nud_Add.Value));
            }
            catch
            {
                MessageBox.Show("Value is already in the tree");
            }
            
           
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (tree != null)
            {
                try
                {
                    tree.Remove(Convert.ToInt32(nud_Remove.Value));
                }
                catch
                {
                    MessageBox.Show("No such value");
                }
            }
            else
            {
                MessageBox.Show("Tree is empty");
            }
        }

        private void btn_LCR_Click(object sender, EventArgs e)
        {
            if (tree != null) tb_LCR.Text = tree.LCR();
            else
            {
                MessageBox.Show("Tree is empty");
            }
        }

        private void btn_RCL_Click(object sender, EventArgs e)
        {
            if (tree != null) tb_RCL.Text = tree.RCL();
            else
            {
                MessageBox.Show("Tree is empty");
            }
        }

        private void btn_CLR_Click(object sender, EventArgs e)
        {
            if (tree != null) tb_CLR.Text = tree.CLR();
            else
            {
                MessageBox.Show("Tree is empty");
            }
        }

        private void btn_Across_Click(object sender, EventArgs e)
        {
            if (tree != null) tb_Across.Text = tree.Across();
            else
            {
                MessageBox.Show("Tree is empty");
            }
        }

        private void btn_ToList_Click(object sender, EventArgs e)
        {
            if (tree!= null)
            {
                Console.WriteLine();
                foreach (var val in tree.ToList())
                {
                    tb_ToList.Text += val.ToString() + " ";
                }
            }
           
            else
            {
                MessageBox.Show("Tree is empty");
            }
        }

        private void btn_Contains_Click(object sender, EventArgs e)
        {
            if(tree!= null)
            {
                if (tree.Contains(Convert.ToInt32(nud_Contains.Value)))
                {
                    btn_Contains.BackColor = Color.Green;
                }
                else
                {
                    btn_Contains.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Tree is empty");
            }

        }

        private void btn_AddDict_Click(object sender, EventArgs e)
        {
            if(dict == null)
            {
                dict = new MyDictionary<int, string>();
            }
            dict.Add(Convert.ToInt32(nud_AddKey.Value), tb_AddValue.Text);
        }

        private void btn_RemoveDict_Click(object sender, EventArgs e)
        {
            if (dict != null)
            {
                try
                {
                    dict.Remove(Convert.ToInt32(nud_RemoveKey.Value));
                }
                catch
                {
                    MessageBox.Show("No such value");
                }
            }
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_ContainsKey_Click(object sender, EventArgs e)
        {
            if (dict != null)
            {
                if (dict.ContainsKey(Convert.ToInt32(nud_ContainsKey.Value)))
                {
                    btn_Contains.BackColor = Color.Green;
                }
                else
                {
                    btn_Contains.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_ContainsValue_Click(object sender, EventArgs e)
        {
            if (dict != null)
            {
                if (dict.ContainsValue(tb_ContainsValue.Text))
                {
                    btn_Contains.BackColor = Color.Green;
                }
                else
                {
                    btn_Contains.BackColor = Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_LCRDict_Click(object sender, EventArgs e)
        {
            if (dict != null) tb_LCRDict.Text = dict.LCR();
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_RCLDict_Click(object sender, EventArgs e)
        {
            if (dict != null) tb_RCLDict.Text = dict.RCL();
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_CLRDict_Click(object sender, EventArgs e)
        {
            if (dict != null) tb_CLRDict.Text = dict.CLR();
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_AcrossDict_Click(object sender, EventArgs e)
        {
            if (dict != null) tb_AcrossDict.Text = dict.Across();
            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

        private void btn_ToListDict_Click(object sender, EventArgs e)
        {
            if (dict != null)
            {
                Console.WriteLine();
                foreach (var val in dict.ToListValues())
                {
                    tb_ToListValues.Text += val.ToString();
                }
            }

            else
            {
                MessageBox.Show("Dictionary is empty");
            }
        }

       
    }
}
