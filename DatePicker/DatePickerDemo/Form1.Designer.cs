﻿namespace DatePickerDemo
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
            this.advancedDatePicker1 = new DatePicker.advancedDatePicker();
            this.advancedDatePicker2 = new DatePicker.advancedDatePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // advancedDatePicker1
            // 
            this.advancedDatePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.advancedDatePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.advancedDatePicker1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.advancedDatePicker1.Location = new System.Drawing.Point(13, 13);
            this.advancedDatePicker1.Name = "advancedDatePicker1";
            this.advancedDatePicker1.Size = new System.Drawing.Size(200, 20);
            this.advancedDatePicker1.TabIndex = 0;
            // 
            // advancedDatePicker2
            // 
            this.advancedDatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.advancedDatePicker2.HeaderColor = System.Drawing.Color.Red;
            this.advancedDatePicker2.Location = new System.Drawing.Point(13, 40);
            this.advancedDatePicker2.Name = "advancedDatePicker2";
            this.advancedDatePicker2.Size = new System.Drawing.Size(200, 20);
            this.advancedDatePicker2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Get Date";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Set Date";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 71);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.advancedDatePicker2);
            this.Controls.Add(this.advancedDatePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DatePicker.advancedDatePicker advancedDatePicker1;
        private DatePicker.advancedDatePicker advancedDatePicker2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

