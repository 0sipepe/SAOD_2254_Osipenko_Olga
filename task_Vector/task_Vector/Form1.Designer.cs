namespace task_Vector
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_At = new System.Windows.Forms.Button();
            this.btn_SetValue = new System.Windows.Forms.Button();
            this.btn_Resize = new System.Windows.Forms.Button();
            this.btn_Shrink = new System.Windows.Forms.Button();
            this.btn_Reserve = new System.Windows.Forms.Button();
            this.nud_defVal = new System.Windows.Forms.NumericUpDown();
            this.nud_Reserve = new System.Windows.Forms.NumericUpDown();
            this.nud_Length = new System.Windows.Forms.NumericUpDown();
            this.nud_Add = new System.Windows.Forms.NumericUpDown();
            this.nud_AtInd = new System.Windows.Forms.NumericUpDown();
            this.nud_AtVal = new System.Windows.Forms.NumericUpDown();
            this.nud_SetInd = new System.Windows.Forms.NumericUpDown();
            this.nud_SetVal = new System.Windows.Forms.NumericUpDown();
            this.nud_Resize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_defVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Reserve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AtInd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AtVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetInd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Resize)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 292);
            this.listBox1.TabIndex = 0;
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Create.Location = new System.Drawing.Point(116, 12);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(94, 23);
            this.btn_Create.TabIndex = 2;
            this.btn_Create.Text = "создать";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Add.Location = new System.Drawing.Point(116, 131);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_At
            // 
            this.btn_At.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_At.Location = new System.Drawing.Point(116, 206);
            this.btn_At.Name = "btn_At";
            this.btn_At.Size = new System.Drawing.Size(94, 23);
            this.btn_At.TabIndex = 4;
            this.btn_At.Text = "узнать";
            this.btn_At.UseVisualStyleBackColor = true;
            this.btn_At.Click += new System.EventHandler(this.btn_At_Click);
            // 
            // btn_SetValue
            // 
            this.btn_SetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btn_SetValue.Location = new System.Drawing.Point(216, 12);
            this.btn_SetValue.Name = "btn_SetValue";
            this.btn_SetValue.Size = new System.Drawing.Size(89, 23);
            this.btn_SetValue.TabIndex = 5;
            this.btn_SetValue.Text = "задать";
            this.btn_SetValue.UseVisualStyleBackColor = true;
            this.btn_SetValue.Click += new System.EventHandler(this.btn_SetValue_Click);
            // 
            // btn_Resize
            // 
            this.btn_Resize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Resize.Location = new System.Drawing.Point(216, 206);
            this.btn_Resize.Name = "btn_Resize";
            this.btn_Resize.Size = new System.Drawing.Size(89, 23);
            this.btn_Resize.TabIndex = 6;
            this.btn_Resize.Text = "+размер";
            this.btn_Resize.UseVisualStyleBackColor = true;
            this.btn_Resize.Click += new System.EventHandler(this.btn_Resize_Click);
            // 
            // btn_Shrink
            // 
            this.btn_Shrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Shrink.Location = new System.Drawing.Point(217, 277);
            this.btn_Shrink.Name = "btn_Shrink";
            this.btn_Shrink.Size = new System.Drawing.Size(89, 23);
            this.btn_Shrink.TabIndex = 7;
            this.btn_Shrink.Text = "обрезать";
            this.btn_Shrink.UseVisualStyleBackColor = true;
            this.btn_Shrink.Click += new System.EventHandler(this.btn_Shrink_Click);
            // 
            // btn_Reserve
            // 
            this.btn_Reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Reserve.Location = new System.Drawing.Point(216, 131);
            this.btn_Reserve.Name = "btn_Reserve";
            this.btn_Reserve.Size = new System.Drawing.Size(89, 23);
            this.btn_Reserve.TabIndex = 8;
            this.btn_Reserve.Text = "+резерв";
            this.btn_Reserve.UseVisualStyleBackColor = true;
            this.btn_Reserve.Click += new System.EventHandler(this.btn_Reserve_Click);
            // 
            // nud_defVal
            // 
            this.nud_defVal.Location = new System.Drawing.Point(117, 57);
            this.nud_defVal.Name = "nud_defVal";
            this.nud_defVal.Size = new System.Drawing.Size(94, 20);
            this.nud_defVal.TabIndex = 18;
            // 
            // nud_Reserve
            // 
            this.nud_Reserve.Location = new System.Drawing.Point(216, 178);
            this.nud_Reserve.Name = "nud_Reserve";
            this.nud_Reserve.Size = new System.Drawing.Size(89, 20);
            this.nud_Reserve.TabIndex = 19;
            // 
            // nud_Length
            // 
            this.nud_Length.Location = new System.Drawing.Point(116, 103);
            this.nud_Length.Name = "nud_Length";
            this.nud_Length.Size = new System.Drawing.Size(94, 20);
            this.nud_Length.TabIndex = 20;
            // 
            // nud_Add
            // 
            this.nud_Add.Location = new System.Drawing.Point(116, 178);
            this.nud_Add.Name = "nud_Add";
            this.nud_Add.Size = new System.Drawing.Size(94, 20);
            this.nud_Add.TabIndex = 21;
            // 
            // nud_AtInd
            // 
            this.nud_AtInd.Location = new System.Drawing.Point(117, 251);
            this.nud_AtInd.Name = "nud_AtInd";
            this.nud_AtInd.Size = new System.Drawing.Size(94, 20);
            this.nud_AtInd.TabIndex = 22;
            // 
            // nud_AtVal
            // 
            this.nud_AtVal.Location = new System.Drawing.Point(117, 277);
            this.nud_AtVal.Name = "nud_AtVal";
            this.nud_AtVal.Size = new System.Drawing.Size(94, 20);
            this.nud_AtVal.TabIndex = 23;
            // 
            // nud_SetInd
            // 
            this.nud_SetInd.Location = new System.Drawing.Point(217, 57);
            this.nud_SetInd.Name = "nud_SetInd";
            this.nud_SetInd.Size = new System.Drawing.Size(89, 20);
            this.nud_SetInd.TabIndex = 24;
            // 
            // nud_SetVal
            // 
            this.nud_SetVal.Location = new System.Drawing.Point(216, 103);
            this.nud_SetVal.Name = "nud_SetVal";
            this.nud_SetVal.Size = new System.Drawing.Size(89, 20);
            this.nud_SetVal.TabIndex = 25;
            // 
            // nud_Resize
            // 
            this.nud_Resize.Location = new System.Drawing.Point(217, 251);
            this.nud_Resize.Name = "nud_Resize";
            this.nud_Resize.Size = new System.Drawing.Size(89, 20);
            this.nud_Resize.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "ВЕКТОР СОЗДАН!";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "вместимость:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(168, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "размер:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(110, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 23);
            this.label4.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(239, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 23);
            this.label5.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "базовое значение вектора:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(224, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(224, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 23);
            this.label8.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(116, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "дефолтное ";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(213, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "какой";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(217, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "какой";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(117, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "значение";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(117, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "длина";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(216, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "значение";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(217, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 16);
            this.label16.TabIndex = 42;
            this.label16.Text = "индекс";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(116, 232);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "индекс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 419);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Resize);
            this.Controls.Add(this.nud_SetVal);
            this.Controls.Add(this.nud_SetInd);
            this.Controls.Add(this.nud_AtVal);
            this.Controls.Add(this.nud_AtInd);
            this.Controls.Add(this.nud_Add);
            this.Controls.Add(this.nud_Length);
            this.Controls.Add(this.nud_Reserve);
            this.Controls.Add(this.nud_defVal);
            this.Controls.Add(this.btn_Reserve);
            this.Controls.Add(this.btn_Shrink);
            this.Controls.Add(this.btn_Resize);
            this.Controls.Add(this.btn_SetValue);
            this.Controls.Add(this.btn_At);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_defVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Reserve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AtInd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AtVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetInd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SetVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Resize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_At;
        private System.Windows.Forms.Button btn_SetValue;
        private System.Windows.Forms.Button btn_Resize;
        private System.Windows.Forms.Button btn_Shrink;
        private System.Windows.Forms.Button btn_Reserve;
        private System.Windows.Forms.NumericUpDown nud_defVal;
        private System.Windows.Forms.NumericUpDown nud_Reserve;
        private System.Windows.Forms.NumericUpDown nud_Length;
        private System.Windows.Forms.NumericUpDown nud_Add;
        private System.Windows.Forms.NumericUpDown nud_AtInd;
        private System.Windows.Forms.NumericUpDown nud_AtVal;
        private System.Windows.Forms.NumericUpDown nud_SetInd;
        private System.Windows.Forms.NumericUpDown nud_SetVal;
        private System.Windows.Forms.NumericUpDown nud_Resize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}

