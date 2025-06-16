namespace Lab_5
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
            this.numberInput = new System.Windows.Forms.TextBox();
            this.maskBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Location = new System.Drawing.Point(116, 109);
            this.numberInput.Multiline = true;
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(256, 49);
            this.numberInput.TabIndex = 0;
            // 
            // maskBtn
            // 
            this.maskBtn.Location = new System.Drawing.Point(393, 109);
            this.maskBtn.Name = "maskBtn";
            this.maskBtn.Size = new System.Drawing.Size(129, 49);
            this.maskBtn.TabIndex = 1;
            this.maskBtn.Text = "Mask";
            this.maskBtn.UseVisualStyleBackColor = true;
            this.maskBtn.Click += new System.EventHandler(this.maskBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(116, 212);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(90, 20);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = "574839383";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.maskBtn);
            this.Controls.Add(this.numberInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Button maskBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

