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
            this.button1 = new System.Windows.Forms.Button();
            this.sayingLbl1 = new System.Windows.Forms.Label();
            this.sayingLbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sayingLbl1
            // 
            this.sayingLbl1.AutoSize = true;
            this.sayingLbl1.Location = new System.Drawing.Point(163, 211);
            this.sayingLbl1.Name = "sayingLbl1";
            this.sayingLbl1.Size = new System.Drawing.Size(0, 20);
            this.sayingLbl1.TabIndex = 1;
            // 
            // sayingLbl2
            // 
            this.sayingLbl2.AutoSize = true;
            this.sayingLbl2.Location = new System.Drawing.Point(163, 235);
            this.sayingLbl2.Name = "sayingLbl2";
            this.sayingLbl2.Size = new System.Drawing.Size(0, 20);
            this.sayingLbl2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sayingLbl2);
            this.Controls.Add(this.sayingLbl1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sayingLbl1;
        private System.Windows.Forms.Label sayingLbl2;
    }
}

