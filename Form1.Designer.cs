namespace Homework_1
{
    partial class Form1
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.MoveCount = new System.Windows.Forms.Label();
            this.MoveCountNum = new System.Windows.Forms.Label();
            this.Solve = new System.Windows.Forms.Button();
            this.Delay = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MoveLeft1 = new System.Windows.Forms.Button();
            this.MoveLeft2 = new System.Windows.Forms.Button();
            this.MoveRight2 = new System.Windows.Forms.Button();
            this.MoveLeft3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.New = new System.Windows.Forms.Button();
            this.MoveRight3 = new System.Windows.Forms.Button();
            this.MoveRight1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(93, 15);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // MoveCount
            // 
            this.MoveCount.AutoSize = true;
            this.MoveCount.Location = new System.Drawing.Point(181, 21);
            this.MoveCount.Name = "MoveCount";
            this.MoveCount.Size = new System.Drawing.Size(68, 13);
            this.MoveCount.TabIndex = 2;
            this.MoveCount.Text = "Move Count:";
            this.MoveCount.Click += new System.EventHandler(this.MoveCount_Click);
            // 
            // MoveCountNum
            // 
            this.MoveCountNum.AutoSize = true;
            this.MoveCountNum.Location = new System.Drawing.Point(245, 21);
            this.MoveCountNum.Name = "MoveCountNum";
            this.MoveCountNum.Size = new System.Drawing.Size(13, 13);
            this.MoveCountNum.TabIndex = 3;
            this.MoveCountNum.Text = "0";
            this.MoveCountNum.Click += new System.EventHandler(this.MoveCountNum_Click);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(333, 15);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 4;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Delay
            // 
            this.Delay.AutoSize = true;
            this.Delay.Location = new System.Drawing.Point(414, 21);
            this.Delay.Name = "Delay";
            this.Delay.Size = new System.Drawing.Size(37, 13);
            this.Delay.TabIndex = 5;
            this.Delay.Text = "Delay:";
            this.Delay.Click += new System.EventHandler(this.Delay_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(455, 18);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(48, 20);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(156, 318);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // MoveLeft1
            // 
            this.MoveLeft1.Location = new System.Drawing.Point(12, 402);
            this.MoveLeft1.Name = "MoveLeft1";
            this.MoveLeft1.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft1.TabIndex = 10;
            this.MoveLeft1.Text = "Move Left";
            this.MoveLeft1.UseVisualStyleBackColor = true;
            this.MoveLeft1.Click += new System.EventHandler(this.MoveLeft1_Click);
            // 
            // MoveLeft2
            // 
            this.MoveLeft2.Location = new System.Drawing.Point(179, 402);
            this.MoveLeft2.Name = "MoveLeft2";
            this.MoveLeft2.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft2.TabIndex = 12;
            this.MoveLeft2.Text = "Move Left";
            this.MoveLeft2.UseVisualStyleBackColor = true;
            this.MoveLeft2.Click += new System.EventHandler(this.MoveLeft2_Click);
            // 
            // MoveRight2
            // 
            this.MoveRight2.Location = new System.Drawing.Point(260, 402);
            this.MoveRight2.Name = "MoveRight2";
            this.MoveRight2.Size = new System.Drawing.Size(75, 23);
            this.MoveRight2.TabIndex = 13;
            this.MoveRight2.Text = "Move Right";
            this.MoveRight2.UseVisualStyleBackColor = true;
            this.MoveRight2.Click += new System.EventHandler(this.MoveRight2_Click);
            // 
            // MoveLeft3
            // 
            this.MoveLeft3.Location = new System.Drawing.Point(347, 402);
            this.MoveLeft3.Name = "MoveLeft3";
            this.MoveLeft3.Size = new System.Drawing.Size(75, 23);
            this.MoveLeft3.TabIndex = 14;
            this.MoveLeft3.Text = "Move Left";
            this.MoveLeft3.UseVisualStyleBackColor = true;
            this.MoveLeft3.Click += new System.EventHandler(this.MoveLeft3_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(179, 58);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(156, 318);
            this.flowLayoutPanel2.TabIndex = 8;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(347, 58);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(156, 318);
            this.flowLayoutPanel3.TabIndex = 8;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(12, 12);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 16;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // MoveRight3
            // 
            this.MoveRight3.Location = new System.Drawing.Point(428, 402);
            this.MoveRight3.Name = "MoveRight3";
            this.MoveRight3.Size = new System.Drawing.Size(75, 23);
            this.MoveRight3.TabIndex = 18;
            this.MoveRight3.Text = "Move Right";
            this.MoveRight3.UseVisualStyleBackColor = true;
            this.MoveRight3.Click += new System.EventHandler(this.MoveRight3_Click);
            // 
            // MoveRight1
            // 
            this.MoveRight1.Location = new System.Drawing.Point(93, 402);
            this.MoveRight1.Name = "MoveRight1";
            this.MoveRight1.Size = new System.Drawing.Size(75, 23);
            this.MoveRight1.TabIndex = 19;
            this.MoveRight1.Text = "Move Right";
            this.MoveRight1.UseVisualStyleBackColor = true;
            this.MoveRight1.Click += new System.EventHandler(this.MoveRight1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.MoveRight1);
            this.Controls.Add(this.MoveRight3);
            this.Controls.Add(this.New);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.MoveLeft3);
            this.Controls.Add(this.MoveRight2);
            this.Controls.Add(this.MoveLeft2);
            this.Controls.Add(this.MoveLeft1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.Delay);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.MoveCountNum);
            this.Controls.Add(this.MoveCount);
            this.Controls.Add(this.numericUpDown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Tower of Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label MoveCount;
        private System.Windows.Forms.Label MoveCountNum;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Label Delay;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button MoveLeft1;
        private System.Windows.Forms.Button MoveLeft2;
        private System.Windows.Forms.Button MoveRight2;
        private System.Windows.Forms.Button MoveLeft3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button MoveRight3;
        private System.Windows.Forms.Button MoveRight1;
    }
}

