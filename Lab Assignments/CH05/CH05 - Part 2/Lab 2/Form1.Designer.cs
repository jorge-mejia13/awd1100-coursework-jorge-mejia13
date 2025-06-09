namespace Lab_2
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
            this.scoreInput = new System.Windows.Forms.TextBox();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.numOfScoresLbl = new System.Windows.Forms.Label();
            this.sumOfScoresLbl = new System.Windows.Forms.Label();
            this.averageScoreLbl = new System.Windows.Forms.Label();
            this.lowerScoreLbl = new System.Windows.Forms.Label();
            this.highestScoreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // scoreInput
            // 
            this.scoreInput.Location = new System.Drawing.Point(127, 52);
            this.scoreInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreInput.Name = "scoreInput";
            this.scoreInput.Size = new System.Drawing.Size(153, 20);
            this.scoreInput.TabIndex = 1;
            // 
            // scoreBtn
            // 
            this.scoreBtn.Location = new System.Drawing.Point(127, 73);
            this.scoreBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(64, 25);
            this.scoreBtn.TabIndex = 2;
            this.scoreBtn.Text = "button1";
            this.scoreBtn.UseVisualStyleBackColor = true;
            this.scoreBtn.Click += new System.EventHandler(this.scoreBtn_Click);
            // 
            // numOfScoresLbl
            // 
            this.numOfScoresLbl.AutoSize = true;
            this.numOfScoresLbl.Location = new System.Drawing.Point(127, 139);
            this.numOfScoresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numOfScoresLbl.Name = "numOfScoresLbl";
            this.numOfScoresLbl.Size = new System.Drawing.Size(96, 13);
            this.numOfScoresLbl.TabIndex = 3;
            this.numOfScoresLbl.Text = "Number of scores: ";
            // 
            // sumOfScoresLbl
            // 
            this.sumOfScoresLbl.AutoSize = true;
            this.sumOfScoresLbl.Location = new System.Drawing.Point(127, 167);
            this.sumOfScoresLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sumOfScoresLbl.Name = "sumOfScoresLbl";
            this.sumOfScoresLbl.Size = new System.Drawing.Size(100, 13);
            this.sumOfScoresLbl.TabIndex = 4;
            this.sumOfScoresLbl.Text = "Sum of test scores: ";
            // 
            // averageScoreLbl
            // 
            this.averageScoreLbl.AutoSize = true;
            this.averageScoreLbl.Location = new System.Drawing.Point(127, 187);
            this.averageScoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.averageScoreLbl.Name = "averageScoreLbl";
            this.averageScoreLbl.Size = new System.Drawing.Size(102, 13);
            this.averageScoreLbl.TabIndex = 5;
            this.averageScoreLbl.Text = "Average test score: ";
            // 
            // lowerScoreLbl
            // 
            this.lowerScoreLbl.AutoSize = true;
            this.lowerScoreLbl.Location = new System.Drawing.Point(127, 206);
            this.lowerScoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lowerScoreLbl.Name = "lowerScoreLbl";
            this.lowerScoreLbl.Size = new System.Drawing.Size(96, 13);
            this.lowerScoreLbl.TabIndex = 6;
            this.lowerScoreLbl.Text = "Lowest test score: ";
            // 
            // highestScoreLbl
            // 
            this.highestScoreLbl.AutoSize = true;
            this.highestScoreLbl.Location = new System.Drawing.Point(127, 232);
            this.highestScoreLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.highestScoreLbl.Name = "highestScoreLbl";
            this.highestScoreLbl.Size = new System.Drawing.Size(98, 13);
            this.highestScoreLbl.TabIndex = 7;
            this.highestScoreLbl.Text = "Highest test score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 428);
            this.Controls.Add(this.highestScoreLbl);
            this.Controls.Add(this.lowerScoreLbl);
            this.Controls.Add(this.averageScoreLbl);
            this.Controls.Add(this.sumOfScoresLbl);
            this.Controls.Add(this.numOfScoresLbl);
            this.Controls.Add(this.scoreBtn);
            this.Controls.Add(this.scoreInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox scoreInput;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Label numOfScoresLbl;
        private System.Windows.Forms.Label sumOfScoresLbl;
        private System.Windows.Forms.Label averageScoreLbl;
        private System.Windows.Forms.Label lowerScoreLbl;
        private System.Windows.Forms.Label highestScoreLbl;
    }
}

