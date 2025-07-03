namespace Lab4
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
            this.statsInput = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.numCount = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.maxLbl = new System.Windows.Forms.Label();
            this.sumLbl = new System.Windows.Forms.Label();
            this.avgLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // statsInput
            // 
            this.statsInput.Location = new System.Drawing.Point(182, 85);
            this.statsInput.Multiline = true;
            this.statsInput.Name = "statsInput";
            this.statsInput.Size = new System.Drawing.Size(211, 53);
            this.statsInput.TabIndex = 0;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(409, 85);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(112, 52);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "button1";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // numCount
            // 
            this.numCount.AutoSize = true;
            this.numCount.Location = new System.Drawing.Point(178, 163);
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(51, 20);
            this.numCount.TabIndex = 2;
            this.numCount.Text = "label1";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.Location = new System.Drawing.Point(178, 198);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(51, 20);
            this.minLbl.TabIndex = 3;
            this.minLbl.Text = "label2";
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.Location = new System.Drawing.Point(178, 239);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(51, 20);
            this.maxLbl.TabIndex = 4;
            this.maxLbl.Text = "label3";
            // 
            // sumLbl
            // 
            this.sumLbl.AutoSize = true;
            this.sumLbl.Location = new System.Drawing.Point(178, 281);
            this.sumLbl.Name = "sumLbl";
            this.sumLbl.Size = new System.Drawing.Size(51, 20);
            this.sumLbl.TabIndex = 5;
            this.sumLbl.Text = "label4";
            // 
            // avgLbl
            // 
            this.avgLbl.AutoSize = true;
            this.avgLbl.Location = new System.Drawing.Point(178, 315);
            this.avgLbl.Name = "avgLbl";
            this.avgLbl.Size = new System.Drawing.Size(51, 20);
            this.avgLbl.TabIndex = 6;
            this.avgLbl.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 300);
            this.Controls.Add(this.avgLbl);
            this.Controls.Add(this.sumLbl);
            this.Controls.Add(this.maxLbl);
            this.Controls.Add(this.minLbl);
            this.Controls.Add(this.numCount);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.statsInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox statsInput;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label numCount;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label sumLbl;
        private System.Windows.Forms.Label avgLbl;
    }
}

