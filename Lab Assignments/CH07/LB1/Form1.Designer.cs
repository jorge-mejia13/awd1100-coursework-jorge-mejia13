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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.bmiLbl = new System.Windows.Forms.Label();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight (lb)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (in)";
            // 
            // weightInput
            // 
            this.weightInput.Location = new System.Drawing.Point(307, 59);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(122, 20);
            this.weightInput.TabIndex = 2;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(307, 87);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(122, 20);
            this.heightInput.TabIndex = 3;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(307, 139);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(122, 31);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = " Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // bmiLbl
            // 
            this.bmiLbl.AutoSize = true;
            this.bmiLbl.Location = new System.Drawing.Point(307, 208);
            this.bmiLbl.Name = "bmiLbl";
            this.bmiLbl.Size = new System.Drawing.Size(29, 13);
            this.bmiLbl.TabIndex = 5;
            this.bmiLbl.Text = "BMI:";
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(307, 235);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(52, 13);
            this.categoryLbl.TabIndex = 6;
            this.categoryLbl.Text = "Category:";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(310, 288);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 13);
            this.errorLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.bmiLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.weightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label bmiLbl;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label errorLbl;
    }
}

