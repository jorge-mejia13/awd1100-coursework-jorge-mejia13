namespace Lab6
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
            this.woodInput = new System.Windows.Forms.TextBox();
            this.drawersInput = new System.Windows.Forms.TextBox();
            this.estimateBtn = new System.Windows.Forms.Button();
            this.woodLbl = new System.Windows.Forms.Label();
            this.drawerLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // woodInput
            // 
            this.woodInput.Location = new System.Drawing.Point(174, 87);
            this.woodInput.Multiline = true;
            this.woodInput.Name = "woodInput";
            this.woodInput.Size = new System.Drawing.Size(161, 52);
            this.woodInput.TabIndex = 0;
            // 
            // drawersInput
            // 
            this.drawersInput.Location = new System.Drawing.Point(357, 87);
            this.drawersInput.Multiline = true;
            this.drawersInput.Name = "drawersInput";
            this.drawersInput.Size = new System.Drawing.Size(145, 52);
            this.drawersInput.TabIndex = 1;
            // 
            // estimateBtn
            // 
            this.estimateBtn.Location = new System.Drawing.Point(174, 162);
            this.estimateBtn.Name = "estimateBtn";
            this.estimateBtn.Size = new System.Drawing.Size(133, 36);
            this.estimateBtn.TabIndex = 2;
            this.estimateBtn.Text = "Estimate";
            this.estimateBtn.UseVisualStyleBackColor = true;
            this.estimateBtn.Click += new System.EventHandler(this.estimateBtn_Click);
            // 
            // woodLbl
            // 
            this.woodLbl.AutoSize = true;
            this.woodLbl.Location = new System.Drawing.Point(170, 270);
            this.woodLbl.Name = "woodLbl";
            this.woodLbl.Size = new System.Drawing.Size(106, 20);
            this.woodLbl.TabIndex = 3;
            this.woodLbl.Text = "Cost of Wood";
            // 
            // drawerLbl
            // 
            this.drawerLbl.AutoSize = true;
            this.drawerLbl.Location = new System.Drawing.Point(327, 270);
            this.drawerLbl.Name = "drawerLbl";
            this.drawerLbl.Size = new System.Drawing.Size(123, 20);
            this.drawerLbl.TabIndex = 4;
            this.drawerLbl.Text = "Cost of Drawers";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(517, 270);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(81, 20);
            this.totalLbl.TabIndex = 5;
            this.totalLbl.Text = "Total Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.drawerLbl);
            this.Controls.Add(this.woodLbl);
            this.Controls.Add(this.estimateBtn);
            this.Controls.Add(this.drawersInput);
            this.Controls.Add(this.woodInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox woodInput;
        private System.Windows.Forms.TextBox drawersInput;
        private System.Windows.Forms.Button estimateBtn;
        private System.Windows.Forms.Label woodLbl;
        private System.Windows.Forms.Label drawerLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}

