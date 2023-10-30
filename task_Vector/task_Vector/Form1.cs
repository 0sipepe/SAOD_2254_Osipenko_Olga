using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_Vector
{
    public partial class Form1 : Form
    { 
        MyVector<int> vector;
        

        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
        }
       
        private void btn_Create_Click(object sender, EventArgs e)
        {
            int defVal = (int)nud_defVal.Value;
            int len = (int)nud_Length.Value;
            try
            {
                vector = new MyVector<int>(defVal, len);
              
                FillListBox(vector);
            }
            catch
            {
                MessageBox.Show("Введено недопустимое значение");
            }
            
            label1.Visible = true;

            label4.Text = vector.Capacity.ToString();
            label5.Text = vector.Size.ToString();
            label8.Text = vector.DefaultValue.ToString();
            

            nud_Length.Value = 0;
            nud_defVal.Value = 0;
            

        }

        private void btn_Add_Click(object sender, EventArgs e)
         {
            if (vector == null)
            {
                return;
            }
            int val = (int)nud_Add.Value;
            vector.Add(val);

            FillListBox(vector);

           
            label4.Text = vector.Capacity.ToString();
            label7.Text = vector.Size.ToString();

            nud_Add.Value = 0;
        }

        private void btn_At_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                return;
            }
            int val = (int)nud_AtInd.Value;
            
            try
            {
                nud_AtVal.Value = vector.At(val);
            }
            catch
            {
                MessageBox.Show("Введено недопустимое значение");
            }

            FillListBox(vector);

            nud_AtInd.Value = 0;
        }

        private void btn_SetValue_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                return;
            }
            int ind = (int)nud_SetInd.Value;
            int val = (int)nud_SetVal.Value;
            try
            {
                vector.SetValue(ind, val);
            }
            catch
            {
                MessageBox.Show("Введено недопустимое значение");
            }


            FillListBox(vector);

            nud_SetInd.Value = 0;
            nud_SetVal.Value = 0;


        }

        private void btn_Reserve_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                return;
            }
       

            vector.Reserve((int)nud_Reserve.Value);

            label4.Text = vector.Capacity.ToString();
            label5.Text = vector.Size.ToString();

            nud_Reserve.Value = 0;
        }

        private void btn_Resize_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                return;
            }
            int val = (int)nud_Resize.Value;
            nud_Resize.Value = 0;
            try
            {
                vector.Resize(val);
            }
            catch
            {
                MessageBox.Show("Введено неверное значение");
            }

            FillListBox(vector);

            label4.Text = vector.Capacity.ToString();
            label5.Text = vector.Size.ToString();
        }

        private void btn_Shrink_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                return;
            }
            vector.ShrinkToFit();
            label4.Text = vector.Capacity.ToString();
            label5.Text = vector.Size.ToString();
        }

        private void FillListBox(MyVector<int> v)
        {
            listBox1.Items.Clear();
            foreach(int el in v)
            {
                listBox1.Items.Add(el);
            }
        }

        
    }
}
