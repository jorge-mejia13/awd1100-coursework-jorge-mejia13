namespace Lab2
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
            this.groupNameInput = new System.Windows.Forms.TextBox();
            this.startingTimeInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.attendeesInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.conferenceLbl = new System.Windows.Forms.Label();
            this.attendeesLbl = new System.Windows.Forms.Label();
            this.Begin = new System.Windows.Forms.Label();
            this.beginInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endInput = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.displayLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Name";
            // 
            // groupNameInput
            // 
            this.groupNameInput.Location = new System.Drawing.Point(63, 57);
            this.groupNameInput.Name = "groupNameInput";
            this.groupNameInput.Size = new System.Drawing.Size(154, 26);
            this.groupNameInput.TabIndex = 1;
            // 
            // startingTimeInput
            // 
            this.startingTimeInput.Location = new System.Drawing.Point(223, 57);
            this.startingTimeInput.Name = "startingTimeInput";
            this.startingTimeInput.Size = new System.Drawing.Size(154, 26);
            this.startingTimeInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Starting Time";
            // 
            // attendeesInput
            // 
            this.attendeesInput.Location = new System.Drawing.Point(383, 57);
            this.attendeesInput.Name = "attendeesInput";
            this.attendeesInput.Size = new System.Drawing.Size(154, 26);
            this.attendeesInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Attendees";
            // 
            // roomInput
            // 
            this.roomInput.Location = new System.Drawing.Point(543, 57);
            this.roomInput.Name = "roomInput";
            this.roomInput.Size = new System.Drawing.Size(154, 26);
            this.roomInput.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(703, 52);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 37);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // conferenceLbl
            // 
            this.conferenceLbl.AutoSize = true;
            this.conferenceLbl.Location = new System.Drawing.Point(59, 115);
            this.conferenceLbl.Name = "conferenceLbl";
            this.conferenceLbl.Size = new System.Drawing.Size(139, 20);
            this.conferenceLbl.TabIndex = 9;
            this.conferenceLbl.Text = "Conferences: 0/20";
            // 
            // attendeesLbl
            // 
            this.attendeesLbl.AutoSize = true;
            this.attendeesLbl.Location = new System.Drawing.Point(59, 145);
            this.attendeesLbl.Name = "attendeesLbl";
            this.attendeesLbl.Size = new System.Drawing.Size(139, 20);
            this.attendeesLbl.TabIndex = 10;
            this.attendeesLbl.Text = "Total Attendees: 0";
            // 
            // Begin
            // 
            this.Begin.AutoSize = true;
            this.Begin.Location = new System.Drawing.Point(59, 216);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(50, 20);
            this.Begin.TabIndex = 11;
            this.Begin.Text = "Begin";
            // 
            // beginInput
            // 
            this.beginInput.Location = new System.Drawing.Point(63, 239);
            this.beginInput.Name = "beginInput";
            this.beginInput.Size = new System.Drawing.Size(100, 26);
            this.beginInput.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "End";
            // 
            // endInput
            // 
            this.endInput.Location = new System.Drawing.Point(169, 239);
            this.endInput.Name = "endInput";
            this.endInput.Size = new System.Drawing.Size(100, 26);
            this.endInput.TabIndex = 14;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(275, 234);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 37);
            this.searchBtn.TabIndex = 15;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // displayLbl
            // 
            this.displayLbl.AutoSize = true;
            this.displayLbl.Location = new System.Drawing.Point(63, 295);
            this.displayLbl.Name = "displayLbl";
            this.displayLbl.Size = new System.Drawing.Size(0, 20);
            this.displayLbl.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 459);
            this.Controls.Add(this.displayLbl);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.endInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.beginInput);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.attendeesLbl);
            this.Controls.Add(this.conferenceLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.roomInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.attendeesInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startingTimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupNameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox groupNameInput;
        private System.Windows.Forms.TextBox startingTimeInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox attendeesInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roomInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label conferenceLbl;
        private System.Windows.Forms.Label attendeesLbl;
        private System.Windows.Forms.Label Begin;
        private System.Windows.Forms.TextBox beginInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endInput;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label displayLbl;
    }
}

