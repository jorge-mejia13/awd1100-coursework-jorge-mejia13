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
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSundae = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSoda = new System.Windows.Forms.CheckBox();
            this.addItemToOrderBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkSyrup = new System.Windows.Forms.CheckBox();
            this.chkLime = new System.Windows.Forms.CheckBox();
            this.chkPeach = new System.Windows.Forms.CheckBox();
            this.chkMango = new System.Windows.Forms.CheckBox();
            this.toppingsErrorLbl = new System.Windows.Forms.Label();
            this.sodaFlavorErrorLbl = new System.Windows.Forms.Label();
            this.nameOrFoodErrorLbl = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.sundaeToppingsGrp = new System.Windows.Forms.GroupBox();
            this.sodaFlavorsGrp = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sundaeToppingsGrp.SuspendLayout();
            this.sodaFlavorsGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you want to name your order?";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(74, 61);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(278, 26);
            this.nameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Do you want a sundae?";
            // 
            // chkSundae
            // 
            this.chkSundae.AutoSize = true;
            this.chkSundae.Location = new System.Drawing.Point(78, 177);
            this.chkSundae.Name = "chkSundae";
            this.chkSundae.Size = new System.Drawing.Size(55, 24);
            this.chkSundae.TabIndex = 3;
            this.chkSundae.Text = "No";
            this.chkSundae.UseVisualStyleBackColor = true;
            this.chkSundae.CheckedChanged += new System.EventHandler(this.chkSundae_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Do you want a soda?";
            // 
            // chkSoda
            // 
            this.chkSoda.AutoSize = true;
            this.chkSoda.Location = new System.Drawing.Point(292, 177);
            this.chkSoda.Name = "chkSoda";
            this.chkSoda.Size = new System.Drawing.Size(55, 24);
            this.chkSoda.TabIndex = 5;
            this.chkSoda.Text = "No";
            this.chkSoda.UseVisualStyleBackColor = true;
            this.chkSoda.CheckedChanged += new System.EventHandler(this.chkSoda_CheckedChanged);
            // 
            // addItemToOrderBtn
            // 
            this.addItemToOrderBtn.Location = new System.Drawing.Point(74, 398);
            this.addItemToOrderBtn.Name = "addItemToOrderBtn";
            this.addItemToOrderBtn.Size = new System.Drawing.Size(161, 40);
            this.addItemToOrderBtn.TabIndex = 10;
            this.addItemToOrderBtn.Text = "Add item to order";
            this.addItemToOrderBtn.UseVisualStyleBackColor = true;
            this.addItemToOrderBtn.Click += new System.EventHandler(this.addItemToOrderBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Order";
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.AutoSize = true;
            this.chkSprinkles.Location = new System.Drawing.Point(6, 25);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(100, 24);
            this.chkSprinkles.TabIndex = 14;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(6, 55);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(68, 24);
            this.chkNuts.TabIndex = 15;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkSyrup
            // 
            this.chkSyrup.AutoSize = true;
            this.chkSyrup.Location = new System.Drawing.Point(6, 85);
            this.chkSyrup.Name = "chkSyrup";
            this.chkSyrup.Size = new System.Drawing.Size(152, 24);
            this.chkSyrup.TabIndex = 16;
            this.chkSyrup.Text = "Chocolate Syrup";
            this.chkSyrup.UseVisualStyleBackColor = true;
            // 
            // chkLime
            // 
            this.chkLime.AutoSize = true;
            this.chkLime.Location = new System.Drawing.Point(6, 25);
            this.chkLime.Name = "chkLime";
            this.chkLime.Size = new System.Drawing.Size(116, 24);
            this.chkLime.TabIndex = 17;
            this.chkLime.Text = "Lime Flavor";
            this.chkLime.UseVisualStyleBackColor = true;
            // 
            // chkPeach
            // 
            this.chkPeach.AutoSize = true;
            this.chkPeach.Location = new System.Drawing.Point(6, 55);
            this.chkPeach.Name = "chkPeach";
            this.chkPeach.Size = new System.Drawing.Size(127, 24);
            this.chkPeach.TabIndex = 18;
            this.chkPeach.Text = "Peach Flavor";
            this.chkPeach.UseVisualStyleBackColor = true;
            // 
            // chkMango
            // 
            this.chkMango.AutoSize = true;
            this.chkMango.Location = new System.Drawing.Point(6, 85);
            this.chkMango.Name = "chkMango";
            this.chkMango.Size = new System.Drawing.Size(131, 24);
            this.chkMango.TabIndex = 19;
            this.chkMango.Text = "Mango Flavor";
            this.chkMango.UseVisualStyleBackColor = true;
            // 
            // toppingsErrorLbl
            // 
            this.toppingsErrorLbl.AutoSize = true;
            this.toppingsErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.toppingsErrorLbl.Location = new System.Drawing.Point(80, 369);
            this.toppingsErrorLbl.Name = "toppingsErrorLbl";
            this.toppingsErrorLbl.Size = new System.Drawing.Size(175, 20);
            this.toppingsErrorLbl.TabIndex = 20;
            this.toppingsErrorLbl.Text = "Only 2 toppings allowed";
            this.toppingsErrorLbl.Visible = false;
            // 
            // sodaFlavorErrorLbl
            // 
            this.sodaFlavorErrorLbl.AutoSize = true;
            this.sodaFlavorErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.sodaFlavorErrorLbl.Location = new System.Drawing.Point(289, 369);
            this.sodaFlavorErrorLbl.Name = "sodaFlavorErrorLbl";
            this.sodaFlavorErrorLbl.Size = new System.Drawing.Size(149, 20);
            this.sodaFlavorErrorLbl.TabIndex = 21;
            this.sodaFlavorErrorLbl.Text = "Only 1 mixin allowed";
            this.sodaFlavorErrorLbl.Visible = false;
            // 
            // nameOrFoodErrorLbl
            // 
            this.nameOrFoodErrorLbl.AutoSize = true;
            this.nameOrFoodErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.nameOrFoodErrorLbl.Location = new System.Drawing.Point(74, 94);
            this.nameOrFoodErrorLbl.Name = "nameOrFoodErrorLbl";
            this.nameOrFoodErrorLbl.Size = new System.Drawing.Size(245, 20);
            this.nameOrFoodErrorLbl.TabIndex = 22;
            this.nameOrFoodErrorLbl.Text = "Name required / No food selected";
            this.nameOrFoodErrorLbl.Visible = false;
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(538, 61);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(378, 305);
            this.outputBox.TabIndex = 23;
            this.outputBox.Text = "";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(815, 369);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(27, 20);
            this.totalLbl.TabIndex = 24;
            this.totalLbl.Text = "$0";
            // 
            // sundaeToppingsGrp
            // 
            this.sundaeToppingsGrp.Controls.Add(this.chkSprinkles);
            this.sundaeToppingsGrp.Controls.Add(this.chkNuts);
            this.sundaeToppingsGrp.Controls.Add(this.chkSyrup);
            this.sundaeToppingsGrp.Location = new System.Drawing.Point(78, 227);
            this.sundaeToppingsGrp.Name = "sundaeToppingsGrp";
            this.sundaeToppingsGrp.Size = new System.Drawing.Size(172, 117);
            this.sundaeToppingsGrp.TabIndex = 25;
            this.sundaeToppingsGrp.TabStop = false;
            this.sundaeToppingsGrp.Text = "Sundae Toppings";
            this.sundaeToppingsGrp.Visible = false;
            // 
            // sodaFlavorsGrp
            // 
            this.sodaFlavorsGrp.Controls.Add(this.chkLime);
            this.sodaFlavorsGrp.Controls.Add(this.chkPeach);
            this.sodaFlavorsGrp.Controls.Add(this.chkMango);
            this.sodaFlavorsGrp.Location = new System.Drawing.Point(292, 227);
            this.sodaFlavorsGrp.Name = "sodaFlavorsGrp";
            this.sodaFlavorsGrp.Size = new System.Drawing.Size(154, 117);
            this.sodaFlavorsGrp.TabIndex = 26;
            this.sodaFlavorsGrp.TabStop = false;
            this.sodaFlavorsGrp.Text = "Soda Flavors";
            this.sodaFlavorsGrp.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(761, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 517);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sodaFlavorsGrp);
            this.Controls.Add(this.sundaeToppingsGrp);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.nameOrFoodErrorLbl);
            this.Controls.Add(this.sodaFlavorErrorLbl);
            this.Controls.Add(this.toppingsErrorLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addItemToOrderBtn);
            this.Controls.Add(this.chkSoda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkSundae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sundaeToppingsGrp.ResumeLayout(false);
            this.sundaeToppingsGrp.PerformLayout();
            this.sodaFlavorsGrp.ResumeLayout(false);
            this.sodaFlavorsGrp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSundae;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSoda;
        private System.Windows.Forms.Button addItemToOrderBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkSyrup;
        private System.Windows.Forms.CheckBox chkLime;
        private System.Windows.Forms.CheckBox chkPeach;
        private System.Windows.Forms.CheckBox chkMango;
        private System.Windows.Forms.Label toppingsErrorLbl;
        private System.Windows.Forms.Label sodaFlavorErrorLbl;
        private System.Windows.Forms.Label nameOrFoodErrorLbl;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.GroupBox sundaeToppingsGrp;
        private System.Windows.Forms.GroupBox sodaFlavorsGrp;
        private System.Windows.Forms.Label label4;
    }
}

