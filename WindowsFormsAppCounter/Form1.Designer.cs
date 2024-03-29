﻿namespace Counter.WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalTimeBox = new System.Windows.Forms.TextBox();
            this.countNumberBox = new System.Windows.Forms.NumericUpDown();
            this.counterResultBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numberButton = new System.Windows.Forms.Button();
            this.textButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.counterListBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countNumberBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Count number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval time (ms)";
            // 
            // intervalTimeBox
            // 
            this.intervalTimeBox.Enabled = false;
            this.intervalTimeBox.Location = new System.Drawing.Point(211, 26);
            this.intervalTimeBox.Name = "intervalTimeBox";
            this.intervalTimeBox.Size = new System.Drawing.Size(102, 20);
            this.intervalTimeBox.TabIndex = 2;
            // 
            // countNumberBox
            // 
            this.countNumberBox.Enabled = false;
            this.countNumberBox.Location = new System.Drawing.Point(74, 25);
            this.countNumberBox.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.countNumberBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countNumberBox.Name = "countNumberBox";
            this.countNumberBox.Size = new System.Drawing.Size(120, 20);
            this.countNumberBox.TabIndex = 4;
            this.countNumberBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // counterResultBox
            // 
            this.counterResultBox.Location = new System.Drawing.Point(328, 117);
            this.counterResultBox.Multiline = true;
            this.counterResultBox.Name = "counterResultBox";
            this.counterResultBox.ReadOnly = true;
            this.counterResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.counterResultBox.Size = new System.Drawing.Size(166, 235);
            this.counterResultBox.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(328, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(166, 78);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Enabled = false;
            this.countTextBox.Location = new System.Drawing.Point(74, 70);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(120, 20);
            this.countTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Count number (English)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Current status";
            // 
            // numberButton
            // 
            this.numberButton.Location = new System.Drawing.Point(28, 23);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(30, 23);
            this.numberButton.TabIndex = 12;
            this.numberButton.Text = ">>";
            this.numberButton.UseVisualStyleBackColor = true;
            this.numberButton.Click += new System.EventHandler(this.NumberButton_Click);
            // 
            // textButton
            // 
            this.textButton.Location = new System.Drawing.Point(28, 67);
            this.textButton.Name = "textButton";
            this.textButton.Size = new System.Drawing.Size(30, 23);
            this.textButton.TabIndex = 13;
            this.textButton.Text = ">>";
            this.textButton.UseVisualStyleBackColor = true;
            this.textButton.Click += new System.EventHandler(this.TextButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(28, 358);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(466, 23);
            this.resetButton.TabIndex = 14;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(211, 54);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 35);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // counterListBox
            // 
            this.counterListBox.Location = new System.Drawing.Point(28, 117);
            this.counterListBox.Multiline = true;
            this.counterListBox.Name = "counterListBox";
            this.counterListBox.ReadOnly = true;
            this.counterListBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.counterListBox.Size = new System.Drawing.Size(285, 235);
            this.counterListBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Counters list";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.counterListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.textButton);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.counterResultBox);
            this.Controls.Add(this.countNumberBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalTimeBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Counter";
            ((System.ComponentModel.ISupportInitialize)(this.countNumberBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intervalTimeBox;
        private System.Windows.Forms.NumericUpDown countNumberBox;
        private System.Windows.Forms.TextBox counterResultBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button numberButton;
        private System.Windows.Forms.Button textButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox counterListBox;
        private System.Windows.Forms.Label label5;
    }
}

