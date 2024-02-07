namespace task_HashTable
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
            this.btn_ValueByKey = new System.Windows.Forms.Button();
            this.btn_KBV = new System.Windows.Forms.Button();
            this.btn_ContainsKey = new System.Windows.Forms.Button();
            this.btn_ContainsValue = new System.Windows.Forms.Button();
            this.btn_ListKeys = new System.Windows.Forms.Button();
            this.btn_ListValues = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AddKey = new System.Windows.Forms.TextBox();
            this.tb_AddValue = new System.Windows.Forms.TextBox();
            this.tb_Remove = new System.Windows.Forms.TextBox();
            this.tb_VBKKey = new System.Windows.Forms.TextBox();
            this.tb_KBVValue = new System.Windows.Forms.TextBox();
            this.tb_ContainsKey = new System.Windows.Forms.TextBox();
            this.tb_ContainsValue = new System.Windows.Forms.TextBox();
            this.tb_ListKeys = new System.Windows.Forms.TextBox();
            this.tb_ListValue = new System.Windows.Forms.TextBox();
            this.lb_Count = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_VBKValue = new System.Windows.Forms.TextBox();
            this.tb_KBVKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(31, 21);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(163, 35);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(31, 62);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(163, 35);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_ValueByKey
            // 
            this.btn_ValueByKey.Location = new System.Drawing.Point(31, 103);
            this.btn_ValueByKey.Name = "btn_ValueByKey";
            this.btn_ValueByKey.Size = new System.Drawing.Size(163, 35);
            this.btn_ValueByKey.TabIndex = 2;
            this.btn_ValueByKey.Text = "Value By Key";
            this.btn_ValueByKey.UseVisualStyleBackColor = true;
            this.btn_ValueByKey.Click += new System.EventHandler(this.btn_ValueByKey_Click);
            // 
            // btn_KBV
            // 
            this.btn_KBV.Location = new System.Drawing.Point(31, 144);
            this.btn_KBV.Name = "btn_KBV";
            this.btn_KBV.Size = new System.Drawing.Size(163, 35);
            this.btn_KBV.TabIndex = 3;
            this.btn_KBV.Text = "Key By Value";
            this.btn_KBV.UseVisualStyleBackColor = true;
            this.btn_KBV.Click += new System.EventHandler(this.btn_KBV_Click);
            // 
            // btn_ContainsKey
            // 
            this.btn_ContainsKey.Location = new System.Drawing.Point(31, 185);
            this.btn_ContainsKey.Name = "btn_ContainsKey";
            this.btn_ContainsKey.Size = new System.Drawing.Size(163, 35);
            this.btn_ContainsKey.TabIndex = 4;
            this.btn_ContainsKey.Text = "Contains Key";
            this.btn_ContainsKey.UseVisualStyleBackColor = true;
            this.btn_ContainsKey.Click += new System.EventHandler(this.btn_ContainsKey_Click);
            // 
            // btn_ContainsValue
            // 
            this.btn_ContainsValue.Location = new System.Drawing.Point(31, 226);
            this.btn_ContainsValue.Name = "btn_ContainsValue";
            this.btn_ContainsValue.Size = new System.Drawing.Size(163, 35);
            this.btn_ContainsValue.TabIndex = 5;
            this.btn_ContainsValue.Text = "Contains Value";
            this.btn_ContainsValue.UseVisualStyleBackColor = true;
            this.btn_ContainsValue.Click += new System.EventHandler(this.btn_ContainsValue_Click);
            // 
            // btn_ListKeys
            // 
            this.btn_ListKeys.Location = new System.Drawing.Point(31, 267);
            this.btn_ListKeys.Name = "btn_ListKeys";
            this.btn_ListKeys.Size = new System.Drawing.Size(163, 35);
            this.btn_ListKeys.TabIndex = 6;
            this.btn_ListKeys.Text = "Keys";
            this.btn_ListKeys.UseVisualStyleBackColor = true;
            this.btn_ListKeys.Click += new System.EventHandler(this.btn_ListKeys_Click);
            // 
            // btn_ListValues
            // 
            this.btn_ListValues.Location = new System.Drawing.Point(31, 308);
            this.btn_ListValues.Name = "btn_ListValues";
            this.btn_ListValues.Size = new System.Drawing.Size(163, 35);
            this.btn_ListValues.TabIndex = 7;
            this.btn_ListValues.Text = "Values";
            this.btn_ListValues.UseVisualStyleBackColor = true;
            this.btn_ListValues.Click += new System.EventHandler(this.btn_ListValues_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(31, 349);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(163, 35);
            this.btn_Clear.TabIndex = 8;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "COUNT:";
            // 
            // tb_AddKey
            // 
            this.tb_AddKey.Location = new System.Drawing.Point(209, 34);
            this.tb_AddKey.Name = "tb_AddKey";
            this.tb_AddKey.Size = new System.Drawing.Size(100, 22);
            this.tb_AddKey.TabIndex = 10;
            // 
            // tb_AddValue
            // 
            this.tb_AddValue.Location = new System.Drawing.Point(315, 34);
            this.tb_AddValue.Name = "tb_AddValue";
            this.tb_AddValue.Size = new System.Drawing.Size(100, 22);
            this.tb_AddValue.TabIndex = 11;
            // 
            // tb_Remove
            // 
            this.tb_Remove.Location = new System.Drawing.Point(209, 75);
            this.tb_Remove.Name = "tb_Remove";
            this.tb_Remove.Size = new System.Drawing.Size(100, 22);
            this.tb_Remove.TabIndex = 12;
            // 
            // tb_VBKKey
            // 
            this.tb_VBKKey.Location = new System.Drawing.Point(209, 116);
            this.tb_VBKKey.Name = "tb_VBKKey";
            this.tb_VBKKey.Size = new System.Drawing.Size(100, 22);
            this.tb_VBKKey.TabIndex = 13;
            // 
            // tb_KBVValue
            // 
            this.tb_KBVValue.Location = new System.Drawing.Point(209, 157);
            this.tb_KBVValue.Name = "tb_KBVValue";
            this.tb_KBVValue.Size = new System.Drawing.Size(100, 22);
            this.tb_KBVValue.TabIndex = 14;
            // 
            // tb_ContainsKey
            // 
            this.tb_ContainsKey.Location = new System.Drawing.Point(209, 198);
            this.tb_ContainsKey.Name = "tb_ContainsKey";
            this.tb_ContainsKey.Size = new System.Drawing.Size(100, 22);
            this.tb_ContainsKey.TabIndex = 15;
            // 
            // tb_ContainsValue
            // 
            this.tb_ContainsValue.Location = new System.Drawing.Point(209, 239);
            this.tb_ContainsValue.Name = "tb_ContainsValue";
            this.tb_ContainsValue.Size = new System.Drawing.Size(100, 22);
            this.tb_ContainsValue.TabIndex = 16;
            // 
            // tb_ListKeys
            // 
            this.tb_ListKeys.Location = new System.Drawing.Point(209, 280);
            this.tb_ListKeys.Name = "tb_ListKeys";
            this.tb_ListKeys.Size = new System.Drawing.Size(100, 22);
            this.tb_ListKeys.TabIndex = 17;
            // 
            // tb_ListValue
            // 
            this.tb_ListValue.Location = new System.Drawing.Point(209, 321);
            this.tb_ListValue.Name = "tb_ListValue";
            this.tb_ListValue.Size = new System.Drawing.Size(196, 22);
            this.tb_ListValue.TabIndex = 18;
            // 
            // lb_Count
            // 
            this.lb_Count.Location = new System.Drawing.Point(206, 387);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(166, 33);
            this.lb_Count.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(206, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "key";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(316, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "value";
            // 
            // tb_VBKValue
            // 
            this.tb_VBKValue.Location = new System.Drawing.Point(319, 116);
            this.tb_VBKValue.Name = "tb_VBKValue";
            this.tb_VBKValue.Size = new System.Drawing.Size(100, 22);
            this.tb_VBKValue.TabIndex = 24;
            // 
            // tb_KBVKey
            // 
            this.tb_KBVKey.Location = new System.Drawing.Point(319, 157);
            this.tb_KBVKey.Name = "tb_KBVKey";
            this.tb_KBVKey.Size = new System.Drawing.Size(100, 22);
            this.tb_KBVKey.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 440);
            this.Controls.Add(this.tb_KBVKey);
            this.Controls.Add(this.tb_VBKValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Count);
            this.Controls.Add(this.tb_ListValue);
            this.Controls.Add(this.tb_ListKeys);
            this.Controls.Add(this.tb_ContainsValue);
            this.Controls.Add(this.tb_ContainsKey);
            this.Controls.Add(this.tb_KBVValue);
            this.Controls.Add(this.tb_VBKKey);
            this.Controls.Add(this.tb_Remove);
            this.Controls.Add(this.tb_AddValue);
            this.Controls.Add(this.tb_AddKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_ListValues);
            this.Controls.Add(this.btn_ListKeys);
            this.Controls.Add(this.btn_ContainsValue);
            this.Controls.Add(this.btn_ContainsKey);
            this.Controls.Add(this.btn_KBV);
            this.Controls.Add(this.btn_ValueByKey);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_ValueByKey;
        private System.Windows.Forms.Button btn_KBV;
        private System.Windows.Forms.Button btn_ContainsKey;
        private System.Windows.Forms.Button btn_ContainsValue;
        private System.Windows.Forms.Button btn_ListKeys;
        private System.Windows.Forms.Button btn_ListValues;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AddKey;
        private System.Windows.Forms.TextBox tb_AddValue;
        private System.Windows.Forms.TextBox tb_Remove;
        private System.Windows.Forms.TextBox tb_VBKKey;
        private System.Windows.Forms.TextBox tb_KBVValue;
        private System.Windows.Forms.TextBox tb_ContainsKey;
        private System.Windows.Forms.TextBox tb_ContainsValue;
        private System.Windows.Forms.TextBox tb_ListKeys;
        private System.Windows.Forms.TextBox tb_ListValue;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_VBKValue;
        private System.Windows.Forms.TextBox tb_KBVKey;
    }
}

