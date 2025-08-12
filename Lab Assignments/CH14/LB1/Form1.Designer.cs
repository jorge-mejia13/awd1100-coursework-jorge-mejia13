namespace LB1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.recipientInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sentDateInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackingNumberInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sendBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.trackingNumberInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sentDateInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.recipientInput);
            this.groupBox1.Location = new System.Drawing.Point(30, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(281, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // recipientInput
            // 
            this.recipientInput.Location = new System.Drawing.Point(116, 44);
            this.recipientInput.Name = "recipientInput";
            this.recipientInput.Size = new System.Drawing.Size(147, 20);
            this.recipientInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sent Date";
            // 
            // sentDateInput
            // 
            this.sentDateInput.Location = new System.Drawing.Point(116, 90);
            this.sentDateInput.Name = "sentDateInput";
            this.sentDateInput.Size = new System.Drawing.Size(147, 20);
            this.sentDateInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tracking Number";
            // 
            // trackingNumberInput
            // 
            this.trackingNumberInput.Location = new System.Drawing.Point(115, 143);
            this.trackingNumberInput.Name = "trackingNumberInput";
            this.trackingNumberInput.Size = new System.Drawing.Size(147, 20);
            this.trackingNumberInput.TabIndex = 4;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(69, 219);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(128, 42);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(456, 98);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 1;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(403, 346);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox trackingNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sentDateInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recipientInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}

