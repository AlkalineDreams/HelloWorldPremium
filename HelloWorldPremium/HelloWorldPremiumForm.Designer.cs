﻿namespace HelloWorldPremium
{
    partial class frmHelloWorld
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
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(13, 13);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(68, 13);
            this.lblHelloWorld.TabIndex = 0;
            this.lblHelloWorld.Text = "Hello, World!";
            this.lblHelloWorld.Click += new System.EventHandler(this.lblHelloWorld_Click);
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(87, 13);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(75, 20);
            this.btnClickHere.TabIndex = 1;
            this.btnClickHere.Text = "Click Here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World Premium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHelloWorld;
        private System.Windows.Forms.Button btnClickHere;
    }
}

