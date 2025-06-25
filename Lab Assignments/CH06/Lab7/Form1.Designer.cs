namespace Lab7
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
            this.label2 = new System.Windows.Forms.Label();
            this.accNumInput = new System.Windows.Forms.TextBox();
            this.pinNumInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.greetingLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.depositInput = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.withdrawInput = new System.Windows.Forms.TextBox();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pin #:";
            // 
            // accNumInput
            // 
            this.accNumInput.Location = new System.Drawing.Point(236, 36);
            this.accNumInput.Name = "accNumInput";
            this.accNumInput.Size = new System.Drawing.Size(153, 26);
            this.accNumInput.TabIndex = 2;
            // 
            // pinNumInput
            // 
            this.pinNumInput.Location = new System.Drawing.Point(199, 78);
            this.pinNumInput.Name = "pinNumInput";
            this.pinNumInput.Size = new System.Drawing.Size(128, 26);
            this.pinNumInput.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(435, 68);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(109, 36);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // greetingLbl
            // 
            this.greetingLbl.AutoSize = true;
            this.greetingLbl.Location = new System.Drawing.Point(148, 182);
            this.greetingLbl.Name = "greetingLbl";
            this.greetingLbl.Size = new System.Drawing.Size(79, 20);
            this.greetingLbl.TabIndex = 5;
            this.greetingLbl.Text = "Welcome:";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(148, 202);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(134, 20);
            this.balanceLbl.TabIndex = 6;
            this.balanceLbl.Text = "Account Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Would you like to make a deposit?";
            // 
            // depositInput
            // 
            this.depositInput.Location = new System.Drawing.Point(148, 297);
            this.depositInput.Name = "depositInput";
            this.depositInput.Size = new System.Drawing.Size(148, 26);
            this.depositInput.TabIndex = 8;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(302, 297);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(95, 26);
            this.depositBtn.TabIndex = 9;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Would you like to make a withdrawal?";
            // 
            // withdrawInput
            // 
            this.withdrawInput.Location = new System.Drawing.Point(148, 394);
            this.withdrawInput.Name = "withdrawInput";
            this.withdrawInput.Size = new System.Drawing.Size(148, 26);
            this.withdrawInput.TabIndex = 11;
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(303, 394);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(102, 25);
            this.withdrawBtn.TabIndex = 12;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(334, 494);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(131, 37);
            this.logoutBtn.TabIndex = 13;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 586);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.greetingLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pinNumInput);
            this.Controls.Add(this.accNumInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accNumInput;
        private System.Windows.Forms.TextBox pinNumInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label greetingLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depositInput;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox withdrawInput;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}

