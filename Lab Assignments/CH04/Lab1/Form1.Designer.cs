namespace Lab1
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
            this.milesTxt = new System.Windows.Forms.TextBox();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.milesBtn = new System.Windows.Forms.Button();
            this.kmBtn = new System.Windows.Forms.Button();
            this.milesLbl = new System.Windows.Forms.Label();
            this.kmLbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // milesTxt
            // 
            this.milesTxt.Location = new System.Drawing.Point(128, 117);
            this.milesTxt.Name = "milesTxt";
            this.milesTxt.Size = new System.Drawing.Size(100, 26);
            this.milesTxt.TabIndex = 0;
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(310, 116);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(100, 26);
            this.kmTxt.TabIndex = 1;
            // 
            // milesBtn
            // 
            this.milesBtn.Location = new System.Drawing.Point(128, 168);
            this.milesBtn.Name = "milesBtn";
            this.milesBtn.Size = new System.Drawing.Size(134, 36);
            this.milesBtn.TabIndex = 2;
            this.milesBtn.Text = "Convert to KM";
            this.milesBtn.UseVisualStyleBackColor = true;
            this.milesBtn.Click += new System.EventHandler(this.milesBtn_Click);
            // 
            // kmBtn
            // 
            this.kmBtn.Location = new System.Drawing.Point(310, 167);
            this.kmBtn.Name = "kmBtn";
            this.kmBtn.Size = new System.Drawing.Size(145, 37);
            this.kmBtn.TabIndex = 3;
            this.kmBtn.Text = "Convert to Miles";
            this.kmBtn.UseVisualStyleBackColor = true;
            this.kmBtn.Click += new System.EventHandler(this.kmBtn_Click);
            // 
            // milesLbl
            // 
            this.milesLbl.AutoSize = true;
            this.milesLbl.Location = new System.Drawing.Point(128, 91);
            this.milesLbl.Name = "milesLbl";
            this.milesLbl.Size = new System.Drawing.Size(92, 20);
            this.milesLbl.TabIndex = 4;
            this.milesLbl.Text = "Enter miles ";
            // 
            // kmLbl
            // 
            this.kmLbl.AutoSize = true;
            this.kmLbl.Location = new System.Drawing.Point(310, 90);
            this.kmLbl.Name = "kmLbl";
            this.kmLbl.Size = new System.Drawing.Size(124, 20);
            this.kmLbl.TabIndex = 5;
            this.kmLbl.Text = "Enter kilometers";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(128, 249);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(98, 20);
            this.answerLbl.TabIndex = 6;
            this.answerLbl.Text = "Answer here";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(778, 429);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.kmLbl);
            this.Controls.Add(this.milesLbl);
            this.Controls.Add(this.kmBtn);
            this.Controls.Add(this.milesBtn);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.milesTxt);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button toMilesBtn;
        private System.Windows.Forms.Button toKiloBtn;
        private System.Windows.Forms.Label kiloLabel;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox kiloInput;
        private System.Windows.Forms.TextBox milesInput;
        private System.Windows.Forms.TextBox milesTxt;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.Button milesBtn;
        private System.Windows.Forms.Button kmBtn;
        private System.Windows.Forms.Label milesLbl;
        private System.Windows.Forms.Label kmLbl;
        private System.Windows.Forms.Label answerLbl;
    }
}

