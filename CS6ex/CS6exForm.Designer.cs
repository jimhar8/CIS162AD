namespace CS7ex
{
    partial class CS6exForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CS6exForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radGround = new System.Windows.Forms.RadioButton();
            this.radThreeDay = new System.Windows.Forms.RadioButton();
            this.radNextDay = new System.Windows.Forms.RadioButton();
            this.chkSalesTax = new System.Windows.Forms.CheckBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblExtendedPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAverageOrder = new System.Windows.Forms.Label();
            this.lblNumberOfOrders = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditCalculate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditClearForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEditFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditColor = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Calculator using Methods";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.chkSalesTax);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(359, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radGround);
            this.groupBox4.Controls.Add(this.radThreeDay);
            this.groupBox4.Controls.Add(this.radNextDay);
            this.groupBox4.Location = new System.Drawing.Point(7, 111);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 63);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shipping";
            // 
            // radGround
            // 
            this.radGround.AutoSize = true;
            this.radGround.Checked = true;
            this.radGround.Location = new System.Drawing.Point(49, 28);
            this.radGround.Name = "radGround";
            this.radGround.Size = new System.Drawing.Size(81, 24);
            this.radGround.TabIndex = 0;
            this.radGround.TabStop = true;
            this.radGround.Text = "Ground";
            this.radGround.UseVisualStyleBackColor = true;
            // 
            // radThreeDay
            // 
            this.radThreeDay.AutoSize = true;
            this.radThreeDay.Location = new System.Drawing.Point(147, 28);
            this.radThreeDay.Name = "radThreeDay";
            this.radThreeDay.Size = new System.Drawing.Size(68, 24);
            this.radThreeDay.TabIndex = 1;
            this.radThreeDay.TabStop = true;
            this.radThreeDay.Text = "3 Day";
            this.radThreeDay.UseVisualStyleBackColor = true;
            // 
            // radNextDay
            // 
            this.radNextDay.AutoSize = true;
            this.radNextDay.Location = new System.Drawing.Point(237, 28);
            this.radNextDay.Name = "radNextDay";
            this.radNextDay.Size = new System.Drawing.Size(91, 24);
            this.radNextDay.TabIndex = 2;
            this.radNextDay.TabStop = true;
            this.radNextDay.Text = "Next Day";
            this.radNextDay.UseVisualStyleBackColor = true;
            // 
            // chkSalesTax
            // 
            this.chkSalesTax.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSalesTax.Location = new System.Drawing.Point(22, 80);
            this.chkSalesTax.Name = "chkSalesTax";
            this.chkSalesTax.Size = new System.Drawing.Size(146, 25);
            this.chkSalesTax.TabIndex = 4;
            this.chkSalesTax.Text = "Sales Tax Y/N:";
            this.chkSalesTax.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(151, 48);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(166, 26);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(151, 16);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(166, 26);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantity:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalDue);
            this.groupBox2.Controls.Add(this.lblShipping);
            this.groupBox2.Controls.Add(this.lblSalesTax);
            this.groupBox2.Controls.Add(this.lblExtendedPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(27, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 158);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDue.Location = new System.Drawing.Point(154, 125);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(165, 27);
            this.lblTotalDue.TabIndex = 4;
            this.lblTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShipping
            // 
            this.lblShipping.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShipping.Location = new System.Drawing.Point(154, 93);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(165, 27);
            this.lblShipping.TabIndex = 4;
            this.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(154, 53);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(165, 31);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblExtendedPrice
            // 
            this.lblExtendedPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtendedPrice.Location = new System.Drawing.Point(154, 22);
            this.lblExtendedPrice.Name = "lblExtendedPrice";
            this.lblExtendedPrice.Size = new System.Drawing.Size(165, 27);
            this.lblExtendedPrice.TabIndex = 4;
            this.lblExtendedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Total Due:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Shipping:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sales Tax:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Extended Price:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAverageOrder);
            this.groupBox3.Controls.Add(this.lblNumberOfOrders);
            this.groupBox3.Controls.Add(this.lblGrandTotal);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(27, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 120);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totals";
            // 
            // lblAverageOrder
            // 
            this.lblAverageOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageOrder.Location = new System.Drawing.Point(154, 90);
            this.lblAverageOrder.Name = "lblAverageOrder";
            this.lblAverageOrder.Size = new System.Drawing.Size(165, 27);
            this.lblAverageOrder.TabIndex = 4;
            this.lblAverageOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNumberOfOrders
            // 
            this.lblNumberOfOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumberOfOrders.Location = new System.Drawing.Point(154, 56);
            this.lblNumberOfOrders.Name = "lblNumberOfOrders";
            this.lblNumberOfOrders.Size = new System.Drawing.Size(165, 27);
            this.lblNumberOfOrders.TabIndex = 4;
            this.lblNumberOfOrders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotal.Location = new System.Drawing.Point(154, 18);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(165, 27);
            this.lblGrandTotal.TabIndex = 4;
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Average Order:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Number of Orders:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Grand Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(52, 519);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(91, 38);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(158, 519);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(97, 38);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "C&lear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(271, 519);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(353, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(422, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(40, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(109, 22);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCalculate,
            this.mnuEditClearForm,
            this.toolStripMenuItem1,
            this.mnuEditFont,
            this.mnuEditColor});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(41, 20);
            this.mnuEdit.Text = "&Edit";
            // 
            // mnuEditCalculate
            // 
            this.mnuEditCalculate.Name = "mnuEditCalculate";
            this.mnuEditCalculate.Size = new System.Drawing.Size(153, 22);
            this.mnuEditCalculate.Text = "&Calculate";
            this.mnuEditCalculate.Click += new System.EventHandler(this.mnuEditCalculate_Click);
            // 
            // mnuEditClearForm
            // 
            this.mnuEditClearForm.Name = "mnuEditClearForm";
            this.mnuEditClearForm.Size = new System.Drawing.Size(153, 22);
            this.mnuEditClearForm.Text = "C&lear Form";
            this.mnuEditClearForm.Click += new System.EventHandler(this.mnuEditClearForm_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuEditFont
            // 
            this.mnuEditFont.Name = "mnuEditFont";
            this.mnuEditFont.Size = new System.Drawing.Size(153, 22);
            this.mnuEditFont.Text = "F&ont";
            this.mnuEditFont.Click += new System.EventHandler(this.mnuEditFont_Click);
            // 
            // mnuEditColor
            // 
            this.mnuEditColor.Name = "mnuEditColor";
            this.mnuEditColor.Size = new System.Drawing.Size(153, 22);
            this.mnuEditColor.Text = "Colo&r";
            this.mnuEditColor.Click += new System.EventHandler(this.mnuEditColor_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMnuFont,
            this.contextMnuColor});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(120, 48);
            // 
            // contextMnuFont
            // 
            this.contextMnuFont.Name = "contextMnuFont";
            this.contextMnuFont.Size = new System.Drawing.Size(119, 22);
            this.contextMnuFont.Text = "F&ont";
            this.contextMnuFont.Click += new System.EventHandler(this.contextMnuFont_Click);
            // 
            // contextMnuColor
            // 
            this.contextMnuColor.Name = "contextMnuColor";
            this.contextMnuColor.Size = new System.Drawing.Size(119, 22);
            this.contextMnuColor.Text = "Colo&r";
            this.contextMnuColor.Click += new System.EventHandler(this.contextMnuColor_Click);
            // 
            // CS6exForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 565);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CS6exForm";
            this.Text = "CS6ex by Your Name";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblExtendedPrice;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.Label lblSalesTax;
        private System.Windows.Forms.Label lblAverageOrder;
        private System.Windows.Forms.Label lblNumberOfOrders;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.CheckBox chkSalesTax;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radGround;
        private System.Windows.Forms.RadioButton radThreeDay;
        private System.Windows.Forms.RadioButton radNextDay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditCalculate;
        private System.Windows.Forms.ToolStripMenuItem mnuEditClearForm;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuEditFont;
        private System.Windows.Forms.ToolStripMenuItem mnuEditColor;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMnuFont;
        private System.Windows.Forms.ToolStripMenuItem contextMnuColor;
    }
}

