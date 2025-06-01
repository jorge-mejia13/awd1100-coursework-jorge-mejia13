namespace Lab2
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
            this.chicken1Txt = new System.Windows.Forms.TextBox();
            this.chicken2Txt = new System.Windows.Forms.TextBox();
            this.chicken3Txt = new System.Windows.Forms.TextBox();
            this.chicken4Txt = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.displayLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chicken1Txt
            // 
            this.chicken1Txt.Location = new System.Drawing.Point(59, 104);
            this.chicken1Txt.Name = "chicken1Txt";
            this.chicken1Txt.Size = new System.Drawing.Size(127, 26);
            this.chicken1Txt.TabIndex = 0;
            // 
            // chicken2Txt
            // 
            this.chicken2Txt.Location = new System.Drawing.Point(237, 103);
            this.chicken2Txt.Name = "chicken2Txt";
            this.chicken2Txt.Size = new System.Drawing.Size(129, 26);
            this.chicken2Txt.TabIndex = 1;
            // 
            // chicken3Txt
            // 
            this.chicken3Txt.Location = new System.Drawing.Point(432, 103);
            this.chicken3Txt.Name = "chicken3Txt";
            this.chicken3Txt.Size = new System.Drawing.Size(119, 26);
            this.chicken3Txt.TabIndex = 2;
            // 
            // chicken4Txt
            // 
            this.chicken4Txt.Location = new System.Drawing.Point(610, 104);
            this.chicken4Txt.Name = "chicken4Txt";
            this.chicken4Txt.Size = new System.Drawing.Size(123, 26);
            this.chicken4Txt.TabIndex = 3;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(309, 201);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(174, 40);
            this.calcBtn.TabIndex = 4;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Location = new System.Drawing.Point(367, 309);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(51, 20);
            this.displayLbl.TabIndex = 5;
            this.displayLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter number of eggs laid by each chicken";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.chicken4Txt);
            this.Controls.Add(this.chicken3Txt);
            this.Controls.Add(this.chicken2Txt);
            this.Controls.Add(this.chicken1Txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chicken1Txt;
        private System.Windows.Forms.TextBox chicken2Txt;
        private System.Windows.Forms.TextBox chicken3Txt;
        private System.Windows.Forms.TextBox chicken4Txt;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label displayLbl;
        private System.Windows.Forms.Label label2;
    }
}

