namespace Lab_4
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
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.danielleBtn = new System.Windows.Forms.Button();
            this.francisBtn = new System.Windows.Forms.Button();
            this.edwardBtn = new System.Windows.Forms.Button();
            this.danielleLbl = new System.Windows.Forms.Label();
            this.edwardLbl = new System.Windows.Forms.Label();
            this.francisLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.mostSalesLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the amount of the sale";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(130, 74);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(137, 20);
            this.inputTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Who made the sale?";
            // 
            // danielleBtn
            // 
            this.danielleBtn.Location = new System.Drawing.Point(133, 140);
            this.danielleBtn.Name = "danielleBtn";
            this.danielleBtn.Size = new System.Drawing.Size(75, 23);
            this.danielleBtn.TabIndex = 3;
            this.danielleBtn.Text = "Danielle";
            this.danielleBtn.UseVisualStyleBackColor = true;
            this.danielleBtn.Click += new System.EventHandler(this.danielleBtn_Click);
            // 
            // francisBtn
            // 
            this.francisBtn.Location = new System.Drawing.Point(214, 139);
            this.francisBtn.Name = "francisBtn";
            this.francisBtn.Size = new System.Drawing.Size(75, 23);
            this.francisBtn.TabIndex = 4;
            this.francisBtn.Text = "Francis";
            this.francisBtn.UseVisualStyleBackColor = true;
            this.francisBtn.Click += new System.EventHandler(this.francisBtn_Click);
            // 
            // edwardBtn
            // 
            this.edwardBtn.Location = new System.Drawing.Point(296, 140);
            this.edwardBtn.Name = "edwardBtn";
            this.edwardBtn.Size = new System.Drawing.Size(75, 23);
            this.edwardBtn.TabIndex = 5;
            this.edwardBtn.Text = "Edward";
            this.edwardBtn.UseVisualStyleBackColor = true;
            this.edwardBtn.Click += new System.EventHandler(this.edwardBtn_Click);
            // 
            // danielleLbl
            // 
            this.danielleLbl.AutoSize = true;
            this.danielleLbl.Location = new System.Drawing.Point(133, 233);
            this.danielleLbl.Name = "danielleLbl";
            this.danielleLbl.Size = new System.Drawing.Size(85, 13);
            this.danielleLbl.TabIndex = 6;
            this.danielleLbl.Text = "Danielles Sales: ";
            // 
            // edwardLbl
            // 
            this.edwardLbl.AutoSize = true;
            this.edwardLbl.Location = new System.Drawing.Point(133, 267);
            this.edwardLbl.Name = "edwardLbl";
            this.edwardLbl.Size = new System.Drawing.Size(83, 13);
            this.edwardLbl.TabIndex = 7;
            this.edwardLbl.Text = "Edwards Sales: ";
            // 
            // francisLbl
            // 
            this.francisLbl.AutoSize = true;
            this.francisLbl.Location = new System.Drawing.Point(133, 300);
            this.francisLbl.Name = "francisLbl";
            this.francisLbl.Size = new System.Drawing.Size(76, 13);
            this.francisLbl.TabIndex = 8;
            this.francisLbl.Text = "Francis Sales: ";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(133, 336);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(65, 13);
            this.totalLbl.TabIndex = 9;
            this.totalLbl.Text = "Grand total: ";
            // 
            // mostSalesLbl
            // 
            this.mostSalesLbl.AutoSize = true;
            this.mostSalesLbl.Location = new System.Drawing.Point(136, 386);
            this.mostSalesLbl.Name = "mostSalesLbl";
            this.mostSalesLbl.Size = new System.Drawing.Size(94, 13);
            this.mostSalesLbl.TabIndex = 10;
            this.mostSalesLbl.Text = "has the most sales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostSalesLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.francisLbl);
            this.Controls.Add(this.edwardLbl);
            this.Controls.Add(this.danielleLbl);
            this.Controls.Add(this.edwardBtn);
            this.Controls.Add(this.francisBtn);
            this.Controls.Add(this.danielleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button danielleBtn;
        private System.Windows.Forms.Button francisBtn;
        private System.Windows.Forms.Button edwardBtn;
        private System.Windows.Forms.Label danielleLbl;
        private System.Windows.Forms.Label edwardLbl;
        private System.Windows.Forms.Label francisLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label mostSalesLbl;
    }
}

