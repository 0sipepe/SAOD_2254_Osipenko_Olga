using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_HashTable
{
    public partial class Form1 : Form
    {
        MyHashTable<string, string> table = new MyHashTable<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                table.Add(tb_AddKey.Text, tb_AddValue.Text);
                lb_Count.Text = table.CountElem.ToString();
            }
            catch
            {
                MessageBox.Show("Table already contains that value with that key");
            }
            
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            //try
            //{
                table.Remove(tb_Remove.Text);
                lb_Count.Text = table.CountElem.ToString();
            //}
            //catch
            //{
            //    MessageBox.Show("No such value");
            //}
        }

        private void btn_ValueByKey_Click(object sender, EventArgs e)
        {
            try
            {
                tb_VBKValue.Text = table.ValueByKey(tb_VBKKey.Text);
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void btn_ContainsKey_Click(object sender, EventArgs e)
        {
            if (table.ContainsKey(tb_ContainsKey.Text))
            {
                btn_ContainsKey.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_ContainsKey.BackColor = Color.Red;
            }
        }

        private void btn_KBV_Click(object sender, EventArgs e)
        {
            try
            {
                tb_KBVKey.Text = table.KeyByValue(tb_KBVValue.Text);
            }
            catch
            {
                MessageBox.Show("");
            }
        }

        private void btn_ContainsValue_Click(object sender, EventArgs e)
        {
            if (table.ContainsValue(tb_ContainsValue.Text))
            {
                btn_ContainsValue.BackColor = Color.GreenYellow;
            }
            else
            {
                btn_ContainsValue.BackColor = Color.Red;
            }
        }

        private void btn_ListKeys_Click(object sender, EventArgs e)
        {
            List<string> keys = table.GetKeys();
            foreach(string key in keys)
            {
                tb_ListKeys.Text += key + " ";
            }
        }

        private void btn_ListValues_Click(object sender, EventArgs e)
        {
            List<string> values = table.GetValues();
            foreach(string val in values)
            {
                tb_ListValue.Text += val + " ";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            table.Clear();
            lb_Count.Text = table.Count.ToString();
        }
    }
}
