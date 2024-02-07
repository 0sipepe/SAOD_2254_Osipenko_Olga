namespace task_MyTree
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_CLR = new System.Windows.Forms.Button();
            this.btn_LCR = new System.Windows.Forms.Button();
            this.btn_RCL = new System.Windows.Forms.Button();
            this.btn_Across = new System.Windows.Forms.Button();
            this.tb_LCR = new System.Windows.Forms.TextBox();
            this.tb_RCL = new System.Windows.Forms.TextBox();
            this.tb_CLR = new System.Windows.Forms.TextBox();
            this.tb_Across = new System.Windows.Forms.TextBox();
            this.nud_Remove = new System.Windows.Forms.NumericUpDown();
            this.nud_Add = new System.Windows.Forms.NumericUpDown();
            this.btn_ToList = new System.Windows.Forms.Button();
            this.tb_ToList = new System.Windows.Forms.TextBox();
            this.btn_Contains = new System.Windows.Forms.Button();
            this.nud_Contains = new System.Windows.Forms.NumericUpDown();
            this.nud_ContainsKey = new System.Windows.Forms.NumericUpDown();
            this.btn_ContainsKey = new System.Windows.Forms.Button();
            this.tb_ToListValues = new System.Windows.Forms.TextBox();
            this.btn_ToListDict = new System.Windows.Forms.Button();
            this.nud_AddKey = new System.Windows.Forms.NumericUpDown();
            this.nud_RemoveKey = new System.Windows.Forms.NumericUpDown();
            this.tb_AcrossDict = new System.Windows.Forms.TextBox();
            this.tb_CLRDict = new System.Windows.Forms.TextBox();
            this.tb_RCLDict = new System.Windows.Forms.TextBox();
            this.tb_LCRDict = new System.Windows.Forms.TextBox();
            this.btn_AcrossDict = new System.Windows.Forms.Button();
            this.btn_RCLDict = new System.Windows.Forms.Button();
            this.btn_LCRDict = new System.Windows.Forms.Button();
            this.btn_CLRDict = new System.Windows.Forms.Button();
            this.btn_RemoveDict = new System.Windows.Forms.Button();
            this.btn_AddDict = new System.Windows.Forms.Button();
            this.tb_AddValue = new System.Windows.Forms.TextBox();
            this.tb_ContainsValue = new System.Windows.Forms.TextBox();
            this.btn_ContainsValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Contains)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ContainsKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AddKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RemoveKey)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(17, 24);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 35);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(17, 65);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(85, 29);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "удалить";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_CLR
            // 
            this.btn_CLR.Location = new System.Drawing.Point(17, 216);
            this.btn_CLR.Name = "btn_CLR";
            this.btn_CLR.Size = new System.Drawing.Size(85, 22);
            this.btn_CLR.TabIndex = 6;
            this.btn_CLR.Text = "CLR";
            this.btn_CLR.UseVisualStyleBackColor = true;
            this.btn_CLR.Click += new System.EventHandler(this.btn_CLR_Click);
            // 
            // btn_LCR
            // 
            this.btn_LCR.Location = new System.Drawing.Point(17, 158);
            this.btn_LCR.Name = "btn_LCR";
            this.btn_LCR.Size = new System.Drawing.Size(85, 22);
            this.btn_LCR.TabIndex = 7;
            this.btn_LCR.Text = "LCR";
            this.btn_LCR.UseVisualStyleBackColor = true;
            this.btn_LCR.Click += new System.EventHandler(this.btn_LCR_Click);
            // 
            // btn_RCL
            // 
            this.btn_RCL.Location = new System.Drawing.Point(17, 187);
            this.btn_RCL.Name = "btn_RCL";
            this.btn_RCL.Size = new System.Drawing.Size(85, 22);
            this.btn_RCL.TabIndex = 8;
            this.btn_RCL.Text = "RCL";
            this.btn_RCL.UseVisualStyleBackColor = true;
            this.btn_RCL.Click += new System.EventHandler(this.btn_RCL_Click);
            // 
            // btn_Across
            // 
            this.btn_Across.Location = new System.Drawing.Point(17, 245);
            this.btn_Across.Name = "btn_Across";
            this.btn_Across.Size = new System.Drawing.Size(85, 22);
            this.btn_Across.TabIndex = 9;
            this.btn_Across.Text = "Across";
            this.btn_Across.UseVisualStyleBackColor = true;
            this.btn_Across.Click += new System.EventHandler(this.btn_Across_Click);
            // 
            // tb_LCR
            // 
            this.tb_LCR.Location = new System.Drawing.Point(108, 158);
            this.tb_LCR.Name = "tb_LCR";
            this.tb_LCR.Size = new System.Drawing.Size(153, 22);
            this.tb_LCR.TabIndex = 10;
            // 
            // tb_RCL
            // 
            this.tb_RCL.Location = new System.Drawing.Point(108, 187);
            this.tb_RCL.Name = "tb_RCL";
            this.tb_RCL.Size = new System.Drawing.Size(153, 22);
            this.tb_RCL.TabIndex = 11;
            // 
            // tb_CLR
            // 
            this.tb_CLR.Location = new System.Drawing.Point(108, 216);
            this.tb_CLR.Name = "tb_CLR";
            this.tb_CLR.Size = new System.Drawing.Size(153, 22);
            this.tb_CLR.TabIndex = 12;
            // 
            // tb_Across
            // 
            this.tb_Across.Location = new System.Drawing.Point(108, 245);
            this.tb_Across.Name = "tb_Across";
            this.tb_Across.Size = new System.Drawing.Size(153, 22);
            this.tb_Across.TabIndex = 13;
            // 
            // nud_Remove
            // 
            this.nud_Remove.Location = new System.Drawing.Point(108, 72);
            this.nud_Remove.Name = "nud_Remove";
            this.nud_Remove.Size = new System.Drawing.Size(120, 22);
            this.nud_Remove.TabIndex = 14;
            // 
            // nud_Add
            // 
            this.nud_Add.Location = new System.Drawing.Point(108, 37);
            this.nud_Add.Name = "nud_Add";
            this.nud_Add.Size = new System.Drawing.Size(120, 22);
            this.nud_Add.TabIndex = 15;
            // 
            // btn_ToList
            // 
            this.btn_ToList.Location = new System.Drawing.Point(17, 286);
            this.btn_ToList.Name = "btn_ToList";
            this.btn_ToList.Size = new System.Drawing.Size(85, 21);
            this.btn_ToList.TabIndex = 16;
            this.btn_ToList.Text = "В список";
            this.btn_ToList.UseVisualStyleBackColor = true;
            this.btn_ToList.Click += new System.EventHandler(this.btn_ToList_Click);
            // 
            // tb_ToList
            // 
            this.tb_ToList.Location = new System.Drawing.Point(108, 285);
            this.tb_ToList.Name = "tb_ToList";
            this.tb_ToList.Size = new System.Drawing.Size(153, 22);
            this.tb_ToList.TabIndex = 17;
            // 
            // btn_Contains
            // 
            this.btn_Contains.Location = new System.Drawing.Point(17, 102);
            this.btn_Contains.Name = "btn_Contains";
            this.btn_Contains.Size = new System.Drawing.Size(85, 22);
            this.btn_Contains.TabIndex = 18;
            this.btn_Contains.Text = "есть ли";
            this.btn_Contains.UseVisualStyleBackColor = true;
            this.btn_Contains.Click += new System.EventHandler(this.btn_Contains_Click);
            // 
            // nud_Contains
            // 
            this.nud_Contains.Location = new System.Drawing.Point(108, 100);
            this.nud_Contains.Name = "nud_Contains";
            this.nud_Contains.Size = new System.Drawing.Size(120, 22);
            this.nud_Contains.TabIndex = 19;
            // 
            // nud_ContainsKey
            // 
            this.nud_ContainsKey.Location = new System.Drawing.Point(484, 106);
            this.nud_ContainsKey.Name = "nud_ContainsKey";
            this.nud_ContainsKey.Size = new System.Drawing.Size(153, 22);
            this.nud_ContainsKey.TabIndex = 35;
            // 
            // btn_ContainsKey
            // 
            this.btn_ContainsKey.Location = new System.Drawing.Point(393, 108);
            this.btn_ContainsKey.Name = "btn_ContainsKey";
            this.btn_ContainsKey.Size = new System.Drawing.Size(85, 22);
            this.btn_ContainsKey.TabIndex = 34;
            this.btn_ContainsKey.Text = "есть ли";
            this.btn_ContainsKey.UseVisualStyleBackColor = true;
            this.btn_ContainsKey.Click += new System.EventHandler(this.btn_ContainsKey_Click);
            // 
            // tb_ToListValues
            // 
            this.tb_ToListValues.Location = new System.Drawing.Point(484, 291);
            this.tb_ToListValues.Name = "tb_ToListValues";
            this.tb_ToListValues.Size = new System.Drawing.Size(153, 22);
            this.tb_ToListValues.TabIndex = 33;
            // 
            // btn_ToListDict
            // 
            this.btn_ToListDict.Location = new System.Drawing.Point(393, 292);
            this.btn_ToListDict.Name = "btn_ToListDict";
            this.btn_ToListDict.Size = new System.Drawing.Size(85, 21);
            this.btn_ToListDict.TabIndex = 32;
            this.btn_ToListDict.Text = "В список";
            this.btn_ToListDict.UseVisualStyleBackColor = true;
            this.btn_ToListDict.Click += new System.EventHandler(this.btn_ToListDict_Click);
            // 
            // nud_AddKey
            // 
            this.nud_AddKey.Location = new System.Drawing.Point(484, 43);
            this.nud_AddKey.Name = "nud_AddKey";
            this.nud_AddKey.Size = new System.Drawing.Size(81, 22);
            this.nud_AddKey.TabIndex = 31;
            // 
            // nud_RemoveKey
            // 
            this.nud_RemoveKey.Location = new System.Drawing.Point(484, 78);
            this.nud_RemoveKey.Name = "nud_RemoveKey";
            this.nud_RemoveKey.Size = new System.Drawing.Size(153, 22);
            this.nud_RemoveKey.TabIndex = 30;
            // 
            // tb_AcrossDict
            // 
            this.tb_AcrossDict.Location = new System.Drawing.Point(484, 251);
            this.tb_AcrossDict.Name = "tb_AcrossDict";
            this.tb_AcrossDict.Size = new System.Drawing.Size(153, 22);
            this.tb_AcrossDict.TabIndex = 29;
            // 
            // tb_CLRDict
            // 
            this.tb_CLRDict.Location = new System.Drawing.Point(484, 222);
            this.tb_CLRDict.Name = "tb_CLRDict";
            this.tb_CLRDict.Size = new System.Drawing.Size(153, 22);
            this.tb_CLRDict.TabIndex = 28;
            // 
            // tb_RCLDict
            // 
            this.tb_RCLDict.Location = new System.Drawing.Point(484, 193);
            this.tb_RCLDict.Name = "tb_RCLDict";
            this.tb_RCLDict.Size = new System.Drawing.Size(153, 22);
            this.tb_RCLDict.TabIndex = 27;
            // 
            // tb_LCRDict
            // 
            this.tb_LCRDict.Location = new System.Drawing.Point(484, 164);
            this.tb_LCRDict.Name = "tb_LCRDict";
            this.tb_LCRDict.Size = new System.Drawing.Size(153, 22);
            this.tb_LCRDict.TabIndex = 26;
            // 
            // btn_AcrossDict
            // 
            this.btn_AcrossDict.Location = new System.Drawing.Point(393, 251);
            this.btn_AcrossDict.Name = "btn_AcrossDict";
            this.btn_AcrossDict.Size = new System.Drawing.Size(85, 22);
            this.btn_AcrossDict.TabIndex = 25;
            this.btn_AcrossDict.Text = "Across";
            this.btn_AcrossDict.UseVisualStyleBackColor = true;
            this.btn_AcrossDict.Click += new System.EventHandler(this.btn_AcrossDict_Click);
            // 
            // btn_RCLDict
            // 
            this.btn_RCLDict.Location = new System.Drawing.Point(393, 193);
            this.btn_RCLDict.Name = "btn_RCLDict";
            this.btn_RCLDict.Size = new System.Drawing.Size(85, 22);
            this.btn_RCLDict.TabIndex = 24;
            this.btn_RCLDict.Text = "RCL";
            this.btn_RCLDict.UseVisualStyleBackColor = true;
            this.btn_RCLDict.Click += new System.EventHandler(this.btn_RCLDict_Click);
            // 
            // btn_LCRDict
            // 
            this.btn_LCRDict.Location = new System.Drawing.Point(393, 164);
            this.btn_LCRDict.Name = "btn_LCRDict";
            this.btn_LCRDict.Size = new System.Drawing.Size(85, 22);
            this.btn_LCRDict.TabIndex = 23;
            this.btn_LCRDict.Text = "LCR";
            this.btn_LCRDict.UseVisualStyleBackColor = true;
            this.btn_LCRDict.Click += new System.EventHandler(this.btn_LCRDict_Click);
            // 
            // btn_CLRDict
            // 
            this.btn_CLRDict.Location = new System.Drawing.Point(393, 222);
            this.btn_CLRDict.Name = "btn_CLRDict";
            this.btn_CLRDict.Size = new System.Drawing.Size(85, 22);
            this.btn_CLRDict.TabIndex = 22;
            this.btn_CLRDict.Text = "CLR";
            this.btn_CLRDict.UseVisualStyleBackColor = true;
            this.btn_CLRDict.Click += new System.EventHandler(this.btn_CLRDict_Click);
            // 
            // btn_RemoveDict
            // 
            this.btn_RemoveDict.Location = new System.Drawing.Point(393, 71);
            this.btn_RemoveDict.Name = "btn_RemoveDict";
            this.btn_RemoveDict.Size = new System.Drawing.Size(85, 29);
            this.btn_RemoveDict.TabIndex = 21;
            this.btn_RemoveDict.Text = "удалить";
            this.btn_RemoveDict.UseVisualStyleBackColor = true;
            this.btn_RemoveDict.Click += new System.EventHandler(this.btn_RemoveDict_Click);
            // 
            // btn_AddDict
            // 
            this.btn_AddDict.Location = new System.Drawing.Point(393, 30);
            this.btn_AddDict.Name = "btn_AddDict";
            this.btn_AddDict.Size = new System.Drawing.Size(85, 35);
            this.btn_AddDict.TabIndex = 20;
            this.btn_AddDict.Text = "добавить";
            this.btn_AddDict.UseVisualStyleBackColor = true;
            this.btn_AddDict.Click += new System.EventHandler(this.btn_AddDict_Click);
            // 
            // tb_AddValue
            // 
            this.tb_AddValue.Location = new System.Drawing.Point(571, 43);
            this.tb_AddValue.Name = "tb_AddValue";
            this.tb_AddValue.Size = new System.Drawing.Size(66, 22);
            this.tb_AddValue.TabIndex = 36;
            // 
            // tb_ContainsValue
            // 
            this.tb_ContainsValue.Location = new System.Drawing.Point(484, 134);
            this.tb_ContainsValue.Name = "tb_ContainsValue";
            this.tb_ContainsValue.Size = new System.Drawing.Size(153, 22);
            this.tb_ContainsValue.TabIndex = 50;
            // 
            // btn_ContainsValue
            // 
            this.btn_ContainsValue.Location = new System.Drawing.Point(393, 134);
            this.btn_ContainsValue.Name = "btn_ContainsValue";
            this.btn_ContainsValue.Size = new System.Drawing.Size(85, 22);
            this.btn_ContainsValue.TabIndex = 48;
            this.btn_ContainsValue.Text = "есть ли";
            this.btn_ContainsValue.UseVisualStyleBackColor = true;
            this.btn_ContainsValue.Click += new System.EventHandler(this.btn_ContainsValue_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(484, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "key";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(571, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ContainsValue);
            this.Controls.Add(this.btn_ContainsValue);
            this.Controls.Add(this.tb_AddValue);
            this.Controls.Add(this.nud_ContainsKey);
            this.Controls.Add(this.btn_ContainsKey);
            this.Controls.Add(this.tb_ToListValues);
            this.Controls.Add(this.btn_ToListDict);
            this.Controls.Add(this.nud_AddKey);
            this.Controls.Add(this.nud_RemoveKey);
            this.Controls.Add(this.tb_AcrossDict);
            this.Controls.Add(this.tb_CLRDict);
            this.Controls.Add(this.tb_RCLDict);
            this.Controls.Add(this.tb_LCRDict);
            this.Controls.Add(this.btn_AcrossDict);
            this.Controls.Add(this.btn_RCLDict);
            this.Controls.Add(this.btn_LCRDict);
            this.Controls.Add(this.btn_CLRDict);
            this.Controls.Add(this.btn_RemoveDict);
            this.Controls.Add(this.btn_AddDict);
            this.Controls.Add(this.nud_Contains);
            this.Controls.Add(this.btn_Contains);
            this.Controls.Add(this.tb_ToList);
            this.Controls.Add(this.btn_ToList);
            this.Controls.Add(this.nud_Add);
            this.Controls.Add(this.nud_Remove);
            this.Controls.Add(this.tb_Across);
            this.Controls.Add(this.tb_CLR);
            this.Controls.Add(this.tb_RCL);
            this.Controls.Add(this.tb_LCR);
            this.Controls.Add(this.btn_Across);
            this.Controls.Add(this.btn_RCL);
            this.Controls.Add(this.btn_LCR);
            this.Controls.Add(this.btn_CLR);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "3";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Contains)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_ContainsKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_AddKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RemoveKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_CLR;
        private System.Windows.Forms.Button btn_LCR;
        private System.Windows.Forms.Button btn_RCL;
        private System.Windows.Forms.Button btn_Across;
        private System.Windows.Forms.TextBox tb_LCR;
        private System.Windows.Forms.TextBox tb_RCL;
        private System.Windows.Forms.TextBox tb_CLR;
        private System.Windows.Forms.TextBox tb_Across;
        private System.Windows.Forms.NumericUpDown nud_Remove;
        private System.Windows.Forms.NumericUpDown nud_Add;
        private System.Windows.Forms.Button btn_ToList;
        private System.Windows.Forms.TextBox tb_ToList;
        private System.Windows.Forms.Button btn_Contains;
        private System.Windows.Forms.NumericUpDown nud_Contains;
        private System.Windows.Forms.NumericUpDown nud_ContainsKey;
        private System.Windows.Forms.Button btn_ContainsKey;
        private System.Windows.Forms.TextBox tb_ToListValues;
        private System.Windows.Forms.Button btn_ToListDict;
        private System.Windows.Forms.NumericUpDown nud_AddKey;
        private System.Windows.Forms.NumericUpDown nud_RemoveKey;
        private System.Windows.Forms.TextBox tb_AcrossDict;
        private System.Windows.Forms.TextBox tb_CLRDict;
        private System.Windows.Forms.TextBox tb_RCLDict;
        private System.Windows.Forms.TextBox tb_LCRDict;
        private System.Windows.Forms.Button btn_AcrossDict;
        private System.Windows.Forms.Button btn_RCLDict;
        private System.Windows.Forms.Button btn_LCRDict;
        private System.Windows.Forms.Button btn_CLRDict;
        private System.Windows.Forms.Button btn_RemoveDict;
        private System.Windows.Forms.Button btn_AddDict;
        private System.Windows.Forms.TextBox tb_AddValue;
        private System.Windows.Forms.TextBox tb_ContainsValue;
        private System.Windows.Forms.Button btn_ContainsValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

