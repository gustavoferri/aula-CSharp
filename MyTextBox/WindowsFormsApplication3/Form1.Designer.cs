﻿namespace WindowsFormsApplication3
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
            this.myTextBox1 = new MyTextBox.MyTextBox();
            this.myTextBox2 = new MyTextBox.MyTextBox();
            this.myTextBox3 = new MyTextBox.MyTextBox();
            this.SuspendLayout();
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(68, 34);
            this.myTextBox1.MenorValor = 0;
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(100, 22);
            this.myTextBox1.TabIndex = 0;
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(68, 83);
            this.myTextBox2.MenorValor = 0;
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(100, 22);
            this.myTextBox2.TabIndex = 1;
            // 
            // myTextBox3
            // 
            this.myTextBox3.Location = new System.Drawing.Point(68, 137);
            this.myTextBox3.MenorValor = 0;
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.Size = new System.Drawing.Size(100, 22);
            this.myTextBox3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.myTextBox3);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyTextBox.MyTextBox myTextBox1;
        private MyTextBox.MyTextBox myTextBox2;
        private MyTextBox.MyTextBox myTextBox3;
    }
}

