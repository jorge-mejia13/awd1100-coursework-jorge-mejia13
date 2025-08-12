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
            this.label1 = new System.Windows.Forms.Label();
            this.accNumberInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pinNumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.depositInput = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.withdrawInput = new System.Windows.Forms.TextBox();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.statementBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.accInfoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account #:";
            // 
            // accNumberInput
            // 
            this.accNumberInput.Location = new System.Drawing.Point(315, 12);
            this.accNumberInput.Name = "accNumberInput";
            this.accNumberInput.Size = new System.Drawing.Size(164, 20);
            this.accNumberInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pin #:";
            // 
            // pinNumberInput
            // 
            this.pinNumberInput.Location = new System.Drawing.Point(315, 39);
            this.pinNumberInput.Name = "pinNumberInput";
            this.pinNumberInput.Size = new System.Drawing.Size(164, 20);
            this.pinNumberInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Would you like to make a deposit?";
            // 
            // depositInput
            // 
            this.depositInput.Location = new System.Drawing.Point(251, 227);
            this.depositInput.Name = "depositInput";
            this.depositInput.Size = new System.Drawing.Size(121, 20);
            this.depositInput.TabIndex = 8;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(378, 224);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 9;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Would you like to make a withdrawal?";
            // 
            // withdrawInput
            // 
            this.withdrawInput.Location = new System.Drawing.Point(251, 311);
            this.withdrawInput.Name = "withdrawInput";
            this.withdrawInput.Size = new System.Drawing.Size(121, 20);
            this.withdrawInput.TabIndex = 11;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(378, 308);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.withdrawBtn.TabIndex = 12;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // statementBtn
            // 
            this.statementBtn.Location = new System.Drawing.Point(302, 379);
            this.statementBtn.Name = "statementBtn";
            this.statementBtn.Size = new System.Drawing.Size(95, 37);
            this.statementBtn.TabIndex = 13;
            this.statementBtn.Text = "Print Statement";
            this.statementBtn.UseVisualStyleBackColor = true;
            this.statementBtn.Click += new System.EventHandler(this.statementBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(302, 445);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(95, 29);
            this.logoutBtn.TabIndex = 14;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(509, 22);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 37);
            this.loginBtn.TabIndex = 15;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // accInfoLbl
            // 
            this.accInfoLbl.AutoSize = true;
            this.accInfoLbl.Location = new System.Drawing.Point(251, 107);
            this.accInfoLbl.Name = "accInfoLbl";
            this.accInfoLbl.Size = new System.Drawing.Size(0, 13);
            this.accInfoLbl.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 581);
            this.Controls.Add(this.accInfoLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.statementBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pinNumberInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accNumberInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accNumberInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pinNumberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depositInput;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox withdrawInput;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button statementBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label accInfoLbl;
    }
}

