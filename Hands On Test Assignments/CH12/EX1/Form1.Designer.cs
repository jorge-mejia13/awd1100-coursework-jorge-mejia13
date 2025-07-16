namespace EX1
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
            this.hashInput = new System.Windows.Forms.TextBox();
            this.hashBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MD5 Hash";
            // 
            // hashInput
            // 
            this.hashInput.Location = new System.Drawing.Point(266, 105);
            this.hashInput.Name = "hashInput";
            this.hashInput.Size = new System.Drawing.Size(142, 20);
            this.hashInput.TabIndex = 1;
            // 
            // hashBtn
            // 
            this.hashBtn.Location = new System.Drawing.Point(415, 101);
            this.hashBtn.Name = "hashBtn";
            this.hashBtn.Size = new System.Drawing.Size(75, 23);
            this.hashBtn.TabIndex = 2;
            this.hashBtn.Text = "Crack";
            this.hashBtn.UseVisualStyleBackColor = true;
            this.hashBtn.Click += new System.EventHandler(this.hashBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(263, 195);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(56, 13);
            this.resultLbl.TabIndex = 3;
            this.resultLbl.Text = "Password:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.hashBtn);
            this.Controls.Add(this.hashInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hashInput;
        private System.Windows.Forms.Button hashBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

