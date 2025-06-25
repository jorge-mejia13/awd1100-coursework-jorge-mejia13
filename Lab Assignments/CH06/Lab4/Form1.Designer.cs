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
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.totalAreaLbl = new System.Windows.Forms.Label();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(138, 165);
            this.lengthInput.Multiline = true;
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(135, 40);
            this.lengthInput.TabIndex = 0;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(292, 165);
            this.widthInput.Multiline = true;
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(135, 39);
            this.widthInput.TabIndex = 1;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(442, 165);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(83, 39);
            this.calcBtn.TabIndex = 2;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // totalAreaLbl
            // 
            this.totalAreaLbl.AutoSize = true;
            this.totalAreaLbl.Location = new System.Drawing.Point(138, 251);
            this.totalAreaLbl.Name = "totalAreaLbl";
            this.totalAreaLbl.Size = new System.Drawing.Size(82, 20);
            this.totalAreaLbl.TabIndex = 3;
            this.totalAreaLbl.Text = "Total Area";
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Location = new System.Drawing.Point(138, 295);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(83, 20);
            this.totalPriceLbl.TabIndex = 4;
            this.totalPriceLbl.Text = "Total Price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalPriceLbl);
            this.Controls.Add(this.totalAreaLbl);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.lengthInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Label totalAreaLbl;
        private System.Windows.Forms.Label totalPriceLbl;
    }
}

