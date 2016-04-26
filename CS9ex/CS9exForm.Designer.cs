namespace CS9ex
{
    partial class frmCS9ex
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalGross = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblTotalNetPay = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblUnionDues = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUnionMember = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(282, 537);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 31);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(159, 537);
            this.btnClearForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(107, 31);
            this.btnClearForm.TabIndex = 12;
            this.btnClearForm.Text = "C&lear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(31, 537);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 31);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalGross);
            this.groupBox3.Controls.Add(this.lblTotalCount);
            this.groupBox3.Controls.Add(this.lblTotalNetPay);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(24, 397);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(370, 130);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totals";
            // 
            // lblTotalGross
            // 
            this.lblTotalGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGross.Location = new System.Drawing.Point(158, 24);
            this.lblTotalGross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalGross.Name = "lblTotalGross";
            this.lblTotalGross.Size = new System.Drawing.Size(188, 25);
            this.lblTotalGross.TabIndex = 4;
            this.lblTotalGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCount.Location = new System.Drawing.Point(158, 100);
            this.lblTotalCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(188, 25);
            this.lblTotalCount.TabIndex = 4;
            this.lblTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalNetPay
            // 
            this.lblTotalNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNetPay.Location = new System.Drawing.Point(158, 62);
            this.lblTotalNetPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNetPay.Name = "lblTotalNetPay";
            this.lblTotalNetPay.Size = new System.Drawing.Size(188, 25);
            this.lblTotalNetPay.TabIndex = 4;
            this.lblTotalNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total Gross Pay:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Employee Count:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Net Pay:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNetPay);
            this.groupBox2.Controls.Add(this.lblUnionDues);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblGross);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(24, 248);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(370, 140);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // lblNetPay
            // 
            this.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPay.Location = new System.Drawing.Point(158, 91);
            this.lblNetPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(188, 29);
            this.lblNetPay.TabIndex = 15;
            this.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnionDues
            // 
            this.lblUnionDues.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnionDues.Location = new System.Drawing.Point(158, 55);
            this.lblUnionDues.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnionDues.Name = "lblUnionDues";
            this.lblUnionDues.Size = new System.Drawing.Size(188, 29);
            this.lblUnionDues.TabIndex = 6;
            this.lblUnionDues.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 95);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Net Pay:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Union Dues:";
            // 
            // lblGross
            // 
            this.lblGross.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGross.Location = new System.Drawing.Point(158, 15);
            this.lblGross.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(188, 29);
            this.lblGross.TabIndex = 4;
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gross Pay:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUnionMember);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtHours);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(370, 211);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // chkUnionMember
            // 
            this.chkUnionMember.AutoSize = true;
            this.chkUnionMember.Location = new System.Drawing.Point(17, 160);
            this.chkUnionMember.Name = "chkUnionMember";
            this.chkUnionMember.Size = new System.Drawing.Size(132, 24);
            this.chkUnionMember.TabIndex = 3;
            this.chkUnionMember.Text = "Union Member";
            this.chkUnionMember.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(152, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 26);
            this.txtName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(155, 106);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(190, 26);
            this.txtRate.TabIndex = 2;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(155, 71);
            this.txtHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(190, 26);
            this.txtHours.TabIndex = 1;
            this.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pay Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hours Worked:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pay Calculator with Classes";
            // 
            // frmCS9ex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 582);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCS9ex";
            this.Text = "CS9ex by Your Name";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalGross;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblTotalNetPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblUnionDues;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUnionMember;
        private System.Windows.Forms.TextBox txtName;
    }
}

