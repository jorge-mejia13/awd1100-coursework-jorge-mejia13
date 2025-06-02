namespace Exercise_2
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
            this.gradeInputBox = new System.Windows.Forms.TextBox();
            this.showLetterBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numeric Grade";
            // 
            // gradeInputBox
            // 
            this.gradeInputBox.Location = new System.Drawing.Point(219, 66);
            this.gradeInputBox.Name = "gradeInputBox";
            this.gradeInputBox.Size = new System.Drawing.Size(100, 26);
            this.gradeInputBox.TabIndex = 1;
            // 
            // showLetterBtn
            // 
            this.showLetterBtn.Location = new System.Drawing.Point(219, 99);
            this.showLetterBtn.Name = "showLetterBtn";
            this.showLetterBtn.Size = new System.Drawing.Size(150, 32);
            this.showLetterBtn.TabIndex = 2;
            this.showLetterBtn.Text = "Show letter grade";
            this.showLetterBtn.UseVisualStyleBackColor = true;
            this.showLetterBtn.Click += new System.EventHandler(this.showLetterBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(219, 172);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.showLetterBtn);
            this.Controls.Add(this.gradeInputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gradeInputBox;
        private System.Windows.Forms.Button showLetterBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

