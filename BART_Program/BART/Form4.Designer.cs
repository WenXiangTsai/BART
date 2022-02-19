namespace BART
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TrialsSetting = new System.Windows.Forms.TextBox();
            this.EndTypeSetting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PracticeSetting = new System.Windows.Forms.TextBox();
            this.VoiceSetting = new System.Windows.Forms.TextBox();
            this.DelaySetting = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MaxLifeSetting = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Max Life：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "End Type：\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(15, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trials：";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(91, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TrialsSetting
            // 
            this.TrialsSetting.Location = new System.Drawing.Point(148, 88);
            this.TrialsSetting.Name = "TrialsSetting";
            this.TrialsSetting.Size = new System.Drawing.Size(100, 27);
            this.TrialsSetting.TabIndex = 3;
            this.TrialsSetting.Text = "30";
            this.TrialsSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EndTypeSetting
            // 
            this.EndTypeSetting.Location = new System.Drawing.Point(148, 51);
            this.EndTypeSetting.Name = "EndTypeSetting";
            this.EndTypeSetting.Size = new System.Drawing.Size(100, 27);
            this.EndTypeSetting.TabIndex = 2;
            this.EndTypeSetting.Text = "0";
            this.EndTypeSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 11);
            this.label4.TabIndex = 0;
            this.label4.Text = "(0 = standard; 1 = collection)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pratice：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sound：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Delay Time(s)：";
            // 
            // PracticeSetting
            // 
            this.PracticeSetting.Location = new System.Drawing.Point(148, 125);
            this.PracticeSetting.Name = "PracticeSetting";
            this.PracticeSetting.Size = new System.Drawing.Size(100, 27);
            this.PracticeSetting.TabIndex = 4;
            this.PracticeSetting.Text = "0";
            this.PracticeSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VoiceSetting
            // 
            this.VoiceSetting.Location = new System.Drawing.Point(148, 161);
            this.VoiceSetting.Name = "VoiceSetting";
            this.VoiceSetting.Size = new System.Drawing.Size(100, 27);
            this.VoiceSetting.TabIndex = 5;
            this.VoiceSetting.Text = "1";
            this.VoiceSetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelaySetting
            // 
            this.DelaySetting.Location = new System.Drawing.Point(148, 197);
            this.DelaySetting.Name = "DelaySetting";
            this.DelaySetting.Size = new System.Drawing.Size(100, 27);
            this.DelaySetting.TabIndex = 6;
            this.DelaySetting.Text = "0.5";
            this.DelaySetting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(17, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 11);
            this.label8.TabIndex = 0;
            this.label8.Text = "(0 = on; 1 = off)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("新細明體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(16, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 11);
            this.label9.TabIndex = 0;
            this.label9.Text = "(0 = on; 1 = off)";
            // 
            // MaxLifeSetting
            // 
            this.MaxLifeSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaxLifeSetting.FormattingEnabled = true;
            this.MaxLifeSetting.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "96",
            "128"});
            this.MaxLifeSetting.Location = new System.Drawing.Point(148, 16);
            this.MaxLifeSetting.Name = "MaxLifeSetting";
            this.MaxLifeSetting.Size = new System.Drawing.Size(101, 24);
            this.MaxLifeSetting.TabIndex = 9;
            this.MaxLifeSetting.SelectedIndexChanged += new System.EventHandler(this.MaxLifeSetting_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 285);
            this.ControlBox = false;
            this.Controls.Add(this.MaxLifeSetting);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DelaySetting);
            this.Controls.Add(this.VoiceSetting);
            this.Controls.Add(this.PracticeSetting);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndTypeSetting);
            this.Controls.Add(this.TrialsSetting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parameter Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TrialsSetting;
        public System.Windows.Forms.TextBox EndTypeSetting;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox PracticeSetting;
        public System.Windows.Forms.TextBox VoiceSetting;
        public System.Windows.Forms.TextBox DelaySetting;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox MaxLifeSetting;
    }
}