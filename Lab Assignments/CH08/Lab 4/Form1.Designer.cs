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
            this.movieSearchInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.directorLbl = new System.Windows.Forms.Label();
            this.descLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // movieSearchInput
            // 
            this.movieSearchInput.Location = new System.Drawing.Point(187, 105);
            this.movieSearchInput.Multiline = true;
            this.movieSearchInput.Name = "movieSearchInput";
            this.movieSearchInput.Size = new System.Drawing.Size(144, 39);
            this.movieSearchInput.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(358, 105);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 39);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(187, 183);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(59, 20);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "Name: ";
            // 
            // directorLbl
            // 
            this.directorLbl.AutoSize = true;
            this.directorLbl.Location = new System.Drawing.Point(187, 224);
            this.directorLbl.Name = "directorLbl";
            this.directorLbl.Size = new System.Drawing.Size(73, 20);
            this.directorLbl.TabIndex = 3;
            this.directorLbl.Text = "Director: ";
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Location = new System.Drawing.Point(187, 267);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(93, 20);
            this.descLbl.TabIndex = 4;
            this.descLbl.Text = "Description:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.directorLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.movieSearchInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox movieSearchInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label directorLbl;
        private System.Windows.Forms.Label descLbl;
    }
}

