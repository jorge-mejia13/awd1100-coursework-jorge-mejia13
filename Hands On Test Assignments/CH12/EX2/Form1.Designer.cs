namespace EX2
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
            this.ipAddressInput = new System.Windows.Forms.TextBox();
            this.scanBtn = new System.Windows.Forms.Button();
            this.myDesktopResultLbl = new System.Windows.Forms.Label();
            this.servicesResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.Location = new System.Drawing.Point(289, 90);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(126, 20);
            this.ipAddressInput.TabIndex = 1;
            // 
            // scanBtn
            // 
            this.scanBtn.Location = new System.Drawing.Point(421, 90);
            this.scanBtn.Name = "scanBtn";
            this.scanBtn.Size = new System.Drawing.Size(75, 23);
            this.scanBtn.TabIndex = 2;
            this.scanBtn.Text = "Scan";
            this.scanBtn.UseVisualStyleBackColor = true;
            this.scanBtn.Click += new System.EventHandler(this.scanBtn_Click);
            // 
            // myDesktopResultLbl
            // 
            this.myDesktopResultLbl.AutoSize = true;
            this.myDesktopResultLbl.Location = new System.Drawing.Point(289, 145);
            this.myDesktopResultLbl.Name = "myDesktopResultLbl";
            this.myDesktopResultLbl.Size = new System.Drawing.Size(104, 13);
            this.myDesktopResultLbl.TabIndex = 3;
            this.myDesktopResultLbl.Text = "myDesktopResultLbl";
            // 
            // servicesResultLbl
            // 
            this.servicesResultLbl.AutoSize = true;
            this.servicesResultLbl.Location = new System.Drawing.Point(289, 196);
            this.servicesResultLbl.Name = "servicesResultLbl";
            this.servicesResultLbl.Size = new System.Drawing.Size(0, 13);
            this.servicesResultLbl.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.servicesResultLbl);
            this.Controls.Add(this.myDesktopResultLbl);
            this.Controls.Add(this.scanBtn);
            this.Controls.Add(this.ipAddressInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipAddressInput;
        private System.Windows.Forms.Button scanBtn;
        private System.Windows.Forms.Label myDesktopResultLbl;
        private System.Windows.Forms.Label servicesResultLbl;
    }
}

