using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_Stack1
{
    public partial class Form1 : Form
    {
        MyStack<int> stac;
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("enter value - capacity of your stack");
            }
            else
            {
                int cap = Convert.ToInt32(textBox1.Text);
                stac = new MyStack<int>(cap);
                listBox1.Visible = true;
                textBox1.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("enter value");
            }
            else
            {
                try
                {
                    stac.Push(Convert.ToInt32(textBox2.Text));
                    listBox1.Items.Add("-");

                    for (int i = listBox1.Items.Count - 1; i > 0; i--)
                    {
                        listBox1.Items[i] = listBox1.Items[i - 1];
                    }
                    listBox1.Items[0] = stac.Peek();
                    textBox2.Text = "";


                }
                catch (IndexOutOfRangeException)
                {
                    textBox2.Text = "";
                    MessageBox.Show("stack is full");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = stac.Pop().ToString();
                for (int i = 0; i < listBox1.Items.Count - 1; i++)
                {
                    listBox1.Items[i] = listBox1.Items[i + 1];

                }
                listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                textBox3.Text = "";
                MessageBox.Show("stack is empty");
                
            }
            
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                textBox4.Text = stac.Peek().ToString();
            }
            catch (IndexOutOfRangeException)
            {
                textBox4.Text = "";
                MessageBox.Show("stack is empty");
            }
        }
    }
}
