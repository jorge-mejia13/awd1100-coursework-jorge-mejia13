namespace Lab1
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
            this.gpaInput = new System.Windows.Forms.TextBox();
            this.adminInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.verifyBtn = new System.Windows.Forms.Button();
            this.answerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaInput
            // 
            this.gpaInput.Location = new System.Drawing.Point(62, 74);
            this.gpaInput.Multiline = true;
            this.gpaInput.Name = "gpaInput";
            this.gpaInput.Size = new System.Drawing.Size(283, 63);
            this.gpaInput.TabIndex = 0;
            // 
            // adminInput
            // 
            this.adminInput.Location = new System.Drawing.Point(438, 74);
            this.adminInput.Multiline = true;
            this.adminInput.Name = "adminInput";
            this.adminInput.Size = new System.Drawing.Size(281, 63);
            this.adminInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "GPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admission Test Score";
            // 
            // verifyBtn
            // 
            this.verifyBtn.Location = new System.Drawing.Point(66, 187);
            this.verifyBtn.Name = "verifyBtn";
            this.verifyBtn.Size = new System.Drawing.Size(176, 52);
            this.verifyBtn.TabIndex = 4;
            this.verifyBtn.Text = "Admit";
            this.verifyBtn.UseVisualStyleBackColor = true;
            this.verifyBtn.Click += new System.EventHandler(this.verifyBtn_Click);
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(438, 218);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(35, 20);
            this.answerLbl.TabIndex = 5;
            this.answerLbl.Text = "N/A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.verifyBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminInput);
            this.Controls.Add(this.gpaInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpaInput;
        private System.Windows.Forms.TextBox adminInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button verifyBtn;
        private System.Windows.Forms.Label answerLbl;
    }
}

