namespace Lab3
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
            this.bidInput = new System.Windows.Forms.TextBox();
            this.validateBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bidInput
            // 
            this.bidInput.Location = new System.Drawing.Point(192, 168);
            this.bidInput.Multiline = true;
            this.bidInput.Name = "bidInput";
            this.bidInput.Size = new System.Drawing.Size(222, 62);
            this.bidInput.TabIndex = 0;
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(421, 168);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(110, 61);
            this.validateBtn.TabIndex = 1;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(612, 188);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(36, 20);
            this.resultLbl.TabIndex = 2;
            this.resultLbl.Text = "$35";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 565);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.bidInput);
            this.Name = "Form1";
            this.Text = "h";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bidInput;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

