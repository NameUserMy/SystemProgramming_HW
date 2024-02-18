namespace SystemProgramming_HW_3
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoList = new System.Windows.Forms.ListBox();
            this.procentUpDown = new System.Windows.Forms.NumericUpDown();
            this.moneyUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.procentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(218, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Money";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Procent";
            // 
            // infoList
            // 
            this.infoList.FormattingEnabled = true;
            this.infoList.Location = new System.Drawing.Point(371, 62);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(165, 173);
            this.infoList.TabIndex = 6;
            // 
            // procentUpDown
            // 
            this.procentUpDown.Location = new System.Drawing.Point(218, 135);
            this.procentUpDown.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.procentUpDown.Name = "procentUpDown";
            this.procentUpDown.Size = new System.Drawing.Size(100, 20);
            this.procentUpDown.TabIndex = 7;
            this.procentUpDown.ValueChanged += new System.EventHandler(this.procentUpDown_ValueChanged);
            // 
            // moneyUpDown2
            // 
            this.moneyUpDown2.Location = new System.Drawing.Point(218, 215);
            this.moneyUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.moneyUpDown2.Name = "moneyUpDown2";
            this.moneyUpDown2.Size = new System.Drawing.Size(100, 20);
            this.moneyUpDown2.TabIndex = 8;
            this.moneyUpDown2.ValueChanged += new System.EventHandler(this.moneyUpDown2_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moneyUpDown2);
            this.Controls.Add(this.procentUpDown);
            this.Controls.Add(this.infoList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.procentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox infoList;
        private System.Windows.Forms.NumericUpDown procentUpDown;
        private System.Windows.Forms.NumericUpDown moneyUpDown2;
    }
}

