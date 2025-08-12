namespace EX1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shortTermBtn = new System.Windows.Forms.RadioButton();
            this.longTermBtn = new System.Windows.Forms.RadioButton();
            this.createLoanBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.makePaymentBtn = new System.Windows.Forms.Button();
            this.remainingBalanceLbl = new System.Windows.Forms.Label();
            this.remainingBalancePlusInterestLbl = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amountInput);
            this.groupBox1.Controls.Add(this.nameInput);
            this.groupBox1.Controls.Add(this.createLoanBtn);
            this.groupBox1.Controls.Add(this.longTermBtn);
            this.groupBox1.Controls.Add(this.shortTermBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 199);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Loan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // shortTermBtn
            // 
            this.shortTermBtn.AutoSize = true;
            this.shortTermBtn.Location = new System.Drawing.Point(48, 81);
            this.shortTermBtn.Name = "shortTermBtn";
            this.shortTermBtn.Size = new System.Drawing.Size(104, 17);
            this.shortTermBtn.TabIndex = 3;
            this.shortTermBtn.TabStop = true;
            this.shortTermBtn.Text = "Short-Term Loan";
            this.shortTermBtn.UseVisualStyleBackColor = true;
            // 
            // longTermBtn
            // 
            this.longTermBtn.AutoSize = true;
            this.longTermBtn.Location = new System.Drawing.Point(48, 105);
            this.longTermBtn.Name = "longTermBtn";
            this.longTermBtn.Size = new System.Drawing.Size(103, 17);
            this.longTermBtn.TabIndex = 4;
            this.longTermBtn.TabStop = true;
            this.longTermBtn.Text = "Long-Term Loan";
            this.longTermBtn.UseVisualStyleBackColor = true;
            // 
            // createLoanBtn
            // 
            this.createLoanBtn.Location = new System.Drawing.Point(48, 138);
            this.createLoanBtn.Name = "createLoanBtn";
            this.createLoanBtn.Size = new System.Drawing.Size(92, 40);
            this.createLoanBtn.TabIndex = 5;
            this.createLoanBtn.Text = "Create Loan";
            this.createLoanBtn.UseVisualStyleBackColor = true;
            this.createLoanBtn.Click += new System.EventHandler(this.createLoanBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remainingBalancePlusInterestLbl);
            this.groupBox2.Controls.Add(this.remainingBalanceLbl);
            this.groupBox2.Controls.Add(this.makePaymentBtn);
            this.groupBox2.Controls.Add(this.balanceLbl);
            this.groupBox2.Controls.Add(this.nameLbl);
            this.groupBox2.Location = new System.Drawing.Point(35, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 244);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage Loan";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.nameLbl.Location = new System.Drawing.Point(6, 30);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(122, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Joes Auto Sale";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(7, 64);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(133, 13);
            this.balanceLbl.TabIndex = 1;
            this.balanceLbl.Text = "Long-Term Loan of $1,000";
            // 
            // makePaymentBtn
            // 
            this.makePaymentBtn.Location = new System.Drawing.Point(6, 92);
            this.makePaymentBtn.Name = "makePaymentBtn";
            this.makePaymentBtn.Size = new System.Drawing.Size(133, 35);
            this.makePaymentBtn.TabIndex = 2;
            this.makePaymentBtn.Text = "Make Payment";
            this.makePaymentBtn.UseVisualStyleBackColor = true;
            this.makePaymentBtn.Click += new System.EventHandler(this.makePaymentBtn_Click);
            // 
            // remainingBalanceLbl
            // 
            this.remainingBalanceLbl.AutoSize = true;
            this.remainingBalanceLbl.Location = new System.Drawing.Point(7, 153);
            this.remainingBalanceLbl.Name = "remainingBalanceLbl";
            this.remainingBalanceLbl.Size = new System.Drawing.Size(0, 13);
            this.remainingBalanceLbl.TabIndex = 3;
            // 
            // remainingBalancePlusInterestLbl
            // 
            this.remainingBalancePlusInterestLbl.AutoSize = true;
            this.remainingBalancePlusInterestLbl.Location = new System.Drawing.Point(6, 179);
            this.remainingBalancePlusInterestLbl.Name = "remainingBalancePlusInterestLbl";
            this.remainingBalancePlusInterestLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.remainingBalancePlusInterestLbl.Size = new System.Drawing.Size(0, 13);
            this.remainingBalancePlusInterestLbl.TabIndex = 4;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(55, 24);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(181, 20);
            this.nameInput.TabIndex = 1;
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(55, 49);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(181, 20);
            this.amountInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createLoanBtn;
        private System.Windows.Forms.RadioButton longTermBtn;
        private System.Windows.Forms.RadioButton shortTermBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label remainingBalancePlusInterestLbl;
        private System.Windows.Forms.Label remainingBalanceLbl;
        private System.Windows.Forms.Button makePaymentBtn;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox amountInput;
    }
}

