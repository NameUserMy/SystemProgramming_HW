namespace SystemProgramming_LaboratoryWork
{
    partial class MinMax
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
            groupBox1 = new GroupBox();
            startButton = new Button();
            resultMinLabel = new Label();
            label2 = new Label();
            resultMaxLabel = new Label();
            titleMaxLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(startButton);
            groupBox1.Controls.Add(resultMinLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(resultMaxLabel);
            groupBox1.Controls.Add(titleMaxLabel);
            groupBox1.Location = new Point(315, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 157);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generate random nymber 10000";
            // 
            // startButton
            // 
            startButton.Location = new Point(16, 114);
            startButton.Name = "startButton";
            startButton.Size = new Size(170, 23);
            startButton.TabIndex = 4;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // resultMinLabel
            // 
            resultMinLabel.AutoSize = true;
            resultMinLabel.Location = new Point(78, 79);
            resultMinLabel.Name = "resultMinLabel";
            resultMinLabel.Size = new Size(13, 15);
            resultMinLabel.TabIndex = 3;
            resultMinLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 79);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 2;
            label2.Text = "Min";
            // 
            // resultMaxLabel
            // 
            resultMaxLabel.AutoSize = true;
            resultMaxLabel.Location = new Point(78, 32);
            resultMaxLabel.Name = "resultMaxLabel";
            resultMaxLabel.Size = new Size(13, 15);
            resultMaxLabel.TabIndex = 1;
            resultMaxLabel.Text = "0";
            // 
            // titleMaxLabel
            // 
            titleMaxLabel.AutoSize = true;
            titleMaxLabel.Location = new Point(14, 32);
            titleMaxLabel.Name = "titleMaxLabel";
            titleMaxLabel.Size = new Size(30, 15);
            titleMaxLabel.TabIndex = 0;
            titleMaxLabel.Text = "Max";
            // 
            // MinMax
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "MinMax";
            Text = "MinMax";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button startButton;
        private Label resultMinLabel;
        private Label label2;
        private Label resultMaxLabel;
        private Label titleMaxLabel;
    }
}