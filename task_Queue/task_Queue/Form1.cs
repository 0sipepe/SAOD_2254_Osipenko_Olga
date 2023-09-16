﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_Queue
{
    public partial class Form1 : Form
    {
        MyQueue<int> queu;
        public Form1()
        {
            InitializeComponent();
            lb.Visible = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string scap = textBox1.Text;
            int cap;
            if (!(int.TryParse(scap, out cap)))
            {
                return;
            }

            queu = new MyQueue<int>(cap);
            label2.Text = queu.Capacity.ToString();
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
            int num;
            if (!(int.TryParse(snum, out num))) return;
            
            try
            {
                queu.Enqueue(num);
                textBox2.Text = "";
            }
            catch (IndexOutOfRangeException)
            {
                textBox2.Text = "";
                 
            }
            lb.Items.Clear();

            int[] arr = queu.Values();
            
            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("_" + arr[i]);
              
                lb.Items.Add(arr[i]);
                

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = queu.Decueue().ToString();
            }
            catch (IndexOutOfRangeException)
            {
                textBox3.Text = "";
                MessageBox.Show("queue is empty");

            }
            lb.Items.Clear();
            

            int[] arr = queu.Values();
            if (arr == null) return;
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "_");
                
                lb.Items.Add(arr[i]);
                
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            try { textBox4.Text = queu.First().ToString(); }
            catch (IndexOutOfRangeException) { MessageBox.Show("queue is empty"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIsEmpty_Click(object sender, EventArgs e)
        {
            if (queu.IsEmpty()) { textBox5.Text = "пуст"; }
            else textBox5.Text = "не пуст";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb.Visible == false) MessageBox.Show("queue is empty");
            try { textBox6.Text = queu.Last().ToString(); }
            catch (IndexOutOfRangeException) {
                MessageBox.Show("queue is empty");

            }
        }
    }
}
