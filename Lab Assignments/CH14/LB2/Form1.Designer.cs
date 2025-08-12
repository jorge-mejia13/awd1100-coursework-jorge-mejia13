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
            this.widthInput = new System.Windows.Forms.TextBox();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unframedBtn = new System.Windows.Forms.RadioButton();
            this.matteBtn = new System.Windows.Forms.RadioButton();
            this.framedBtn = new System.Windows.Forms.RadioButton();
            this.colorGroup = new System.Windows.Forms.GroupBox();
            this.materialGroup = new System.Windows.Forms.GroupBox();
            this.styleGroup = new System.Windows.Forms.GroupBox();
            this.blackBtn = new System.Windows.Forms.RadioButton();
            this.redBtn = new System.Windows.Forms.RadioButton();
            this.greenBtn = new System.Windows.Forms.RadioButton();
            this.blueBtn = new System.Windows.Forms.RadioButton();
            this.whiteBtn = new System.Windows.Forms.RadioButton();
            this.pineBtn = new System.Windows.Forms.RadioButton();
            this.oakBtn = new System.Windows.Forms.RadioButton();
            this.steelBtn = new System.Windows.Forms.RadioButton();
            this.silverBtn = new System.Windows.Forms.RadioButton();
            this.goldBtn = new System.Windows.Forms.RadioButton();
            this.simpleBtn = new System.Windows.Forms.RadioButton();
            this.modernBtn = new System.Windows.Forms.RadioButton();
            this.antiqueBtn = new System.Windows.Forms.RadioButton();
            this.vintageBtn = new System.Windows.Forms.RadioButton();
            this.eclecticBtn = new System.Windows.Forms.RadioButton();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.totalCostLbl = new System.Windows.Forms.Label();
            this.resultLbl = new System.Windows.Forms.Label();
            this.dummyLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.colorGroup.SuspendLayout();
            this.materialGroup.SuspendLayout();
            this.styleGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width (in)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height (in)";
            // 
            // widthInput
            // 
            this.widthInput.Location = new System.Drawing.Point(328, 51);
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(169, 20);
            this.widthInput.TabIndex = 2;
            // 
            // heightInput
            // 
            this.heightInput.Location = new System.Drawing.Point(328, 81);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(169, 20);
            this.heightInput.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.framedBtn);
            this.groupBox1.Controls.Add(this.matteBtn);
            this.groupBox1.Controls.Add(this.unframedBtn);
            this.groupBox1.Location = new System.Drawing.Point(270, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frame";
            // 
            // unframedBtn
            // 
            this.unframedBtn.AutoSize = true;
            this.unframedBtn.Location = new System.Drawing.Point(7, 20);
            this.unframedBtn.Name = "unframedBtn";
            this.unframedBtn.Size = new System.Drawing.Size(71, 17);
            this.unframedBtn.TabIndex = 0;
            this.unframedBtn.TabStop = true;
            this.unframedBtn.Text = "Unframed";
            this.unframedBtn.UseVisualStyleBackColor = true;
            // 
            // matteBtn
            // 
            this.matteBtn.AutoSize = true;
            this.matteBtn.Location = new System.Drawing.Point(7, 44);
            this.matteBtn.Name = "matteBtn";
            this.matteBtn.Size = new System.Drawing.Size(52, 17);
            this.matteBtn.TabIndex = 1;
            this.matteBtn.TabStop = true;
            this.matteBtn.Text = "Matte";
            this.matteBtn.UseVisualStyleBackColor = true;
            // 
            // framedBtn
            // 
            this.framedBtn.AutoSize = true;
            this.framedBtn.Location = new System.Drawing.Point(7, 68);
            this.framedBtn.Name = "framedBtn";
            this.framedBtn.Size = new System.Drawing.Size(60, 17);
            this.framedBtn.TabIndex = 2;
            this.framedBtn.TabStop = true;
            this.framedBtn.Text = "Framed";
            this.framedBtn.UseVisualStyleBackColor = true;
            // 
            // colorGroup
            // 
            this.colorGroup.Controls.Add(this.whiteBtn);
            this.colorGroup.Controls.Add(this.blueBtn);
            this.colorGroup.Controls.Add(this.greenBtn);
            this.colorGroup.Controls.Add(this.redBtn);
            this.colorGroup.Controls.Add(this.blackBtn);
            this.colorGroup.Location = new System.Drawing.Point(25, 252);
            this.colorGroup.Name = "colorGroup";
            this.colorGroup.Size = new System.Drawing.Size(200, 173);
            this.colorGroup.TabIndex = 5;
            this.colorGroup.TabStop = false;
            this.colorGroup.Text = "Color";
            // 
            // materialGroup
            // 
            this.materialGroup.Controls.Add(this.goldBtn);
            this.materialGroup.Controls.Add(this.silverBtn);
            this.materialGroup.Controls.Add(this.steelBtn);
            this.materialGroup.Controls.Add(this.oakBtn);
            this.materialGroup.Controls.Add(this.pineBtn);
            this.materialGroup.Location = new System.Drawing.Point(270, 252);
            this.materialGroup.Name = "materialGroup";
            this.materialGroup.Size = new System.Drawing.Size(227, 173);
            this.materialGroup.TabIndex = 6;
            this.materialGroup.TabStop = false;
            this.materialGroup.Text = "Material";
            // 
            // styleGroup
            // 
            this.styleGroup.Controls.Add(this.eclecticBtn);
            this.styleGroup.Controls.Add(this.vintageBtn);
            this.styleGroup.Controls.Add(this.antiqueBtn);
            this.styleGroup.Controls.Add(this.modernBtn);
            this.styleGroup.Controls.Add(this.simpleBtn);
            this.styleGroup.Location = new System.Drawing.Point(541, 252);
            this.styleGroup.Name = "styleGroup";
            this.styleGroup.Size = new System.Drawing.Size(227, 173);
            this.styleGroup.TabIndex = 7;
            this.styleGroup.TabStop = false;
            this.styleGroup.Text = "Style";
            // 
            // blackBtn
            // 
            this.blackBtn.AutoSize = true;
            this.blackBtn.Location = new System.Drawing.Point(7, 20);
            this.blackBtn.Name = "blackBtn";
            this.blackBtn.Size = new System.Drawing.Size(52, 17);
            this.blackBtn.TabIndex = 0;
            this.blackBtn.TabStop = true;
            this.blackBtn.Text = "Black";
            this.blackBtn.UseVisualStyleBackColor = true;
            // 
            // redBtn
            // 
            this.redBtn.AutoSize = true;
            this.redBtn.Location = new System.Drawing.Point(7, 44);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(45, 17);
            this.redBtn.TabIndex = 1;
            this.redBtn.TabStop = true;
            this.redBtn.Text = "Red";
            this.redBtn.UseVisualStyleBackColor = true;
            // 
            // greenBtn
            // 
            this.greenBtn.AutoSize = true;
            this.greenBtn.Location = new System.Drawing.Point(7, 68);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(54, 17);
            this.greenBtn.TabIndex = 2;
            this.greenBtn.TabStop = true;
            this.greenBtn.Text = "Green";
            this.greenBtn.UseVisualStyleBackColor = true;
            // 
            // blueBtn
            // 
            this.blueBtn.AutoSize = true;
            this.blueBtn.Location = new System.Drawing.Point(7, 92);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(46, 17);
            this.blueBtn.TabIndex = 3;
            this.blueBtn.TabStop = true;
            this.blueBtn.Text = "Blue";
            this.blueBtn.UseVisualStyleBackColor = true;
            // 
            // whiteBtn
            // 
            this.whiteBtn.AutoSize = true;
            this.whiteBtn.Location = new System.Drawing.Point(7, 116);
            this.whiteBtn.Name = "whiteBtn";
            this.whiteBtn.Size = new System.Drawing.Size(53, 17);
            this.whiteBtn.TabIndex = 4;
            this.whiteBtn.TabStop = true;
            this.whiteBtn.Text = "White";
            this.whiteBtn.UseVisualStyleBackColor = true;
            // 
            // pineBtn
            // 
            this.pineBtn.AutoSize = true;
            this.pineBtn.Location = new System.Drawing.Point(7, 20);
            this.pineBtn.Name = "pineBtn";
            this.pineBtn.Size = new System.Drawing.Size(46, 17);
            this.pineBtn.TabIndex = 0;
            this.pineBtn.TabStop = true;
            this.pineBtn.Text = "Pine";
            this.pineBtn.UseVisualStyleBackColor = true;
            // 
            // oakBtn
            // 
            this.oakBtn.AutoSize = true;
            this.oakBtn.Location = new System.Drawing.Point(7, 44);
            this.oakBtn.Name = "oakBtn";
            this.oakBtn.Size = new System.Drawing.Size(45, 17);
            this.oakBtn.TabIndex = 1;
            this.oakBtn.TabStop = true;
            this.oakBtn.Text = "Oak";
            this.oakBtn.UseVisualStyleBackColor = true;
            // 
            // steelBtn
            // 
            this.steelBtn.AutoSize = true;
            this.steelBtn.Location = new System.Drawing.Point(7, 68);
            this.steelBtn.Name = "steelBtn";
            this.steelBtn.Size = new System.Drawing.Size(49, 17);
            this.steelBtn.TabIndex = 2;
            this.steelBtn.TabStop = true;
            this.steelBtn.Text = "Steel";
            this.steelBtn.UseVisualStyleBackColor = true;
            // 
            // silverBtn
            // 
            this.silverBtn.AutoSize = true;
            this.silverBtn.Location = new System.Drawing.Point(7, 92);
            this.silverBtn.Name = "silverBtn";
            this.silverBtn.Size = new System.Drawing.Size(51, 17);
            this.silverBtn.TabIndex = 3;
            this.silverBtn.TabStop = true;
            this.silverBtn.Text = "Silver";
            this.silverBtn.UseVisualStyleBackColor = true;
            // 
            // goldBtn
            // 
            this.goldBtn.AutoSize = true;
            this.goldBtn.Location = new System.Drawing.Point(7, 116);
            this.goldBtn.Name = "goldBtn";
            this.goldBtn.Size = new System.Drawing.Size(47, 17);
            this.goldBtn.TabIndex = 4;
            this.goldBtn.TabStop = true;
            this.goldBtn.Text = "Gold";
            this.goldBtn.UseVisualStyleBackColor = true;
            // 
            // simpleBtn
            // 
            this.simpleBtn.AutoSize = true;
            this.simpleBtn.Location = new System.Drawing.Point(7, 20);
            this.simpleBtn.Name = "simpleBtn";
            this.simpleBtn.Size = new System.Drawing.Size(56, 17);
            this.simpleBtn.TabIndex = 0;
            this.simpleBtn.TabStop = true;
            this.simpleBtn.Text = "Simple";
            this.simpleBtn.UseVisualStyleBackColor = true;
            // 
            // modernBtn
            // 
            this.modernBtn.AutoSize = true;
            this.modernBtn.Location = new System.Drawing.Point(7, 44);
            this.modernBtn.Name = "modernBtn";
            this.modernBtn.Size = new System.Drawing.Size(61, 17);
            this.modernBtn.TabIndex = 1;
            this.modernBtn.TabStop = true;
            this.modernBtn.Text = "Modern";
            this.modernBtn.UseVisualStyleBackColor = true;
            // 
            // antiqueBtn
            // 
            this.antiqueBtn.AutoSize = true;
            this.antiqueBtn.Location = new System.Drawing.Point(7, 68);
            this.antiqueBtn.Name = "antiqueBtn";
            this.antiqueBtn.Size = new System.Drawing.Size(61, 17);
            this.antiqueBtn.TabIndex = 2;
            this.antiqueBtn.TabStop = true;
            this.antiqueBtn.Text = "Antique";
            this.antiqueBtn.UseVisualStyleBackColor = true;
            // 
            // vintageBtn
            // 
            this.vintageBtn.AutoSize = true;
            this.vintageBtn.Location = new System.Drawing.Point(7, 92);
            this.vintageBtn.Name = "vintageBtn";
            this.vintageBtn.Size = new System.Drawing.Size(61, 17);
            this.vintageBtn.TabIndex = 3;
            this.vintageBtn.TabStop = true;
            this.vintageBtn.Text = "Vintage";
            this.vintageBtn.UseVisualStyleBackColor = true;
            // 
            // eclecticBtn
            // 
            this.eclecticBtn.AutoSize = true;
            this.eclecticBtn.Location = new System.Drawing.Point(7, 116);
            this.eclecticBtn.Name = "eclecticBtn";
            this.eclecticBtn.Size = new System.Drawing.Size(63, 17);
            this.eclecticBtn.TabIndex = 4;
            this.eclecticBtn.TabStop = true;
            this.eclecticBtn.Text = "Eclectic";
            this.eclecticBtn.UseVisualStyleBackColor = true;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(25, 465);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(92, 40);
            this.calculateBtn.TabIndex = 8;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // totalCostLbl
            // 
            this.totalCostLbl.AutoSize = true;
            this.totalCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.totalCostLbl.Location = new System.Drawing.Point(267, 488);
            this.totalCostLbl.Name = "totalCostLbl";
            this.totalCostLbl.Size = new System.Drawing.Size(80, 17);
            this.totalCostLbl.TabIndex = 9;
            this.totalCostLbl.Text = "Cost: $0.00";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(25, 522);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 10;
            // 
            // dummyLbl
            // 
            this.dummyLbl.AutoSize = true;
            this.dummyLbl.Location = new System.Drawing.Point(548, 491);
            this.dummyLbl.Name = "dummyLbl";
            this.dummyLbl.Size = new System.Drawing.Size(35, 13);
            this.dummyLbl.TabIndex = 11;
            this.dummyLbl.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.dummyLbl);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.totalCostLbl);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.styleGroup);
            this.Controls.Add(this.materialGroup);
            this.Controls.Add(this.colorGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.colorGroup.ResumeLayout(false);
            this.colorGroup.PerformLayout();
            this.materialGroup.ResumeLayout(false);
            this.materialGroup.PerformLayout();
            this.styleGroup.ResumeLayout(false);
            this.styleGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthInput;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton framedBtn;
        private System.Windows.Forms.RadioButton matteBtn;
        private System.Windows.Forms.RadioButton unframedBtn;
        private System.Windows.Forms.GroupBox colorGroup;
        private System.Windows.Forms.GroupBox materialGroup;
        private System.Windows.Forms.GroupBox styleGroup;
        private System.Windows.Forms.RadioButton whiteBtn;
        private System.Windows.Forms.RadioButton blueBtn;
        private System.Windows.Forms.RadioButton greenBtn;
        private System.Windows.Forms.RadioButton redBtn;
        private System.Windows.Forms.RadioButton blackBtn;
        private System.Windows.Forms.RadioButton goldBtn;
        private System.Windows.Forms.RadioButton silverBtn;
        private System.Windows.Forms.RadioButton steelBtn;
        private System.Windows.Forms.RadioButton oakBtn;
        private System.Windows.Forms.RadioButton pineBtn;
        private System.Windows.Forms.RadioButton eclecticBtn;
        private System.Windows.Forms.RadioButton vintageBtn;
        private System.Windows.Forms.RadioButton antiqueBtn;
        private System.Windows.Forms.RadioButton modernBtn;
        private System.Windows.Forms.RadioButton simpleBtn;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Label totalCostLbl;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Label dummyLbl;
    }
}

