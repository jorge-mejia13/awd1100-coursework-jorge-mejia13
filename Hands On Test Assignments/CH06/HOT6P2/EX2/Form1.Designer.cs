namespace EX2
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
            this.qtInput = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.dcInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.codeAcceptLbl = new System.Windows.Forms.Label();
            this.shirtCounterLbl = new System.Windows.Forms.Label();
            this.subtotalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantity";
            // 
            // qtInput
            // 
            this.qtInput.Location = new System.Drawing.Point(318, 65);
            this.qtInput.Name = "qtInput";
            this.qtInput.Size = new System.Drawing.Size(157, 26);
            this.qtInput.TabIndex = 1;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(508, 90);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(106, 36);
            this.orderBtn.TabIndex = 2;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // dcInput
            // 
            this.dcInput.Location = new System.Drawing.Point(318, 115);
            this.dcInput.Name = "dcInput";
            this.dcInput.Size = new System.Drawing.Size(157, 26);
            this.dcInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Discount Code";
            // 
            // codeAcceptLbl
            // 
            this.codeAcceptLbl.AutoSize = true;
            this.codeAcceptLbl.Location = new System.Drawing.Point(318, 183);
            this.codeAcceptLbl.Name = "codeAcceptLbl";
            this.codeAcceptLbl.Size = new System.Drawing.Size(0, 20);
            this.codeAcceptLbl.TabIndex = 5;
            // 
            // shirtCounterLbl
            // 
            this.shirtCounterLbl.AutoSize = true;
            this.shirtCounterLbl.Location = new System.Drawing.Point(178, 227);
            this.shirtCounterLbl.Name = "shirtCounterLbl";
            this.shirtCounterLbl.Size = new System.Drawing.Size(189, 20);
            this.shirtCounterLbl.TabIndex = 6;
            this.shirtCounterLbl.Text = "0 T-Shirts @ $13.75 each";
            // 
            // subtotalLbl
            // 
            this.subtotalLbl.AutoSize = true;
            this.subtotalLbl.Location = new System.Drawing.Point(178, 279);
            this.subtotalLbl.Name = "subtotalLbl";
            this.subtotalLbl.Size = new System.Drawing.Size(95, 20);
            this.subtotalLbl.TabIndex = 7;
            this.subtotalLbl.Text = "Subtotal: $0";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(178, 299);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(60, 20);
            this.taxLbl.TabIndex = 8;
            this.taxLbl.Text = "Tax: $0";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(178, 319);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(70, 20);
            this.totalLbl.TabIndex = 9;
            this.totalLbl.Text = "Total: $0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.taxLbl);
            this.Controls.Add(this.subtotalLbl);
            this.Controls.Add(this.shirtCounterLbl);
            this.Controls.Add(this.codeAcceptLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dcInput);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.qtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qtInput;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.TextBox dcInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codeAcceptLbl;
        private System.Windows.Forms.Label shirtCounterLbl;
        private System.Windows.Forms.Label subtotalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}

