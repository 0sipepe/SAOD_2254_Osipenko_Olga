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

        private void fillList()
        {
            listBox1.Items.Clear();

            int[] arr = stac.Value();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                listBox1.Items.Add(arr[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string scap = textBox1.Text;
            int cap;
            if (!(int.TryParse(scap, out cap)))
            {
                return;
            }

            stac = new MyStack<int>(cap);
            label2.Text = stac.Capacity.ToString();
            listBox1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string snum = textBox2.Text;
            int num;
            Console.WriteLine((int.TryParse(snum, out num)));
            if (!(int.TryParse(snum, out num)))
            {
                return;
            }
            try
            {
                stac.Push(num);
                textBox2.Text = "";
               

            }
            catch (IndexOutOfRangeException)
            {
                textBox2.Text = "";
                MessageBox.Show("stack is full");
            }
            listBox1.Items.Clear();

            int[] arr = stac.Value();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                listBox1.Items.Add(arr[i]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = stac.Pop().ToString();

               
                //for (int i = 0; i < listBox1.Items.Count - 1; i++)
                //{
                //    listBox1.Items[i] = listBox1.Items[i + 1];

                //}
                //listBox1.Items.Remove(listBox1.Items[listBox1.Items.Count - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                textBox3.Text = "";
                MessageBox.Show("stack is empty");
                
            }
            listBox1.Items.Clear();

            int[] arr = stac.Value();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                listBox1.Items.Add(arr[i]);
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
