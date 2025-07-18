namespace Lab6
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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.widthInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lengthInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.roomsCountLbl = new System.Windows.Forms.Label();
            this.totalBoxesNeededLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(109, 86);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(278, 85);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(100, 20);
            this.widthInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Length";
            // 
            // lengthInput
            // 
            this.lengthInput.Location = new System.Drawing.Point(450, 85);
            this.lengthInput.Name = "lengthInput";
            this.lengthInput.Size = new System.Drawing.Size(100, 20);
            this.lengthInput.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(595, 73);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 32);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // roomsCountLbl
            // 
            this.roomsCountLbl.AutoSize = true;
            this.roomsCountLbl.Location = new System.Drawing.Point(109, 161);
            this.roomsCountLbl.Name = "roomsCountLbl";
            this.roomsCountLbl.Size = new System.Drawing.Size(46, 13);
            this.roomsCountLbl.TabIndex = 7;
            this.roomsCountLbl.Text = "Rooms: ";
            // 
            // totalBoxesNeededLbl
            // 
            this.totalBoxesNeededLbl.AutoSize = true;
            this.totalBoxesNeededLbl.Location = new System.Drawing.Point(109, 187);
            this.totalBoxesNeededLbl.Name = "totalBoxesNeededLbl";
            this.totalBoxesNeededLbl.Size = new System.Drawing.Size(107, 13);
            this.totalBoxesNeededLbl.TabIndex = 8;
            this.totalBoxesNeededLbl.Text = "Total Boxes Needed:";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Location = new System.Drawing.Point(109, 246);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(0, 13);
            this.roomLbl.TabIndex = 9;
            // 
            // roomsList
            // 
            this.roomsList.BackColor = System.Drawing.SystemColors.Window;
            this.roomsList.FormattingEnabled = true;
            this.roomsList.Location = new System.Drawing.Point(112, 235);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(198, 95);
            this.roomsList.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomsList);
            this.Controls.Add(this.roomLbl);
            this.Controls.Add(this.totalBoxesNeededLbl);
            this.Controls.Add(this.roomsCountLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.lengthInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lengthInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label roomsCountLbl;
        private System.Windows.Forms.Label totalBoxesNeededLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.ListBox roomsList;
    }
}

