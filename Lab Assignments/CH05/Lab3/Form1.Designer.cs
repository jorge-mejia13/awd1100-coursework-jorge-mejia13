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
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorsBtn = new System.Windows.Forms.Button();
            this.computerChoiceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerScoreLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.computerScoreLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.compChoiceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rockBtn
            // 
            this.rockBtn.Location = new System.Drawing.Point(196, 46);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(98, 33);
            this.rockBtn.TabIndex = 0;
            this.rockBtn.Text = "Rock";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Location = new System.Drawing.Point(348, 46);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(87, 33);
            this.paperBtn.TabIndex = 1;
            this.paperBtn.Text = "Paper";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorsBtn
            // 
            this.scissorsBtn.Location = new System.Drawing.Point(482, 46);
            this.scissorsBtn.Name = "scissorsBtn";
            this.scissorsBtn.Size = new System.Drawing.Size(98, 33);
            this.scissorsBtn.TabIndex = 2;
            this.scissorsBtn.Text = "Scissors";
            this.scissorsBtn.UseVisualStyleBackColor = true;
            this.scissorsBtn.Click += new System.EventHandler(this.scissorsBtn_Click);
            // 
            // computerChoiceLbl
            // 
            this.computerChoiceLbl.AutoSize = true;
            this.computerChoiceLbl.Location = new System.Drawing.Point(192, 121);
            this.computerChoiceLbl.Name = "computerChoiceLbl";
            this.computerChoiceLbl.Size = new System.Drawing.Size(130, 20);
            this.computerChoiceLbl.TabIndex = 3;
            this.computerChoiceLbl.Text = "Computer chose:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player score:";
            // 
            // playerScoreLbl
            // 
            this.playerScoreLbl.AutoSize = true;
            this.playerScoreLbl.Location = new System.Drawing.Point(298, 207);
            this.playerScoreLbl.Name = "playerScoreLbl";
            this.playerScoreLbl.Size = new System.Drawing.Size(18, 20);
            this.playerScoreLbl.TabIndex = 5;
            this.playerScoreLbl.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Computer score:";
            // 
            // computerScoreLbl
            // 
            this.computerScoreLbl.AutoSize = true;
            this.computerScoreLbl.Location = new System.Drawing.Point(587, 206);
            this.computerScoreLbl.Name = "computerScoreLbl";
            this.computerScoreLbl.Size = new System.Drawing.Size(18, 20);
            this.computerScoreLbl.TabIndex = 7;
            this.computerScoreLbl.Text = "0";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(196, 294);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 20);
            this.resultLbl.TabIndex = 8;
            // 
            // compChoiceLbl
            // 
            this.compChoiceLbl.AutoSize = true;
            this.compChoiceLbl.Location = new System.Drawing.Point(328, 121);
            this.compChoiceLbl.Name = "compChoiceLbl";
            this.compChoiceLbl.Size = new System.Drawing.Size(0, 20);
            this.compChoiceLbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.compChoiceLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.computerScoreLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerScoreLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.computerChoiceLbl);
            this.Controls.Add(this.scissorsBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.rockBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorsBtn;
        private System.Windows.Forms.Label computerChoiceLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerScoreLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label computerScoreLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label compChoiceLbl;
    }
}

