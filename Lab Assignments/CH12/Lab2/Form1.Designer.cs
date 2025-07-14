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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameSearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.upcSearchInput = new System.Windows.Forms.TextBox();
            this.upcSearchBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.upcLbl = new System.Windows.Forms.Label();
            this.storePriceLbl = new System.Windows.Forms.Label();
            this.costPerCaseLbl = new System.Windows.Forms.Label();
            this.unitsPerCaseLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changeStorePriceContainer = new System.Windows.Forms.GroupBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.changeStorePriceBtn = new System.Windows.Forms.Button();
            this.accessKeyInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.changeStorePriceInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.verifyUpcInput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.accessKeyDeleteInput = new System.Windows.Forms.TextBox();
            this.deleteItemBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorDeleteLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.addNameInput = new System.Windows.Forms.TextBox();
            this.addUpcInput = new System.Windows.Forms.TextBox();
            this.addStorePriceInput = new System.Windows.Forms.TextBox();
            this.addAccessKeyInput = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.addCostPerCaseInput = new System.Windows.Forms.TextBox();
            this.addUnitsPerCaseInput = new System.Windows.Forms.TextBox();
            this.addDistributorInput = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.addErrorLbl = new System.Windows.Forms.Label();
            this.changeStorePriceContainer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(94, 43);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(141, 20);
            this.nameInput.TabIndex = 1;
            // 
            // nameSearchBtn
            // 
            this.nameSearchBtn.Location = new System.Drawing.Point(242, 39);
            this.nameSearchBtn.Name = "nameSearchBtn";
            this.nameSearchBtn.Size = new System.Drawing.Size(100, 23);
            this.nameSearchBtn.TabIndex = 2;
            this.nameSearchBtn.Text = "Search by name";
            this.nameSearchBtn.UseVisualStyleBackColor = true;
            this.nameSearchBtn.Click += new System.EventHandler(this.nameSearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search by UPC";
            // 
            // upcSearchInput
            // 
            this.upcSearchInput.Location = new System.Drawing.Point(418, 42);
            this.upcSearchInput.Name = "upcSearchInput";
            this.upcSearchInput.Size = new System.Drawing.Size(142, 20);
            this.upcSearchInput.TabIndex = 4;
            // 
            // upcSearchBtn
            // 
            this.upcSearchBtn.Location = new System.Drawing.Point(567, 38);
            this.upcSearchBtn.Name = "upcSearchBtn";
            this.upcSearchBtn.Size = new System.Drawing.Size(88, 23);
            this.upcSearchBtn.TabIndex = 5;
            this.upcSearchBtn.Text = "Search by upc";
            this.upcSearchBtn.UseVisualStyleBackColor = true;
            this.upcSearchBtn.Click += new System.EventHandler(this.upcSearchBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(94, 96);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(38, 13);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name:";
            // 
            // upcLbl
            // 
            this.upcLbl.AutoSize = true;
            this.upcLbl.Location = new System.Drawing.Point(94, 121);
            this.upcLbl.Name = "upcLbl";
            this.upcLbl.Size = new System.Drawing.Size(32, 13);
            this.upcLbl.TabIndex = 7;
            this.upcLbl.Text = "UPC:";
            // 
            // storePriceLbl
            // 
            this.storePriceLbl.AutoSize = true;
            this.storePriceLbl.Location = new System.Drawing.Point(94, 145);
            this.storePriceLbl.Name = "storePriceLbl";
            this.storePriceLbl.Size = new System.Drawing.Size(62, 13);
            this.storePriceLbl.TabIndex = 8;
            this.storePriceLbl.Text = "Store Price:";
            // 
            // costPerCaseLbl
            // 
            this.costPerCaseLbl.AutoSize = true;
            this.costPerCaseLbl.Location = new System.Drawing.Point(418, 95);
            this.costPerCaseLbl.Name = "costPerCaseLbl";
            this.costPerCaseLbl.Size = new System.Drawing.Size(77, 13);
            this.costPerCaseLbl.TabIndex = 9;
            this.costPerCaseLbl.Text = "Cost Per Case:";
            // 
            // unitsPerCaseLbl
            // 
            this.unitsPerCaseLbl.AutoSize = true;
            this.unitsPerCaseLbl.Location = new System.Drawing.Point(418, 120);
            this.unitsPerCaseLbl.Name = "unitsPerCaseLbl";
            this.unitsPerCaseLbl.Size = new System.Drawing.Size(80, 13);
            this.unitsPerCaseLbl.TabIndex = 10;
            this.unitsPerCaseLbl.Text = "Units Per Case:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 11;
            // 
            // changeStorePriceContainer
            // 
            this.changeStorePriceContainer.Controls.Add(this.errorLbl);
            this.changeStorePriceContainer.Controls.Add(this.changeStorePriceBtn);
            this.changeStorePriceContainer.Controls.Add(this.accessKeyInput);
            this.changeStorePriceContainer.Controls.Add(this.label5);
            this.changeStorePriceContainer.Controls.Add(this.changeStorePriceInput);
            this.changeStorePriceContainer.Controls.Add(this.label4);
            this.changeStorePriceContainer.Location = new System.Drawing.Point(94, 241);
            this.changeStorePriceContainer.Name = "changeStorePriceContainer";
            this.changeStorePriceContainer.Size = new System.Drawing.Size(200, 173);
            this.changeStorePriceContainer.TabIndex = 12;
            this.changeStorePriceContainer.TabStop = false;
            this.changeStorePriceContainer.Text = "Change Store Price";
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(53, 147);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(68, 13);
            this.errorLbl.TabIndex = 5;
            this.errorLbl.Text = "Error or good";
            // 
            // changeStorePriceBtn
            // 
            this.changeStorePriceBtn.Location = new System.Drawing.Point(56, 110);
            this.changeStorePriceBtn.Name = "changeStorePriceBtn";
            this.changeStorePriceBtn.Size = new System.Drawing.Size(75, 23);
            this.changeStorePriceBtn.TabIndex = 4;
            this.changeStorePriceBtn.Text = "Change Price";
            this.changeStorePriceBtn.UseVisualStyleBackColor = true;
            this.changeStorePriceBtn.Click += new System.EventHandler(this.changeStorePriceBtn_Click);
            // 
            // accessKeyInput
            // 
            this.accessKeyInput.Location = new System.Drawing.Point(80, 75);
            this.accessKeyInput.Name = "accessKeyInput";
            this.accessKeyInput.Size = new System.Drawing.Size(100, 20);
            this.accessKeyInput.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Access Key";
            // 
            // changeStorePriceInput
            // 
            this.changeStorePriceInput.Location = new System.Drawing.Point(80, 36);
            this.changeStorePriceInput.Name = "changeStorePriceInput";
            this.changeStorePriceInput.Size = new System.Drawing.Size(100, 20);
            this.changeStorePriceInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorDeleteLbl);
            this.groupBox1.Controls.Add(this.deleteItemBtn);
            this.groupBox1.Controls.Add(this.accessKeyDeleteInput);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.verifyUpcInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(421, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Verify UPC";
            // 
            // verifyUpcInput
            // 
            this.verifyUpcInput.Location = new System.Drawing.Point(93, 27);
            this.verifyUpcInput.Name = "verifyUpcInput";
            this.verifyUpcInput.Size = new System.Drawing.Size(100, 20);
            this.verifyUpcInput.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Access Key";
            // 
            // accessKeyDeleteInput
            // 
            this.accessKeyDeleteInput.Location = new System.Drawing.Point(93, 74);
            this.accessKeyDeleteInput.Name = "accessKeyDeleteInput";
            this.accessKeyDeleteInput.Size = new System.Drawing.Size(100, 20);
            this.accessKeyDeleteInput.TabIndex = 3;
            // 
            // deleteItemBtn
            // 
            this.deleteItemBtn.Location = new System.Drawing.Point(64, 110);
            this.deleteItemBtn.Name = "deleteItemBtn";
            this.deleteItemBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteItemBtn.TabIndex = 4;
            this.deleteItemBtn.Text = "Delete Item";
            this.deleteItemBtn.UseVisualStyleBackColor = true;
            this.deleteItemBtn.Click += new System.EventHandler(this.deleteItemBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addErrorLbl);
            this.groupBox2.Controls.Add(this.addItemBtn);
            this.groupBox2.Controls.Add(this.addDistributorInput);
            this.groupBox2.Controls.Add(this.addUnitsPerCaseInput);
            this.groupBox2.Controls.Add(this.addCostPerCaseInput);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.addAccessKeyInput);
            this.groupBox2.Controls.Add(this.addStorePriceInput);
            this.groupBox2.Controls.Add(this.addUpcInput);
            this.groupBox2.Controls.Add(this.addNameInput);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(94, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 173);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Item";
            // 
            // errorDeleteLbl
            // 
            this.errorDeleteLbl.AutoSize = true;
            this.errorDeleteLbl.Location = new System.Drawing.Point(64, 140);
            this.errorDeleteLbl.Name = "errorDeleteLbl";
            this.errorDeleteLbl.Size = new System.Drawing.Size(81, 13);
            this.errorDeleteLbl.TabIndex = 5;
            this.errorDeleteLbl.Text = "Is item deleted?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "UPC:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Store Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 118);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Access Key:";
            // 
            // addNameInput
            // 
            this.addNameInput.Location = new System.Drawing.Point(55, 24);
            this.addNameInput.Name = "addNameInput";
            this.addNameInput.Size = new System.Drawing.Size(100, 20);
            this.addNameInput.TabIndex = 4;
            // 
            // addUpcInput
            // 
            this.addUpcInput.Location = new System.Drawing.Point(52, 51);
            this.addUpcInput.Name = "addUpcInput";
            this.addUpcInput.Size = new System.Drawing.Size(100, 20);
            this.addUpcInput.TabIndex = 5;
            // 
            // addStorePriceInput
            // 
            this.addStorePriceInput.Location = new System.Drawing.Point(82, 79);
            this.addStorePriceInput.Name = "addStorePriceInput";
            this.addStorePriceInput.Size = new System.Drawing.Size(100, 20);
            this.addStorePriceInput.TabIndex = 6;
            // 
            // addAccessKeyInput
            // 
            this.addAccessKeyInput.Location = new System.Drawing.Point(89, 110);
            this.addAccessKeyInput.Name = "addAccessKeyInput";
            this.addAccessKeyInput.Size = new System.Drawing.Size(100, 20);
            this.addAccessKeyInput.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cost Per Case:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Units Per Case:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(304, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Distributor:";
            // 
            // addCostPerCaseInput
            // 
            this.addCostPerCaseInput.Location = new System.Drawing.Point(385, 23);
            this.addCostPerCaseInput.Name = "addCostPerCaseInput";
            this.addCostPerCaseInput.Size = new System.Drawing.Size(100, 20);
            this.addCostPerCaseInput.TabIndex = 11;
            // 
            // addUnitsPerCaseInput
            // 
            this.addUnitsPerCaseInput.Location = new System.Drawing.Point(387, 52);
            this.addUnitsPerCaseInput.Name = "addUnitsPerCaseInput";
            this.addUnitsPerCaseInput.Size = new System.Drawing.Size(100, 20);
            this.addUnitsPerCaseInput.TabIndex = 12;
            // 
            // addDistributorInput
            // 
            this.addDistributorInput.Location = new System.Drawing.Point(368, 79);
            this.addDistributorInput.Name = "addDistributorInput";
            this.addDistributorInput.Size = new System.Drawing.Size(100, 20);
            this.addDistributorInput.TabIndex = 13;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(307, 118);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(106, 23);
            this.addItemBtn.TabIndex = 14;
            this.addItemBtn.Text = "Add Item";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // addErrorLbl
            // 
            this.addErrorLbl.AutoSize = true;
            this.addErrorLbl.Location = new System.Drawing.Point(13, 154);
            this.addErrorLbl.Name = "addErrorLbl";
            this.addErrorLbl.Size = new System.Drawing.Size(32, 13);
            this.addErrorLbl.TabIndex = 15;
            this.addErrorLbl.Text = "Error:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 650);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.changeStorePriceContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.unitsPerCaseLbl);
            this.Controls.Add(this.costPerCaseLbl);
            this.Controls.Add(this.storePriceLbl);
            this.Controls.Add(this.upcLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.upcSearchBtn);
            this.Controls.Add(this.upcSearchInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameSearchBtn);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.changeStorePriceContainer.ResumeLayout(false);
            this.changeStorePriceContainer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button nameSearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upcSearchInput;
        private System.Windows.Forms.Button upcSearchBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label upcLbl;
        private System.Windows.Forms.Label storePriceLbl;
        private System.Windows.Forms.Label costPerCaseLbl;
        private System.Windows.Forms.Label unitsPerCaseLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox changeStorePriceContainer;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.Button changeStorePriceBtn;
        private System.Windows.Forms.TextBox accessKeyInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox changeStorePriceInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteItemBtn;
        private System.Windows.Forms.TextBox accessKeyDeleteInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox verifyUpcInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label errorDeleteLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.TextBox addDistributorInput;
        private System.Windows.Forms.TextBox addUnitsPerCaseInput;
        private System.Windows.Forms.TextBox addCostPerCaseInput;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox addAccessKeyInput;
        private System.Windows.Forms.TextBox addStorePriceInput;
        private System.Windows.Forms.TextBox addUpcInput;
        private System.Windows.Forms.TextBox addNameInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label addErrorLbl;
    }
}

