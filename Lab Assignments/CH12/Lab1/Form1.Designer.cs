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
            this.termInput = new System.Windows.Forms.TextBox();
            this.defineBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.definitionLbl = new System.Windows.Forms.Label();
            this.definitionInput = new System.Windows.Forms.TextBox();
            this.addTermBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termInput
            // 
            this.termInput.Location = new System.Drawing.Point(115, 70);
            this.termInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.termInput.Multiline = true;
            this.termInput.Name = "termInput";
            this.termInput.Size = new System.Drawing.Size(183, 33);
            this.termInput.TabIndex = 0;
            // 
            // defineBtn
            // 
            this.defineBtn.Location = new System.Drawing.Point(301, 70);
            this.defineBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.defineBtn.Name = "defineBtn";
            this.defineBtn.Size = new System.Drawing.Size(66, 31);
            this.defineBtn.TabIndex = 1;
            this.defineBtn.Text = "Define";
            this.defineBtn.UseVisualStyleBackColor = true;
            this.defineBtn.Click += new System.EventHandler(this.defineBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the term you want to define";
            // 
            // definitionLbl
            // 
            this.definitionLbl.AutoSize = true;
            this.definitionLbl.Location = new System.Drawing.Point(115, 127);
            this.definitionLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.definitionLbl.Name = "definitionLbl";
            this.definitionLbl.Size = new System.Drawing.Size(84, 13);
            this.definitionLbl.TabIndex = 3;
            this.definitionLbl.Text = "Definition here...";
            // 
            // definitionInput
            // 
            this.definitionInput.Location = new System.Drawing.Point(115, 188);
            this.definitionInput.Multiline = true;
            this.definitionInput.Name = "definitionInput";
            this.definitionInput.Size = new System.Drawing.Size(183, 33);
            this.definitionInput.TabIndex = 4;
            // 
            // addTermBtn
            // 
            this.addTermBtn.Location = new System.Drawing.Point(305, 188);
            this.addTermBtn.Name = "addTermBtn";
            this.addTermBtn.Size = new System.Drawing.Size(62, 32);
            this.addTermBtn.TabIndex = 5;
            this.addTermBtn.Text = "Add";
            this.addTermBtn.UseVisualStyleBackColor = true;
            this.addTermBtn.Click += new System.EventHandler(this.addTermBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.addTermBtn);
            this.Controls.Add(this.definitionInput);
            this.Controls.Add(this.definitionLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.defineBtn);
            this.Controls.Add(this.termInput);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox termInput;
        private System.Windows.Forms.Button defineBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label definitionLbl;
        private System.Windows.Forms.TextBox definitionInput;
        private System.Windows.Forms.Button addTermBtn;
    }
}

