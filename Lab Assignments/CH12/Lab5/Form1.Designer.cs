namespace Lab5
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.hoursToCompleteInput = new System.Windows.Forms.TextBox();
            this.hourlyRateInput = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.descriptionLbl = new System.Windows.Forms.Label();
            this.hoursToCompleteLbl = new System.Windows.Forms.Label();
            this.hourlyRateLbl = new System.Windows.Forms.Label();
            this.totalFeeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hours to complete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hourly rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total fee";
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(251, 66);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(100, 20);
            this.descriptionInput.TabIndex = 4;
            // 
            // hoursToCompleteInput
            // 
            this.hoursToCompleteInput.Location = new System.Drawing.Point(251, 99);
            this.hoursToCompleteInput.Name = "hoursToCompleteInput";
            this.hoursToCompleteInput.Size = new System.Drawing.Size(100, 20);
            this.hoursToCompleteInput.TabIndex = 5;
            // 
            // hourlyRateInput
            // 
            this.hourlyRateInput.Location = new System.Drawing.Point(251, 129);
            this.hourlyRateInput.Name = "hourlyRateInput";
            this.hourlyRateInput.Size = new System.Drawing.Size(100, 20);
            this.hourlyRateInput.TabIndex = 6;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(219, 240);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 44);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "New value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Current value";
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.Location = new System.Drawing.Point(433, 66);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(33, 13);
            this.descriptionLbl.TabIndex = 10;
            this.descriptionLbl.Text = "Job...";
            // 
            // hoursToCompleteLbl
            // 
            this.hoursToCompleteLbl.AutoSize = true;
            this.hoursToCompleteLbl.Location = new System.Drawing.Point(433, 99);
            this.hoursToCompleteLbl.Name = "hoursToCompleteLbl";
            this.hoursToCompleteLbl.Size = new System.Drawing.Size(100, 13);
            this.hoursToCompleteLbl.TabIndex = 11;
            this.hoursToCompleteLbl.Text = "hours to complete...";
            // 
            // hourlyRateLbl
            // 
            this.hourlyRateLbl.AutoSize = true;
            this.hourlyRateLbl.Location = new System.Drawing.Point(433, 136);
            this.hourlyRateLbl.Name = "hourlyRateLbl";
            this.hourlyRateLbl.Size = new System.Drawing.Size(65, 13);
            this.hourlyRateLbl.TabIndex = 12;
            this.hourlyRateLbl.Text = "hourly rate...";
            // 
            // totalFeeLbl
            // 
            this.totalFeeLbl.AutoSize = true;
            this.totalFeeLbl.Location = new System.Drawing.Point(433, 166);
            this.totalFeeLbl.Name = "totalFeeLbl";
            this.totalFeeLbl.Size = new System.Drawing.Size(58, 13);
            this.totalFeeLbl.TabIndex = 13;
            this.totalFeeLbl.Text = "Total fee...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalFeeLbl);
            this.Controls.Add(this.hourlyRateLbl);
            this.Controls.Add(this.hoursToCompleteLbl);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.hourlyRateInput);
            this.Controls.Add(this.hoursToCompleteInput);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.TextBox hoursToCompleteInput;
        private System.Windows.Forms.TextBox hourlyRateInput;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label descriptionLbl;
        private System.Windows.Forms.Label hoursToCompleteLbl;
        private System.Windows.Forms.Label hourlyRateLbl;
        private System.Windows.Forms.Label totalFeeLbl;
    }
}

