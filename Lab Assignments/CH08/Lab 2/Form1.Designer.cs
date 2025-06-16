namespace Lab_2
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
            this.nightsInput = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nightResultLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nights stayed";
            // 
            // nightsInput
            // 
            this.nightsInput.Location = new System.Drawing.Point(102, 120);
            this.nightsInput.Name = "nightsInput";
            this.nightsInput.Size = new System.Drawing.Size(100, 20);
            this.nightsInput.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(209, 116);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(98, 24);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nightly Cost";
            // 
            // nightResultLbl
            // 
            this.nightResultLbl.AutoSize = true;
            this.nightResultLbl.Location = new System.Drawing.Point(344, 123);
            this.nightResultLbl.Name = "nightResultLbl";
            this.nightResultLbl.Size = new System.Drawing.Size(0, 13);
            this.nightResultLbl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(443, 122);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(0, 13);
            this.totalCostLbl.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nightResultLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.nightsInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nightsInput;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nightResultLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalCostLbl;
    }
}

