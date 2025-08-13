namespace LB4
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
            this.encodeInput = new System.Windows.Forms.TextBox();
            this.decodeInput = new System.Windows.Forms.TextBox();
            this.encodeBtn = new System.Windows.Forms.Button();
            this.decodeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shiftInput = new System.Windows.Forms.TextBox();
            this.encodeErrorLbl = new System.Windows.Forms.Label();
            this.decodeErrorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encodeInput
            // 
            this.encodeInput.Location = new System.Drawing.Point(141, 85);
            this.encodeInput.Multiline = true;
            this.encodeInput.Name = "encodeInput";
            this.encodeInput.Size = new System.Drawing.Size(197, 34);
            this.encodeInput.TabIndex = 0;
            // 
            // decodeInput
            // 
            this.decodeInput.Location = new System.Drawing.Point(141, 156);
            this.decodeInput.Multiline = true;
            this.decodeInput.Name = "decodeInput";
            this.decodeInput.Size = new System.Drawing.Size(197, 34);
            this.decodeInput.TabIndex = 1;
            // 
            // encodeBtn
            // 
            this.encodeBtn.Location = new System.Drawing.Point(376, 85);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(94, 33);
            this.encodeBtn.TabIndex = 2;
            this.encodeBtn.Text = "Encode";
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // decodeBtn
            // 
            this.decodeBtn.Location = new System.Drawing.Point(376, 157);
            this.decodeBtn.Name = "decodeBtn";
            this.decodeBtn.Size = new System.Drawing.Size(94, 33);
            this.decodeBtn.TabIndex = 3;
            this.decodeBtn.Text = "Decode";
            this.decodeBtn.UseVisualStyleBackColor = true;
            this.decodeBtn.Click += new System.EventHandler(this.decodeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Shift";
            // 
            // shiftInput
            // 
            this.shiftInput.Location = new System.Drawing.Point(564, 131);
            this.shiftInput.Name = "shiftInput";
            this.shiftInput.Size = new System.Drawing.Size(100, 20);
            this.shiftInput.TabIndex = 5;
            // 
            // encodeErrorLbl
            // 
            this.encodeErrorLbl.AutoSize = true;
            this.encodeErrorLbl.Location = new System.Drawing.Point(141, 126);
            this.encodeErrorLbl.Name = "encodeErrorLbl";
            this.encodeErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.encodeErrorLbl.TabIndex = 6;
            // 
            // decodeErrorLbl
            // 
            this.decodeErrorLbl.AutoSize = true;
            this.decodeErrorLbl.Location = new System.Drawing.Point(141, 197);
            this.decodeErrorLbl.Name = "decodeErrorLbl";
            this.decodeErrorLbl.Size = new System.Drawing.Size(0, 13);
            this.decodeErrorLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decodeErrorLbl);
            this.Controls.Add(this.encodeErrorLbl);
            this.Controls.Add(this.shiftInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decodeBtn);
            this.Controls.Add(this.encodeBtn);
            this.Controls.Add(this.decodeInput);
            this.Controls.Add(this.encodeInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox encodeInput;
        private System.Windows.Forms.TextBox decodeInput;
        private System.Windows.Forms.Button encodeBtn;
        private System.Windows.Forms.Button decodeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shiftInput;
        private System.Windows.Forms.Label encodeErrorLbl;
        private System.Windows.Forms.Label decodeErrorLbl;
    }
}

