namespace SystemProgramming_LaboratoryWork
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            startRangeSecondNumeric = new NumericUpDown();
            endRangeSecondNumeric = new NumericUpDown();
            secondThreadGB = new GroupBox();
            startSecondButt = new Button();
            secondResult = new Label();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            firstThread = new Button();
            firstThreadResult = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            startRangeFirstdNumeric = new NumericUpDown();
            endRangeFirstdNumeric = new NumericUpDown();
            groupBox2 = new GroupBox();
            label11 = new Label();
            countThreadNum = new NumericUpDown();
            manyThreadButton = new Button();
            manyThreadResult = new Label();
            manyThreadName = new Label();
            label6 = new Label();
            label10 = new Label();
            startRangeManyNumeric = new NumericUpDown();
            endRangeManyNumeric = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)startRangeSecondNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endRangeSecondNumeric).BeginInit();
            secondThreadGB.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)startRangeFirstdNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endRangeFirstdNumeric).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)countThreadNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startRangeManyNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)endRangeManyNumeric).BeginInit();
            SuspendLayout();
            // 
            // startRangeSecondNumeric
            // 
            startRangeSecondNumeric.Location = new Point(87, 34);
            startRangeSecondNumeric.Name = "startRangeSecondNumeric";
            startRangeSecondNumeric.Size = new Size(85, 23);
            startRangeSecondNumeric.TabIndex = 3;
            // 
            // endRangeSecondNumeric
            // 
            endRangeSecondNumeric.Location = new Point(87, 82);
            endRangeSecondNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            endRangeSecondNumeric.Name = "endRangeSecondNumeric";
            endRangeSecondNumeric.Size = new Size(85, 23);
            endRangeSecondNumeric.TabIndex = 4;
            // 
            // secondThreadGB
            // 
            secondThreadGB.Controls.Add(startSecondButt);
            secondThreadGB.Controls.Add(secondResult);
            secondThreadGB.Controls.Add(label1);
            secondThreadGB.Controls.Add(label4);
            secondThreadGB.Controls.Add(label2);
            secondThreadGB.Controls.Add(startRangeSecondNumeric);
            secondThreadGB.Controls.Add(endRangeSecondNumeric);
            secondThreadGB.Location = new Point(271, 22);
            secondThreadGB.Name = "secondThreadGB";
            secondThreadGB.Size = new Size(200, 207);
            secondThreadGB.TabIndex = 5;
            secondThreadGB.TabStop = false;
            secondThreadGB.Text = "Second Thread generade number";
            // 
            // startSecondButt
            // 
            startSecondButt.Location = new Point(28, 170);
            startSecondButt.Name = "startSecondButt";
            startSecondButt.Size = new Size(131, 23);
            startSecondButt.TabIndex = 10;
            startSecondButt.Text = "Start";
            startSecondButt.UseVisualStyleBackColor = true;
            startSecondButt.Click += startSecondButt_Click;
            // 
            // secondResult
            // 
            secondResult.AutoSize = true;
            secondResult.Location = new Point(87, 130);
            secondResult.Name = "secondResult";
            secondResult.Size = new Size(13, 15);
            secondResult.TabIndex = 9;
            secondResult.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 130);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 8;
            label1.Text = "Result";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 84);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "End range";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Start range";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(firstThread);
            groupBox1.Controls.Add(firstThreadResult);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(startRangeFirstdNumeric);
            groupBox1.Controls.Add(endRangeFirstdNumeric);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 207);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "First Thread generade number";
            // 
            // firstThread
            // 
            firstThread.Location = new Point(28, 170);
            firstThread.Name = "firstThread";
            firstThread.Size = new Size(131, 23);
            firstThread.TabIndex = 10;
            firstThread.Text = "Start";
            firstThread.UseVisualStyleBackColor = true;
            firstThread.Click += firstThread_Click;
            // 
            // firstThreadResult
            // 
            firstThreadResult.AutoSize = true;
            firstThreadResult.Location = new Point(87, 130);
            firstThreadResult.Name = "firstThreadResult";
            firstThreadResult.Size = new Size(13, 15);
            firstThreadResult.TabIndex = 9;
            firstThreadResult.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 130);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 8;
            label7.Text = "Result";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 84);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 7;
            label8.Text = "End range";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 36);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 6;
            label9.Text = "Start range";
            // 
            // startRangeFirstdNumeric
            // 
            startRangeFirstdNumeric.Location = new Point(87, 34);
            startRangeFirstdNumeric.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            startRangeFirstdNumeric.Name = "startRangeFirstdNumeric";
            startRangeFirstdNumeric.Size = new Size(85, 23);
            startRangeFirstdNumeric.TabIndex = 3;
            // 
            // endRangeFirstdNumeric
            // 
            endRangeFirstdNumeric.Location = new Point(87, 82);
            endRangeFirstdNumeric.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            endRangeFirstdNumeric.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            endRangeFirstdNumeric.Name = "endRangeFirstdNumeric";
            endRangeFirstdNumeric.Size = new Size(85, 23);
            endRangeFirstdNumeric.TabIndex = 4;
            endRangeFirstdNumeric.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(countThreadNum);
            groupBox2.Controls.Add(manyThreadButton);
            groupBox2.Controls.Add(manyThreadResult);
            groupBox2.Controls.Add(manyThreadName);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(startRangeManyNumeric);
            groupBox2.Controls.Add(endRangeManyNumeric);
            groupBox2.Location = new Point(534, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 207);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Many Thread generade number";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 94);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 12;
            label11.Text = "Count thread";
            // 
            // countThreadNum
            // 
            countThreadNum.Location = new Point(87, 92);
            countThreadNum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            countThreadNum.Name = "countThreadNum";
            countThreadNum.Size = new Size(85, 23);
            countThreadNum.TabIndex = 11;
            // 
            // manyThreadButton
            // 
            manyThreadButton.Location = new Point(28, 170);
            manyThreadButton.Name = "manyThreadButton";
            manyThreadButton.Size = new Size(131, 23);
            manyThreadButton.TabIndex = 10;
            manyThreadButton.Text = "Start";
            manyThreadButton.UseVisualStyleBackColor = true;
            manyThreadButton.Click += manyThreadButton_Click;
            // 
            // manyThreadResult
            // 
            manyThreadResult.AutoSize = true;
            manyThreadResult.Location = new Point(159, 130);
            manyThreadResult.Name = "manyThreadResult";
            manyThreadResult.Size = new Size(13, 15);
            manyThreadResult.TabIndex = 9;
            manyThreadResult.Text = "0";
            // 
            // manyThreadName
            // 
            manyThreadName.AutoSize = true;
            manyThreadName.Location = new Point(6, 130);
            manyThreadName.Name = "manyThreadName";
            manyThreadName.Size = new Size(39, 15);
            manyThreadName.TabIndex = 8;
            manyThreadName.Text = "Result";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 65);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 7;
            label6.Text = "End range";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 36);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 6;
            label10.Text = "Start range";
            // 
            // startRangeManyNumeric
            // 
            startRangeManyNumeric.Location = new Point(87, 34);
            startRangeManyNumeric.Name = "startRangeManyNumeric";
            startRangeManyNumeric.Size = new Size(85, 23);
            startRangeManyNumeric.TabIndex = 3;
            // 
            // endRangeManyNumeric
            // 
            endRangeManyNumeric.Location = new Point(87, 63);
            endRangeManyNumeric.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            endRangeManyNumeric.Name = "endRangeManyNumeric";
            endRangeManyNumeric.Size = new Size(85, 23);
            endRangeManyNumeric.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 259);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(secondThreadGB);
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)startRangeSecondNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)endRangeSecondNumeric).EndInit();
            secondThreadGB.ResumeLayout(false);
            secondThreadGB.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)startRangeFirstdNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)endRangeFirstdNumeric).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)countThreadNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)startRangeManyNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)endRangeManyNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown startRangeSecondNumeric;
        private NumericUpDown endRangeSecondNumeric;
        private GroupBox secondThreadGB;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label secondResult;
        private Button startSecondButt;
        private GroupBox groupBox1;
        private Button firstThread;
        private Label firstThreadResult;
        private Label label7;
        private Label label8;
        private Label label9;
        private NumericUpDown startRangeFirstdNumeric;
        private NumericUpDown endRangeFirstdNumeric;
        private GroupBox groupBox2;
        private Label label11;
        private NumericUpDown countThreadNum;
        private Button manyThreadButton;
        private Label manyThreadResult;
        private Label manyThreadName;
        private Label label6;
        private Label label10;
        private NumericUpDown startRangeManyNumeric;
        private NumericUpDown endRangeManyNumeric;
    }
}
