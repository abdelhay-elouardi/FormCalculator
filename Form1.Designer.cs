namespace FormCalculator
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
            this.UserInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.BtnEqaul = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnColumn = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDevide = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInput
            // 
            this.UserInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInput.Location = new System.Drawing.Point(2, 3);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(411, 22);
            this.UserInput.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnPlusMinus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnThree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnTwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnOne, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSeven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnColumn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnZero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEqaul, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(405, 366);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnSeven
            // 
            this.btnSeven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSeven.Location = new System.Drawing.Point(3, 3);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(95, 85);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7\r\n";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.BNumber);
            // 
            // btnEight
            // 
            this.btnEight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEight.Location = new System.Drawing.Point(104, 3);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(95, 85);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.BNumber);
            // 
            // btnNine
            // 
            this.btnNine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNine.Location = new System.Drawing.Point(205, 3);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(95, 85);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.BNumber);
            // 
            // BtnEqaul
            // 
            this.BtnEqaul.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEqaul.Location = new System.Drawing.Point(306, 3);
            this.BtnEqaul.Name = "BtnEqaul";
            this.BtnEqaul.Size = new System.Drawing.Size(96, 85);
            this.BtnEqaul.TabIndex = 3;
            this.BtnEqaul.Text = "X";
            this.BtnEqaul.UseVisualStyleBackColor = true;
            this.BtnEqaul.Click += new System.EventHandler(this.BSeperator);
            // 
            // btnFour
            // 
            this.btnFour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFour.Location = new System.Drawing.Point(3, 94);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(95, 85);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.BNumber);
            // 
            // btnFive
            // 
            this.btnFive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFive.Location = new System.Drawing.Point(104, 94);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(95, 85);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.BNumber);
            // 
            // btnSix
            // 
            this.btnSix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSix.Location = new System.Drawing.Point(205, 94);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(95, 85);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.BNumber);
            // 
            // btnMinus
            // 
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(306, 94);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(96, 85);
            this.btnMinus.TabIndex = 7;
            this.btnMinus.Text = "_";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.BSeperator);
            // 
            // btnOne
            // 
            this.btnOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOne.Location = new System.Drawing.Point(3, 185);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(95, 85);
            this.btnOne.TabIndex = 8;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.BNumber);
            // 
            // btnTwo
            // 
            this.btnTwo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTwo.Location = new System.Drawing.Point(104, 185);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(95, 85);
            this.btnTwo.TabIndex = 9;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.BNumber);
            // 
            // btnThree
            // 
            this.btnThree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThree.Location = new System.Drawing.Point(205, 185);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(95, 85);
            this.btnThree.TabIndex = 10;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.BNumber);
            // 
            // btnPlus
            // 
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(306, 185);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(96, 85);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.BSeperator);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlusMinus.Location = new System.Drawing.Point(3, 276);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(95, 87);
            this.btnPlusMinus.TabIndex = 12;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnZero.Location = new System.Drawing.Point(104, 276);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(95, 87);
            this.btnZero.TabIndex = 13;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.BNumber);
            // 
            // btnColumn
            // 
            this.btnColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnColumn.Location = new System.Drawing.Point(205, 276);
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.Size = new System.Drawing.Size(95, 87);
            this.btnColumn.TabIndex = 14;
            this.btnColumn.Text = ",";
            this.btnColumn.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(306, 276);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(96, 87);
            this.btnEqual.TabIndex = 15;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnDevide, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPercent, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCE, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnC, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(402, 68);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnCE
            // 
            this.btnCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCE.Location = new System.Drawing.Point(3, 3);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(94, 62);
            this.btnCE.TabIndex = 0;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnC.Location = new System.Drawing.Point(103, 3);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(94, 62);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPercent.Location = new System.Drawing.Point(203, 3);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(94, 62);
            this.btnPercent.TabIndex = 2;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            // 
            // btnDevide
            // 
            this.btnDevide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDevide.Location = new System.Drawing.Point(303, 3);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(96, 62);
            this.btnDevide.TabIndex = 3;
            this.btnDevide.Text = "/";
            this.btnDevide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 479);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button BtnEqaul;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnColumn;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnDevide;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
    }
}

