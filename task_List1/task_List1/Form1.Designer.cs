namespace task_List1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Append = new System.Windows.Forms.Button();
            this.tb_Append = new System.Windows.Forms.TextBox();
            this.tb_Prepend = new System.Windows.Forms.TextBox();
            this.tb_Remove = new System.Windows.Forms.TextBox();
            this.tb_Contains = new System.Windows.Forms.TextBox();
            this.btn_Prepend = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_Contains = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_RemoveAt = new System.Windows.Forms.Button();
            this.btn_FindAt = new System.Windows.Forms.Button();
            this.btn_Sort = new System.Windows.Forms.Button();
            this.btn_SetValue = new System.Windows.Forms.Button();
            this.tb_Find = new System.Windows.Forms.TextBox();
            this.tb_SetValueVal = new System.Windows.Forms.TextBox();
            this.tb_RemoveAt = new System.Windows.Forms.TextBox();
            this.tb_FindAt = new System.Windows.Forms.TextBox();
            this.tb_SetValueInd = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 292);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Append
            // 
            this.btn_Append.Location = new System.Drawing.Point(221, 31);
            this.btn_Append.Name = "btn_Append";
            this.btn_Append.Size = new System.Drawing.Size(120, 44);
            this.btn_Append.TabIndex = 1;
            this.btn_Append.Text = "добавить в конец";
            this.btn_Append.UseVisualStyleBackColor = true;
            this.btn_Append.Click += new System.EventHandler(this.btn_Append_Click);
            // 
            // tb_Append
            // 
            this.tb_Append.Location = new System.Drawing.Point(365, 50);
            this.tb_Append.Multiline = true;
            this.tb_Append.Name = "tb_Append";
            this.tb_Append.Size = new System.Drawing.Size(133, 25);
            this.tb_Append.TabIndex = 7;
            // 
            // tb_Prepend
            // 
            this.tb_Prepend.Location = new System.Drawing.Point(365, 109);
            this.tb_Prepend.Multiline = true;
            this.tb_Prepend.Name = "tb_Prepend";
            this.tb_Prepend.Size = new System.Drawing.Size(133, 25);
            this.tb_Prepend.TabIndex = 8;
            // 
            // tb_Remove
            // 
            this.tb_Remove.Location = new System.Drawing.Point(365, 173);
            this.tb_Remove.Multiline = true;
            this.tb_Remove.Name = "tb_Remove";
            this.tb_Remove.Size = new System.Drawing.Size(133, 25);
            this.tb_Remove.TabIndex = 9;
            // 
            // tb_Contains
            // 
            this.tb_Contains.Location = new System.Drawing.Point(365, 237);
            this.tb_Contains.Multiline = true;
            this.tb_Contains.Name = "tb_Contains";
            this.tb_Contains.Size = new System.Drawing.Size(133, 25);
            this.tb_Contains.TabIndex = 10;
            // 
            // btn_Prepend
            // 
            this.btn_Prepend.Location = new System.Drawing.Point(221, 90);
            this.btn_Prepend.Name = "btn_Prepend";
            this.btn_Prepend.Size = new System.Drawing.Size(120, 44);
            this.btn_Prepend.TabIndex = 2;
            this.btn_Prepend.Text = "добавить в начало";
            this.btn_Prepend.UseVisualStyleBackColor = true;
            this.btn_Prepend.Click += new System.EventHandler(this.btn_Prepend_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(221, 154);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(120, 44);
            this.btn_Remove.TabIndex = 3;
            this.btn_Remove.Text = "удалить";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Contains
            // 
            this.btn_Contains.Location = new System.Drawing.Point(221, 218);
            this.btn_Contains.Name = "btn_Contains";
            this.btn_Contains.Size = new System.Drawing.Size(120, 44);
            this.btn_Contains.TabIndex = 4;
            this.btn_Contains.Text = "содержится ли?";
            this.btn_Contains.UseVisualStyleBackColor = true;
            this.btn_Contains.Click += new System.EventHandler(this.btn_Contains_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Location = new System.Drawing.Point(221, 277);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(120, 44);
            this.btn_Find.TabIndex = 5;
            this.btn_Find.Text = "найти индекс";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_RemoveAt
            // 
            this.btn_RemoveAt.Location = new System.Drawing.Point(542, 31);
            this.btn_RemoveAt.Name = "btn_RemoveAt";
            this.btn_RemoveAt.Size = new System.Drawing.Size(120, 44);
            this.btn_RemoveAt.TabIndex = 6;
            this.btn_RemoveAt.Text = "удалить по индексу";
            this.btn_RemoveAt.UseVisualStyleBackColor = true;
            this.btn_RemoveAt.Click += new System.EventHandler(this.btn_RemoveAt_Click);
            // 
            // btn_FindAt
            // 
            this.btn_FindAt.Location = new System.Drawing.Point(542, 90);
            this.btn_FindAt.Name = "btn_FindAt";
            this.btn_FindAt.Size = new System.Drawing.Size(120, 44);
            this.btn_FindAt.TabIndex = 11;
            this.btn_FindAt.Text = "узнать по индексу";
            this.btn_FindAt.UseVisualStyleBackColor = true;
            this.btn_FindAt.Click += new System.EventHandler(this.btn_FindAt_Click);
            // 
            // btn_Sort
            // 
            this.btn_Sort.Location = new System.Drawing.Point(709, 249);
            this.btn_Sort.Name = "btn_Sort";
            this.btn_Sort.Size = new System.Drawing.Size(122, 72);
            this.btn_Sort.TabIndex = 12;
            this.btn_Sort.Text = "сортировка (еще не реализована)";
            this.btn_Sort.UseVisualStyleBackColor = true;
            // 
            // btn_SetValue
            // 
            this.btn_SetValue.Location = new System.Drawing.Point(542, 154);
            this.btn_SetValue.Name = "btn_SetValue";
            this.btn_SetValue.Size = new System.Drawing.Size(120, 73);
            this.btn_SetValue.TabIndex = 13;
            this.btn_SetValue.Text = "установить значение по индексу";
            this.btn_SetValue.UseVisualStyleBackColor = true;
            this.btn_SetValue.Click += new System.EventHandler(this.btn_SetValue_Click);
            // 
            // tb_Find
            // 
            this.tb_Find.Location = new System.Drawing.Point(365, 296);
            this.tb_Find.Multiline = true;
            this.tb_Find.Name = "tb_Find";
            this.tb_Find.Size = new System.Drawing.Size(133, 25);
            this.tb_Find.TabIndex = 14;
            // 
            // tb_SetValueVal
            // 
            this.tb_SetValueVal.Location = new System.Drawing.Point(679, 202);
            this.tb_SetValueVal.Multiline = true;
            this.tb_SetValueVal.Name = "tb_SetValueVal";
            this.tb_SetValueVal.Size = new System.Drawing.Size(152, 25);
            this.tb_SetValueVal.TabIndex = 15;
            // 
            // tb_RemoveAt
            // 
            this.tb_RemoveAt.Location = new System.Drawing.Point(679, 50);
            this.tb_RemoveAt.Multiline = true;
            this.tb_RemoveAt.Name = "tb_RemoveAt";
            this.tb_RemoveAt.Size = new System.Drawing.Size(73, 25);
            this.tb_RemoveAt.TabIndex = 16;
            // 
            // tb_FindAt
            // 
            this.tb_FindAt.Location = new System.Drawing.Point(679, 109);
            this.tb_FindAt.Multiline = true;
            this.tb_FindAt.Name = "tb_FindAt";
            this.tb_FindAt.Size = new System.Drawing.Size(73, 25);
            this.tb_FindAt.TabIndex = 17;
            // 
            // tb_SetValueInd
            // 
            this.tb_SetValueInd.Location = new System.Drawing.Point(679, 171);
            this.tb_SetValueInd.Multiline = true;
            this.tb_SetValueInd.Name = "tb_SetValueInd";
            this.tb_SetValueInd.Size = new System.Drawing.Size(73, 25);
            this.tb_SetValueInd.TabIndex = 18;
            // 
            // btn_Create
            // 
            this.btn_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Create.Location = new System.Drawing.Point(542, 249);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(150, 72);
            this.btn_Create.TabIndex = 19;
            this.btn_Create.Text = "создать";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(362, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "значение:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(364, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "значение:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(364, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "значение:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(362, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "значение:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(362, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "значение:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(676, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "индекс:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(676, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "индекс:";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(676, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "индекс:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 364);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.tb_SetValueInd);
            this.Controls.Add(this.tb_FindAt);
            this.Controls.Add(this.tb_RemoveAt);
            this.Controls.Add(this.tb_SetValueVal);
            this.Controls.Add(this.tb_Find);
            this.Controls.Add(this.btn_SetValue);
            this.Controls.Add(this.btn_Sort);
            this.Controls.Add(this.btn_FindAt);
            this.Controls.Add(this.tb_Contains);
            this.Controls.Add(this.tb_Remove);
            this.Controls.Add(this.tb_Prepend);
            this.Controls.Add(this.tb_Append);
            this.Controls.Add(this.btn_RemoveAt);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_Contains);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Prepend);
            this.Controls.Add(this.btn_Append);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Ы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Append;
        private System.Windows.Forms.TextBox tb_Append;
        private System.Windows.Forms.TextBox tb_Prepend;
        private System.Windows.Forms.TextBox tb_Remove;
        private System.Windows.Forms.TextBox tb_Contains;
        private System.Windows.Forms.Button btn_Prepend;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_Contains;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_RemoveAt;
        private System.Windows.Forms.Button btn_FindAt;
        private System.Windows.Forms.Button btn_Sort;
        private System.Windows.Forms.Button btn_SetValue;
        private System.Windows.Forms.TextBox tb_Find;
        private System.Windows.Forms.TextBox tb_SetValueVal;
        private System.Windows.Forms.TextBox tb_RemoveAt;
        private System.Windows.Forms.TextBox tb_FindAt;
        private System.Windows.Forms.TextBox tb_SetValueInd;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

