namespace BART
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSubnum = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "男性",
            "女性"});
            this.comboBox2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "男性",
            "女性"});
            this.comboBox2.Location = new System.Drawing.Point(214, 75);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox2.Size = new System.Drawing.Size(83, 27);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "男性";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "123";
            this.comboBox1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBox1.Items.AddRange(new object[] {
            "博士",
            "碩士",
            "大學",
            "高中職",
            "國中",
            "國小"});
            this.comboBox1.Location = new System.Drawing.Point(214, 166);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 27);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "大學";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(5, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "教育程度 (Education)：";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.AutoSize = true;
            this.numericUpDown1.Font = new System.Drawing.Font("新細明體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDown1.Location = new System.Drawing.Point(214, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(83, 28);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            1992,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(108, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSubnum
            // 
            this.textBoxSubnum.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBoxSubnum.Location = new System.Drawing.Point(156, 27);
            this.textBoxSubnum.Name = "textBoxSubnum";
            this.textBoxSubnum.Size = new System.Drawing.Size(141, 30);
            this.textBoxSubnum.TabIndex = 1;
            // 
            // Age
            // 
            this.Age.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Age.AutoSize = true;
            this.Age.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Age.Location = new System.Drawing.Point(5, 123);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(213, 19);
            this.Age.TabIndex = 0;
            this.Age.Text = "出生西元年 (Birth year)：";
            // 
            // Gender
            // 
            this.Gender.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gender.Location = new System.Drawing.Point(5, 80);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(193, 19);
            this.Gender.TabIndex = 0;
            this.Gender.Text = "受試者性別 (Gender)：";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number.Location = new System.Drawing.Point(5, 33);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(154, 19);
            this.Number.TabIndex = 0;
            this.Number.Text = "受試者編號(ID)：";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 266);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSubnum);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.Number);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "實驗參與者資料";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Age;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label Number;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.TextBox textBoxSubnum;
    }
}