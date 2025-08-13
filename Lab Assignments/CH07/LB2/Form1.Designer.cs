namespace LB2
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
            this.itemNumberInput = new System.Windows.Forms.TextBox();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.estDeliveryDaysInput = new System.Windows.Forms.TextBox();
            this.validateBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Number [100, 999]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity [1, 12]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estimated Delivery Days [1, 30]";
            // 
            // itemNumberInput
            // 
            this.itemNumberInput.Location = new System.Drawing.Point(451, 72);
            this.itemNumberInput.Name = "itemNumberInput";
            this.itemNumberInput.Size = new System.Drawing.Size(100, 20);
            this.itemNumberInput.TabIndex = 3;
            // 
            // quantityInput
            // 
            this.quantityInput.Location = new System.Drawing.Point(451, 118);
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(100, 20);
            this.quantityInput.TabIndex = 4;
            // 
            // estDeliveryDaysInput
            // 
            this.estDeliveryDaysInput.Location = new System.Drawing.Point(451, 158);
            this.estDeliveryDaysInput.Name = "estDeliveryDaysInput";
            this.estDeliveryDaysInput.Size = new System.Drawing.Size(100, 20);
            this.estDeliveryDaysInput.TabIndex = 5;
            // 
            // validateBtn
            // 
            this.validateBtn.Location = new System.Drawing.Point(451, 212);
            this.validateBtn.Name = "validateBtn";
            this.validateBtn.Size = new System.Drawing.Size(100, 30);
            this.validateBtn.TabIndex = 6;
            this.validateBtn.Text = "Validate";
            this.validateBtn.UseVisualStyleBackColor = true;
            this.validateBtn.Click += new System.EventHandler(this.validateBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(338, 362);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.validateBtn);
            this.Controls.Add(this.estDeliveryDaysInput);
            this.Controls.Add(this.quantityInput);
            this.Controls.Add(this.itemNumberInput);
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
        private System.Windows.Forms.TextBox itemNumberInput;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.TextBox estDeliveryDaysInput;
        private System.Windows.Forms.Button validateBtn;
        private System.Windows.Forms.Label resultLbl;
    }
}

