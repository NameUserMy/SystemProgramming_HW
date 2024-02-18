namespace SystemProgramming_HW_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleNumberListB = new System.Windows.Forms.ListBox();
            this.pauseSimpleButton = new System.Windows.Forms.Button();
            this.endSimpleButton = new System.Windows.Forms.Button();
            this.startSimpleButton = new System.Windows.Forms.Button();
            this.endRangeSimpleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.startRangeSimpleNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numberFibonacci = new System.Windows.Forms.ListBox();
            this.pauseFibonacci = new System.Windows.Forms.Button();
            this.endFibonacci = new System.Windows.Forms.Button();
            this.startFibonacci = new System.Windows.Forms.Button();
            this.endFibonacciNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.startFibonacciNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endRangeSimpleNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startRangeSimpleNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endFibonacciNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFibonacciNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleNumberListB);
            this.groupBox1.Controls.Add(this.pauseSimpleButton);
            this.groupBox1.Controls.Add(this.endSimpleButton);
            this.groupBox1.Controls.Add(this.startSimpleButton);
            this.groupBox1.Controls.Add(this.endRangeSimpleNumeric);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.startRangeSimpleNumeric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(94, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simple number generator";
            // 
            // simpleNumberListB
            // 
            this.simpleNumberListB.FormattingEnabled = true;
            this.simpleNumberListB.Location = new System.Drawing.Point(100, 54);
            this.simpleNumberListB.Name = "simpleNumberListB";
            this.simpleNumberListB.Size = new System.Drawing.Size(156, 95);
            this.simpleNumberListB.TabIndex = 8;
            // 
            // pauseSimpleButton
            // 
            this.pauseSimpleButton.Location = new System.Drawing.Point(100, 184);
            this.pauseSimpleButton.Name = "pauseSimpleButton";
            this.pauseSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.pauseSimpleButton.TabIndex = 6;
            this.pauseSimpleButton.Text = "Pause";
            this.pauseSimpleButton.UseVisualStyleBackColor = true;
            this.pauseSimpleButton.Click += new System.EventHandler(this.pauseSimpleButton_Click);
            // 
            // endSimpleButton
            // 
            this.endSimpleButton.Location = new System.Drawing.Point(181, 184);
            this.endSimpleButton.Name = "endSimpleButton";
            this.endSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.endSimpleButton.TabIndex = 5;
            this.endSimpleButton.Text = "End";
            this.endSimpleButton.UseVisualStyleBackColor = true;
            this.endSimpleButton.Click += new System.EventHandler(this.endSimpleButton_Click);
            // 
            // startSimpleButton
            // 
            this.startSimpleButton.Location = new System.Drawing.Point(19, 184);
            this.startSimpleButton.Name = "startSimpleButton";
            this.startSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.startSimpleButton.TabIndex = 4;
            this.startSimpleButton.Text = "Start";
            this.startSimpleButton.UseVisualStyleBackColor = true;
            this.startSimpleButton.UseWaitCursor = true;
            this.startSimpleButton.Click += new System.EventHandler(this.startSimpleButton_Click);
            // 
            // endRangeSimpleNumeric
            // 
            this.endRangeSimpleNumeric.Location = new System.Drawing.Point(19, 117);
            this.endRangeSimpleNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.endRangeSimpleNumeric.Name = "endRangeSimpleNumeric";
            this.endRangeSimpleNumeric.Size = new System.Drawing.Size(53, 20);
            this.endRangeSimpleNumeric.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End range";
            // 
            // startRangeSimpleNumeric
            // 
            this.startRangeSimpleNumeric.Location = new System.Drawing.Point(19, 54);
            this.startRangeSimpleNumeric.Name = "startRangeSimpleNumeric";
            this.startRangeSimpleNumeric.Size = new System.Drawing.Size(53, 20);
            this.startRangeSimpleNumeric.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start range";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numberFibonacci);
            this.groupBox2.Controls.Add(this.pauseFibonacci);
            this.groupBox2.Controls.Add(this.endFibonacci);
            this.groupBox2.Controls.Add(this.startFibonacci);
            this.groupBox2.Controls.Add(this.endFibonacciNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.startFibonacciNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(449, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 229);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "fibonachi number generator";
            // 
            // numberFibonacci
            // 
            this.numberFibonacci.FormattingEnabled = true;
            this.numberFibonacci.Location = new System.Drawing.Point(100, 54);
            this.numberFibonacci.Name = "numberFibonacci";
            this.numberFibonacci.Size = new System.Drawing.Size(156, 95);
            this.numberFibonacci.TabIndex = 8;
            // 
            // pauseFibonacci
            // 
            this.pauseFibonacci.Location = new System.Drawing.Point(100, 184);
            this.pauseFibonacci.Name = "pauseFibonacci";
            this.pauseFibonacci.Size = new System.Drawing.Size(75, 23);
            this.pauseFibonacci.TabIndex = 6;
            this.pauseFibonacci.Text = "Pause";
            this.pauseFibonacci.UseVisualStyleBackColor = true;
            this.pauseFibonacci.Click += new System.EventHandler(this.pauseFibonacci_Click);
            // 
            // endFibonacci
            // 
            this.endFibonacci.Location = new System.Drawing.Point(181, 184);
            this.endFibonacci.Name = "endFibonacci";
            this.endFibonacci.Size = new System.Drawing.Size(75, 23);
            this.endFibonacci.TabIndex = 5;
            this.endFibonacci.Text = "End";
            this.endFibonacci.UseVisualStyleBackColor = true;
            this.endFibonacci.Click += new System.EventHandler(this.endFibonacci_Click);
            // 
            // startFibonacci
            // 
            this.startFibonacci.Location = new System.Drawing.Point(19, 184);
            this.startFibonacci.Name = "startFibonacci";
            this.startFibonacci.Size = new System.Drawing.Size(75, 23);
            this.startFibonacci.TabIndex = 4;
            this.startFibonacci.Text = "Start";
            this.startFibonacci.UseVisualStyleBackColor = true;
            this.startFibonacci.UseWaitCursor = true;
            this.startFibonacci.Click += new System.EventHandler(this.startFibonacci_Click);
            // 
            // endFibonacciNum
            // 
            this.endFibonacciNum.Location = new System.Drawing.Point(19, 117);
            this.endFibonacciNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.endFibonacciNum.Name = "endFibonacciNum";
            this.endFibonacciNum.Size = new System.Drawing.Size(53, 20);
            this.endFibonacciNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End range";
            // 
            // startFibonacciNum
            // 
            this.startFibonacciNum.Enabled = false;
            this.startFibonacciNum.Location = new System.Drawing.Point(19, 54);
            this.startFibonacciNum.Name = "startFibonacciNum";
            this.startFibonacciNum.Size = new System.Drawing.Size(53, 20);
            this.startFibonacciNum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start range";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endRangeSimpleNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startRangeSimpleNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endFibonacciNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFibonacciNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown endRangeSimpleNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown startRangeSimpleNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseSimpleButton;
        private System.Windows.Forms.Button endSimpleButton;
        private System.Windows.Forms.Button startSimpleButton;
        private System.Windows.Forms.ListBox simpleNumberListB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox numberFibonacci;
        private System.Windows.Forms.Button pauseFibonacci;
        private System.Windows.Forms.Button endFibonacci;
        private System.Windows.Forms.Button startFibonacci;
        private System.Windows.Forms.NumericUpDown endFibonacciNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startFibonacciNum;
        private System.Windows.Forms.Label label4;
    }
}

