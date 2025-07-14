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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accInput = new System.Windows.Forms.TextBox();
            this.pinInput = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.depositInput = new System.Windows.Forms.TextBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.withdrawInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pin #:";
            // 
            // accInput
            // 
            this.accInput.Location = new System.Drawing.Point(109, 27);
            this.accInput.Name = "accInput";
            this.accInput.Size = new System.Drawing.Size(141, 20);
            this.accInput.TabIndex = 2;
            // 
            // pinInput
            // 
            this.pinInput.Location = new System.Drawing.Point(84, 63);
            this.pinInput.Name = "pinInput";
            this.pinInput.Size = new System.Drawing.Size(144, 20);
            this.pinInput.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(331, 35);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 38);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(185, 125);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(61, 13);
            this.welcomeLbl.TabIndex = 5;
            this.welcomeLbl.Text = "Welcome...";
            // 
            // balanceLbl
            // 
            this.balanceLbl.AutoSize = true;
            this.balanceLbl.Location = new System.Drawing.Point(185, 153);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(131, 13);
            this.balanceLbl.TabIndex = 6;
            this.balanceLbl.Text = "Your account balance is...";
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(188, 483);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 39);
            this.logoutBtn.TabIndex = 7;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Would you like to make a deposit?";
            // 
            // depositInput
            // 
            this.depositInput.Location = new System.Drawing.Point(48, 288);
            this.depositInput.Name = "depositInput";
            this.depositInput.Size = new System.Drawing.Size(167, 20);
            this.depositInput.TabIndex = 9;
            // 
            // depositBtn
            // 
            this.depositBtn.Location = new System.Drawing.Point(222, 288);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(75, 23);
            this.depositBtn.TabIndex = 10;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(222, 365);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(75, 23);
            this.withdrawBtn.TabIndex = 13;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // withdrawInput
            // 
            this.withdrawInput.Location = new System.Drawing.Point(48, 365);
            this.withdrawInput.Name = "withdrawInput";
            this.withdrawInput.Size = new System.Drawing.Size(167, 20);
            this.withdrawInput.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Would you like to make a withdrawal?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.withdrawInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.depositInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.balanceLbl);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pinInput);
            this.Controls.Add(this.accInput);
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
        private System.Windows.Forms.TextBox accInput;
        private System.Windows.Forms.TextBox pinInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox depositInput;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.TextBox withdrawInput;
        private System.Windows.Forms.Label label4;
    }
}

