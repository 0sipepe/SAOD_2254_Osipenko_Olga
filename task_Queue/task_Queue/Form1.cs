using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_Queue
{
    public partial class Form1 : Form
    {
        MyQueue<int> queue;
        public Form1()
        {
            InitializeComponent();
            lb.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string scap = textBox1.Text;
            if (!(int.TryParse(scap, out int cap)))
            {
                return;
            }

            queue = new MyQueue<int>(cap);
            label2.Text = queue.Capacity.ToString();
            lb.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = ""; 
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string snum = textBox2.Text;
            if (!(int.TryParse(snum, out int num)))
            {
                return;
            }

            try
            {
                queue.Enqueue(num);
                textBox2.Text = "";
            }
            catch (IndexOutOfRangeException)
            {
                textBox2.Text = "";           
            }
            lb.Items.Clear();

            int[] arr = queue.Values();

            Fill(arr);

        }
        private void Fill(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                lb.Items.Add(arr[i]);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = queue.Dequeue().ToString();
            }
            catch (IndexOutOfRangeException)
            {
                textBox3.Text = "";
                MessageBox.Show("queue is empty");

            }
            lb.Items.Clear();
            

            int[] arr = queue.Values();

            Fill(arr);
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            try 
            { 
                textBox4.Text = queue.First().ToString(); 
            }
            catch (IndexOutOfRangeException) 
            { 
                MessageBox.Show("queue is empty"); 
            }
        }

        

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            if (queue.IsEmpty)
            {
                textBox5.Text = "пуст";
            }
            else
            {
                textBox5.Text = "не пуст";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (queue == null)
            {
                MessageBox.Show("queue is empty");
            }
            try 
            { 
                textBox6.Text = queue.Last().ToString(); 
            }
            catch (IndexOutOfRangeException) 
            {
                MessageBox.Show("queue is empty");
            }
        }
    }
}
