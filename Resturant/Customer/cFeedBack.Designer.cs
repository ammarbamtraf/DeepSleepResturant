﻿namespace Resturant.Customer
{
    partial class cFeedBack
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
            this.CustomerFeedback = new System.Windows.Forms.Label();
            this.textFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.CustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerFeedback
            // 
            this.CustomerFeedback.AutoSize = true;
            this.CustomerFeedback.Location = new System.Drawing.Point(9, 17);
            this.CustomerFeedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerFeedback.Name = "CustomerFeedback";
            this.CustomerFeedback.Size = new System.Drawing.Size(120, 15);
            this.CustomerFeedback.TabIndex = 0;
            this.CustomerFeedback.Text = "Write Your Feedback";
            this.CustomerFeedback.Click += new System.EventHandler(this.CustomerFeedback_Click);
            // 
            // textFeedback
            // 
            this.textFeedback.Location = new System.Drawing.Point(9, 40);
            this.textFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.textFeedback.Multiline = true;
            this.textFeedback.Name = "textFeedback";
            this.textFeedback.Size = new System.Drawing.Size(226, 82);
            this.textFeedback.TabIndex = 1;
            this.textFeedback.Click += new System.EventHandler(this.feedtext);
            this.textFeedback.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Location = new System.Drawing.Point(9, 214);
            this.btnSubmit1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(86, 39);
            this.btnSubmit1.TabIndex = 2;
            this.btnSubmit1.Text = "Submit Your Feedback ";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(9, 139);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(75, 15);
            this.CustomerID.TabIndex = 3;
            this.CustomerID.Text = "Customer ID";
            this.CustomerID.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(9, 172);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(76, 20);
            this.txtCustomerID.TabIndex = 4;
            this.txtCustomerID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CustomerFeedback);
            this.panel1.Controls.Add(this.btnSubmit1);
            this.panel1.Controls.Add(this.CustomerID);
            this.panel1.Controls.Add(this.txtCustomerID);
            this.panel1.Controls.Add(this.textFeedback);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 366);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cFeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cFeedBack";
            this.Text = "cFeedBack";
            this.Load += new System.EventHandler(this.cFeedBack_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CustomerFeedback;
        private System.Windows.Forms.TextBox textFeedback;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}