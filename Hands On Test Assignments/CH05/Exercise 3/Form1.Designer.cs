namespace Exercise_3
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.areaLbl = new System.Windows.Forms.Label();
            this.weeklyFeeLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(245, 100);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(135, 26);
            this.lengthInput.TabIndex = 0;
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(428, 99);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(123, 26);
            this.widthInput.TabIndex = 1;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(245, 180);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(306, 38);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Length (ft)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width (ft)";
            // 
            // areaLbl
            // 
            this.areaLbl.AutoSize = true;
            this.areaLbl.Location = new System.Drawing.Point(249, 263);
            this.areaLbl.Name = "areaLbl";
            this.areaLbl.Size = new System.Drawing.Size(43, 20);
            this.areaLbl.TabIndex = 5;
            this.areaLbl.Text = "Area";
            // 
            // weeklyFeeLbl
            // 
            this.weeklyFeeLbl.AutoSize = true;
            this.weeklyFeeLbl.Location = new System.Drawing.Point(249, 299);
            this.weeklyFeeLbl.Name = "weeklyFeeLbl";
            this.weeklyFeeLbl.Size = new System.Drawing.Size(92, 20);
            this.weeklyFeeLbl.TabIndex = 6;
            this.weeklyFeeLbl.Text = "Weekly Fee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Season Length 20 weeks";
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Location = new System.Drawing.Point(249, 368);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(81, 20);
            this.totalCostLbl.TabIndex = 8;
            this.totalCostLbl.Text = "Total Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weeklyFeeLbl);
            this.Controls.Add(this.areaLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateBtn);
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
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label areaLbl;
        private System.Windows.Forms.Label weeklyFeeLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalCostLbl;
    }
}

