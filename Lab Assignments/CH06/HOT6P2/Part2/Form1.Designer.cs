namespace Part2
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
            this.smBtn = new System.Windows.Forms.Button();
            this.mdBtn = new System.Windows.Forms.Button();
            this.lgBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clearOrderBtn = new System.Windows.Forms.Button();
            this.smCounterLbl = new System.Windows.Forms.Label();
            this.mdCounterLbl = new System.Windows.Forms.Label();
            this.lgCounterLbl = new System.Windows.Forms.Label();
            this.smLbl = new System.Windows.Forms.Label();
            this.mdLbl = new System.Windows.Forms.Label();
            this.lgLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What size shirts do you need?";
            // 
            // smBtn
            // 
            this.smBtn.Location = new System.Drawing.Point(231, 105);
            this.smBtn.Name = "smBtn";
            this.smBtn.Size = new System.Drawing.Size(75, 33);
            this.smBtn.TabIndex = 1;
            this.smBtn.Text = "S";
            this.smBtn.UseVisualStyleBackColor = true;
            this.smBtn.Click += new System.EventHandler(this.smBtn_Click);
            // 
            // mdBtn
            // 
            this.mdBtn.Location = new System.Drawing.Point(353, 105);
            this.mdBtn.Name = "mdBtn";
            this.mdBtn.Size = new System.Drawing.Size(75, 33);
            this.mdBtn.TabIndex = 2;
            this.mdBtn.Text = "M";
            this.mdBtn.UseVisualStyleBackColor = true;
            this.mdBtn.Click += new System.EventHandler(this.mdBtn_Click);
            // 
            // lgBtn
            // 
            this.lgBtn.Location = new System.Drawing.Point(479, 105);
            this.lgBtn.Name = "lgBtn";
            this.lgBtn.Size = new System.Drawing.Size(75, 33);
            this.lgBtn.TabIndex = 3;
            this.lgBtn.Text = "L";
            this.lgBtn.UseVisualStyleBackColor = true;
            this.lgBtn.Click += new System.EventHandler(this.lgBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "$9.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "$10.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "$11.99";
            // 
            // clearOrderBtn
            // 
            this.clearOrderBtn.Location = new System.Drawing.Point(367, 485);
            this.clearOrderBtn.Name = "clearOrderBtn";
            this.clearOrderBtn.Size = new System.Drawing.Size(75, 46);
            this.clearOrderBtn.TabIndex = 7;
            this.clearOrderBtn.Text = "Clear";
            this.clearOrderBtn.UseVisualStyleBackColor = true;
            this.clearOrderBtn.Click += new System.EventHandler(this.clearOrderBtn_Click);
            // 
            // smCounterLbl
            // 
            this.smCounterLbl.AutoSize = true;
            this.smCounterLbl.Location = new System.Drawing.Point(257, 145);
            this.smCounterLbl.Name = "smCounterLbl";
            this.smCounterLbl.Size = new System.Drawing.Size(18, 20);
            this.smCounterLbl.TabIndex = 8;
            this.smCounterLbl.Text = "0";
            // 
            // mdCounterLbl
            // 
            this.mdCounterLbl.AutoSize = true;
            this.mdCounterLbl.Location = new System.Drawing.Point(380, 144);
            this.mdCounterLbl.Name = "mdCounterLbl";
            this.mdCounterLbl.Size = new System.Drawing.Size(18, 20);
            this.mdCounterLbl.TabIndex = 9;
            this.mdCounterLbl.Text = "0";
            // 
            // lgCounterLbl
            // 
            this.lgCounterLbl.AutoSize = true;
            this.lgCounterLbl.Location = new System.Drawing.Point(509, 144);
            this.lgCounterLbl.Name = "lgCounterLbl";
            this.lgCounterLbl.Size = new System.Drawing.Size(18, 20);
            this.lgCounterLbl.TabIndex = 10;
            this.lgCounterLbl.Text = "0";
            // 
            // smLbl
            // 
            this.smLbl.AutoSize = true;
            this.smLbl.Location = new System.Drawing.Point(244, 222);
            this.smLbl.Name = "smLbl";
            this.smLbl.Size = new System.Drawing.Size(164, 20);
            this.smLbl.TabIndex = 11;
            this.smLbl.Text = "0 Small @ $9.99 each";
            // 
            // mdLbl
            // 
            this.mdLbl.AutoSize = true;
            this.mdLbl.Location = new System.Drawing.Point(244, 255);
            this.mdLbl.Name = "mdLbl";
            this.mdLbl.Size = new System.Drawing.Size(190, 20);
            this.mdLbl.TabIndex = 12;
            this.mdLbl.Text = "0 Medium @ $10.99 each";
            // 
            // lgLbl
            // 
            this.lgLbl.AutoSize = true;
            this.lgLbl.Location = new System.Drawing.Point(244, 287);
            this.lgLbl.Name = "lgLbl";
            this.lgLbl.Size = new System.Drawing.Size(175, 20);
            this.lgLbl.TabIndex = 13;
            this.lgLbl.Text = "0 Large @ $11.99 each";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(244, 344);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(95, 20);
            this.subtotalLbl.TabIndex = 14;
            this.subtotalLbl.Text = "Subtotal: $0";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(244, 375);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(60, 20);
            this.taxLbl.TabIndex = 15;
            this.taxLbl.Text = "Tax: $0";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(244, 405);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(70, 20);
            this.totalLbl.TabIndex = 16;
            this.totalLbl.Text = "Total: $0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 564);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.subtotalLbl);
            this.Controls.Add(this.lgLbl);
            this.Controls.Add(this.mdLbl);
            this.Controls.Add(this.smLbl);
            this.Controls.Add(this.lgCounterLbl);
            this.Controls.Add(this.mdCounterLbl);
            this.Controls.Add(this.smCounterLbl);
            this.Controls.Add(this.clearOrderBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lgBtn);
            this.Controls.Add(this.mdBtn);
            this.Controls.Add(this.smBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button smBtn;
        private System.Windows.Forms.Button mdBtn;
        private System.Windows.Forms.Button lgBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearOrderBtn;
        private System.Windows.Forms.Label smCounterLbl;
        private System.Windows.Forms.Label mdCounterLbl;
        private System.Windows.Forms.Label lgCounterLbl;
        private System.Windows.Forms.Label smLbl;
        private System.Windows.Forms.Label mdLbl;
        private System.Windows.Forms.Label lgLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label label5;
    }
}

