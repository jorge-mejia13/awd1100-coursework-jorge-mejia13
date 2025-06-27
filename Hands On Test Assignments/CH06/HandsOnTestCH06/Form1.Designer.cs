namespace HandsOnTestCH06
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
            this.authorInput = new System.Windows.Forms.TextBox();
            this.authorSearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.isbnInput = new System.Windows.Forms.TextBox();
            this.isbnSearchBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keywordInput = new System.Windows.Forms.TextBox();
            this.keywordSearchBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.authorLbl = new System.Windows.Forms.Label();
            this.isbnLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Author";
            // 
            // authorInput
            // 
            this.authorInput.Location = new System.Drawing.Point(192, 47);
            this.authorInput.Name = "authorInput";
            this.authorInput.Size = new System.Drawing.Size(152, 26);
            this.authorInput.TabIndex = 1;
            // 
            // authorSearchBtn
            // 
            this.authorSearchBtn.Location = new System.Drawing.Point(351, 47);
            this.authorSearchBtn.Name = "authorSearchBtn";
            this.authorSearchBtn.Size = new System.Drawing.Size(75, 26);
            this.authorSearchBtn.TabIndex = 2;
            this.authorSearchBtn.Text = "Search";
            this.authorSearchBtn.UseVisualStyleBackColor = true;
            this.authorSearchBtn.Click += new System.EventHandler(this.authorSearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN";
            // 
            // isbnInput
            // 
            this.isbnInput.Location = new System.Drawing.Point(192, 95);
            this.isbnInput.Name = "isbnInput";
            this.isbnInput.Size = new System.Drawing.Size(152, 26);
            this.isbnInput.TabIndex = 4;
            // 
            // isbnSearchBtn
            // 
            this.isbnSearchBtn.Location = new System.Drawing.Point(351, 95);
            this.isbnSearchBtn.Name = "isbnSearchBtn";
            this.isbnSearchBtn.Size = new System.Drawing.Size(75, 26);
            this.isbnSearchBtn.TabIndex = 5;
            this.isbnSearchBtn.Text = "Search";
            this.isbnSearchBtn.UseVisualStyleBackColor = true;
            this.isbnSearchBtn.Click += new System.EventHandler(this.isbnSearchBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Keyword";
            // 
            // keywordInput
            // 
            this.keywordInput.Location = new System.Drawing.Point(192, 143);
            this.keywordInput.Name = "keywordInput";
            this.keywordInput.Size = new System.Drawing.Size(152, 26);
            this.keywordInput.TabIndex = 7;
            // 
            // keywordSearchBtn
            // 
            this.keywordSearchBtn.Location = new System.Drawing.Point(351, 143);
            this.keywordSearchBtn.Name = "keywordSearchBtn";
            this.keywordSearchBtn.Size = new System.Drawing.Size(75, 26);
            this.keywordSearchBtn.TabIndex = 8;
            this.keywordSearchBtn.Text = "Search";
            this.keywordSearchBtn.UseVisualStyleBackColor = true;
            this.keywordSearchBtn.Click += new System.EventHandler(this.keywordSearchBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(117, 256);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 20);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Name";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(117, 316);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(89, 20);
            this.descLbl.TabIndex = 10;
            this.descLbl.Text = "Description";
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(121, 385);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(57, 20);
            this.authorLbl.TabIndex = 11;
            this.authorLbl.Text = "Author";
            // 
            // isbnLbl
            // 
            this.isbnLbl.AutoSize = true;
            this.isbnLbl.Location = new System.Drawing.Point(121, 456);
            this.isbnLbl.Name = "isbnLbl";
            this.isbnLbl.Size = new System.Drawing.Size(47, 20);
            this.isbnLbl.TabIndex = 12;
            this.isbnLbl.Text = "ISBN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.isbnLbl);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.keywordSearchBtn);
            this.Controls.Add(this.keywordInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isbnSearchBtn);
            this.Controls.Add(this.isbnInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.authorSearchBtn);
            this.Controls.Add(this.authorInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox authorInput;
        private System.Windows.Forms.Button authorSearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox isbnInput;
        private System.Windows.Forms.Button isbnSearchBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keywordInput;
        private System.Windows.Forms.Button keywordSearchBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.Label isbnLbl;
    }
}

