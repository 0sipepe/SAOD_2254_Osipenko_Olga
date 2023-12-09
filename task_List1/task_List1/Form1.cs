using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_List;

namespace task_List1
{
    public partial class Form1 : Form
    {
        MyList<string> myList;
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;
            foreach (Control crl in this.Controls)
            {
                if ((crl.Name != "btn_Create"))
                {
                    crl.Visible = false;
                }
            }
        }

        private void FillList()
        {
            foreach (string item in myList)
            {
                listBox1.Items.Add(item);    
            }
        }
        private void btn_Create_Click(object sender, EventArgs e)
        {
            btn_Contains.BackColor = SystemColors.Control;
            foreach (Control crl in this.Controls)
            {
                crl.Visible = true;
            }
            listBox1.Items.Clear();
            listBox1.Visible = true;
            myList = new MyList<string>();
        }

        private void btn_Append_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            myList.Append(tb_Append.Text);
            FillList();
        }

        private void btn_Prepend_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            myList.Prepend(tb_Prepend.Text);
            FillList();
        }

       
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                myList.Remove(tb_Remove.Text);
                
            }
            catch
            {
                notifyIcon1.Icon = SystemIcons.Error;
                notifyIcon1.BalloonTipText = "No such value";
                notifyIcon1.ShowBalloonTip(500);
            }
            listBox1.Items.Clear();
            FillList();

        }

        private void btn_Contains_Click(object sender, EventArgs e)
        {
            if (myList.Contains(tb_Contains.Text))
            {
                btn_Contains.BackColor = Color.Aquamarine;
            }
            else
            {
                btn_Contains.BackColor = Color.Crimson;
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Find.Text = myList.Find(tb_Find.Text).ToString();
            }
            catch
            {
                MessageBox.Show("No such value!");
                //notifyIcon1.Icon = SystemIcons.Error;
                //notifyIcon1.BalloonTipTitle = "Error";
                //notifyIcon1.BalloonTipText = "Wrong input";
                //notifyIcon1.ShowBalloonTip(500);
            }
        }

        private void btn_RemoveAt_Click(object sender, EventArgs e)
        {
            try
            {
                myList.RemoveAt(Convert.ToInt32(tb_RemoveAt.Text));
            }
            catch
            {
                MessageBox.Show("Wrong input!");
            }
            listBox1.Items.Clear();
            FillList();
        }

        private void btn_FindAt_Click(object sender, EventArgs e)
        {
            try
            {
                tb_FindAt.Text = myList.FindAt(Convert.ToInt32(tb_FindAt.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Wrong input!");
            }
        }

        private void btn_SetValue_Click(object sender, EventArgs e)
        {
            try
            {
                myList.SetValue(Convert.ToInt32(tb_SetValueInd.Text), tb_SetValueVal.Text);
            }
            catch
            {
                MessageBox.Show("Wrong input!");
            }
            listBox1.Items.Clear();
            FillList();
        }

        
    } 
    
}
