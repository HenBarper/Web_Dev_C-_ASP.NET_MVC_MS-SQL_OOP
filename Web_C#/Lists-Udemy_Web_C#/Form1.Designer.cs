﻿namespace Lists_Udemy_Web_C_
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
            this.btnFillList = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cmbDays = new System.Windows.Forms.ComboBox();
            this.dayList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dayList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFillList
            // 
            this.btnFillList.Location = new System.Drawing.Point(292, 12);
            this.btnFillList.Name = "btnFillList";
            this.btnFillList.Size = new System.Drawing.Size(147, 56);
            this.btnFillList.TabIndex = 0;
            this.btnFillList.Text = "Fill List";
            this.btnFillList.UseVisualStyleBackColor = true;
            this.btnFillList.Click += new System.EventHandler(this.btnFillList_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(274, 426);
            this.txtNumber.TabIndex = 1;
            // 
            // cmbDays
            // 
            this.cmbDays.FormattingEnabled = true;
            this.cmbDays.Location = new System.Drawing.Point(292, 74);
            this.cmbDays.Name = "cmbDays";
            this.cmbDays.Size = new System.Drawing.Size(121, 24);
            this.cmbDays.TabIndex = 2;
            this.cmbDays.SelectedIndexChanged += new System.EventHandler(this.cmbDays_SelectedIndexChanged);
            // 
            // dayList
            // 
            this.dayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayList.Location = new System.Drawing.Point(292, 104);
            this.dayList.Name = "dayList";
            this.dayList.RowHeadersWidth = 51;
            this.dayList.RowTemplate.Height = 24;
            this.dayList.Size = new System.Drawing.Size(505, 334);
            this.dayList.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dayList);
            this.Controls.Add(this.cmbDays);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnFillList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dayList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillList;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.ComboBox cmbDays;
        private System.Windows.Forms.DataGridView dayList;
    }
}

