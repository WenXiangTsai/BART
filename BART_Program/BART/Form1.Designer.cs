namespace BART
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LastEarned = new System.Windows.Forms.Label();
            this.TotalEarned = new System.Windows.Forms.Label();
            this.Pump = new System.Windows.Forms.Button();
            this.Collect = new System.Windows.Forms.Button();
            this.label_Wait = new System.Windows.Forms.Label();
            this.label_Burst = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LastEarned
            // 
            this.LastEarned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastEarned.Font = new System.Drawing.Font("新細明體", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LastEarned.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastEarned.Location = new System.Drawing.Point(665, 592);
            this.LastEarned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastEarned.Name = "LastEarned";
            this.LastEarned.Size = new System.Drawing.Size(350, 50);
            this.LastEarned.TabIndex = 7;
            this.LastEarned.Text = "前次得分 : 0 分";
            this.LastEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalEarned
            // 
            this.TotalEarned.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalEarned.BackColor = System.Drawing.SystemColors.Desktop;
            this.TotalEarned.Font = new System.Drawing.Font("新細明體", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalEarned.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalEarned.Location = new System.Drawing.Point(665, 542);
            this.TotalEarned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalEarned.Name = "TotalEarned";
            this.TotalEarned.Size = new System.Drawing.Size(350, 50);
            this.TotalEarned.TabIndex = 6;
            this.TotalEarned.Text = "作業總分 : 0 分";
            this.TotalEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pump
            // 
            this.Pump.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pump.Font = new System.Drawing.Font("新細明體", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Pump.Location = new System.Drawing.Point(415, 542);
            this.Pump.Margin = new System.Windows.Forms.Padding(4);
            this.Pump.Name = "Pump";
            this.Pump.Size = new System.Drawing.Size(200, 100);
            this.Pump.TabIndex = 1;
            this.Pump.Text = "充氣";
            this.Pump.UseVisualStyleBackColor = true;
            this.Pump.Click += new System.EventHandler(this.Pump_Click);
            // 
            // Collect
            // 
            this.Collect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Collect.Enabled = false;
            this.Collect.Font = new System.Drawing.Font("新細明體", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Collect.Location = new System.Drawing.Point(140, 542);
            this.Collect.Margin = new System.Windows.Forms.Padding(4);
            this.Collect.Name = "Collect";
            this.Collect.Size = new System.Drawing.Size(200, 100);
            this.Collect.TabIndex = 4;
            this.Collect.Text = "結算";
            this.Collect.UseVisualStyleBackColor = true;
            this.Collect.Click += new System.EventHandler(this.Collect_Click);
            // 
            // label_Wait
            // 
            this.label_Wait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Wait.BackColor = System.Drawing.Color.Transparent;
            this.label_Wait.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Wait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Wait.Location = new System.Drawing.Point(420, 142);
            this.label_Wait.Name = "label_Wait";
            this.label_Wait.Size = new System.Drawing.Size(176, 50);
            this.label_Wait.TabIndex = 11;
            this.label_Wait.Text = "請稍後...";
            this.label_Wait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Burst
            // 
            this.label_Burst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Burst.BackColor = System.Drawing.Color.Transparent;
            this.label_Burst.Font = new System.Drawing.Font("新細明體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_Burst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Burst.Location = new System.Drawing.Point(315, 142);
            this.label_Burst.Name = "label_Burst";
            this.label_Burst.Size = new System.Drawing.Size(400, 50);
            this.label_Burst.TabIndex = 10;
            this.label_Burst.Text = "氣球破了！";
            this.label_Burst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(761, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastEarned);
            this.Controls.Add(this.TotalEarned);
            this.Controls.Add(this.Pump);
            this.Controls.Add(this.Collect);
            this.Controls.Add(this.label_Wait);
            this.Controls.Add(this.label_Burst);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BART";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastEarned;
        private System.Windows.Forms.Label TotalEarned;
        private System.Windows.Forms.Button Pump;
        private System.Windows.Forms.Button Collect;
        private System.Windows.Forms.Label label_Wait;
        private System.Windows.Forms.Label label_Burst;
        private System.Windows.Forms.Label label2;
    }
}

