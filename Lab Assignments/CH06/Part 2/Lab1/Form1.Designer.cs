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
            this.intInput1 = new System.Windows.Forms.TextBox();
            this.intInput2 = new System.Windows.Forms.TextBox();
            this.intInput3 = new System.Windows.Forms.TextBox();
            this.intInput4 = new System.Windows.Forms.TextBox();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // intInput1
            // 
            this.intInput1.Location = new System.Drawing.Point(135, 108);
            this.intInput1.Name = "intInput1";
            this.intInput1.Size = new System.Drawing.Size(100, 26);
            this.intInput1.TabIndex = 0;
            // 
            // intInput2
            // 
            this.intInput2.Location = new System.Drawing.Point(284, 107);
            this.intInput2.Name = "intInput2";
            this.intInput2.Size = new System.Drawing.Size(100, 26);
            this.intInput2.TabIndex = 1;
            // 
            // intInput3
            // 
            this.intInput3.Location = new System.Drawing.Point(445, 108);
            this.intInput3.Name = "intInput3";
            this.intInput3.Size = new System.Drawing.Size(100, 26);
            this.intInput3.TabIndex = 2;
            // 
            // intInput4
            // 
            this.intInput4.Location = new System.Drawing.Point(592, 107);
            this.intInput4.Name = "intInput4";
            this.intInput4.Size = new System.Drawing.Size(100, 26);
            this.intInput4.TabIndex = 3;
            // 
            // reverseBtn
            // 
            this.reverseBtn.Location = new System.Drawing.Point(135, 180);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(100, 54);
            this.reverseBtn.TabIndex = 4;
            this.reverseBtn.Text = "Reverse";
            this.reverseBtn.UseVisualStyleBackColor = true;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(135, 299);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 30);
            this.resultLbl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 514);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.intInput4);
            this.Controls.Add(this.intInput3);
            this.Controls.Add(this.intInput2);
            this.Controls.Add(this.intInput1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox intInput1;
        private System.Windows.Forms.TextBox intInput2;
        private System.Windows.Forms.TextBox intInput3;
        private System.Windows.Forms.TextBox intInput4;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

