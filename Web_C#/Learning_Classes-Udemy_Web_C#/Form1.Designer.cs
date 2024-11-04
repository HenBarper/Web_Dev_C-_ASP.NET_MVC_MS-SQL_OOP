namespace Learning_Classes_Udemy_Web_C_
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
            this.btnGetVals = new System.Windows.Forms.Button();
            this.btnSetVals = new System.Windows.Forms.Button();
            this.textEmployeeID = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.btnSendVals = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetVals
            // 
            this.btnGetVals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetVals.Location = new System.Drawing.Point(46, 81);
            this.btnGetVals.Name = "btnGetVals";
            this.btnGetVals.Size = new System.Drawing.Size(190, 56);
            this.btnGetVals.TabIndex = 0;
            this.btnGetVals.Text = "Get Values";
            this.btnGetVals.UseVisualStyleBackColor = true;
            // 
            // btnSetVals
            // 
            this.btnSetVals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetVals.Location = new System.Drawing.Point(312, 81);
            this.btnSetVals.Name = "btnSetVals";
            this.btnSetVals.Size = new System.Drawing.Size(190, 56);
            this.btnSetVals.TabIndex = 0;
            this.btnSetVals.Text = "Set Values";
            this.btnSetVals.UseVisualStyleBackColor = true;
            this.btnSetVals.Click += new System.EventHandler(this.btnSetVals_Click);
            // 
            // textEmployeeID
            // 
            this.textEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmployeeID.Location = new System.Drawing.Point(249, 200);
            this.textEmployeeID.Name = "textEmployeeID";
            this.textEmployeeID.Size = new System.Drawing.Size(100, 27);
            this.textEmployeeID.TabIndex = 1;
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textName.Location = new System.Drawing.Point(249, 264);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 27);
            this.textName.TabIndex = 1;
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(249, 331);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 27);
            this.textAge.TabIndex = 1;
            // 
            // btnSendVals
            // 
            this.btnSendVals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendVals.Location = new System.Drawing.Point(578, 81);
            this.btnSendVals.Name = "btnSendVals";
            this.btnSendVals.Size = new System.Drawing.Size(190, 56);
            this.btnSendVals.TabIndex = 0;
            this.btnSendVals.Text = "Send";
            this.btnSendVals.UseVisualStyleBackColor = true;
            this.btnSendVals.Click += new System.EventHandler(this.btnSendVals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textEmployeeID);
            this.Controls.Add(this.btnSendVals);
            this.Controls.Add(this.btnSetVals);
            this.Controls.Add(this.btnGetVals);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetVals;
        private System.Windows.Forms.Button btnSetVals;
        private System.Windows.Forms.TextBox textEmployeeID;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Button btnSendVals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

