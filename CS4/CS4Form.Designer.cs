namespace CS4
{
    partial class CS4Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNetPayValue = new System.Windows.Forms.Label();
            this.lblUnionDuesValue = new System.Windows.Forms.Label();
            this.lblFedTaxValue = new System.Windows.Forms.Label();
            this.lblStateTaxValue = new System.Windows.Forms.Label();
            this.lblFicaTaxValue = new System.Windows.Forms.Label();
            this.lblGrossPayValue = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblUnionDues = new System.Windows.Forms.Label();
            this.lblFedTax = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblFica = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAvgNetPayValue = new System.Windows.Forms.Label();
            this.lblAvgPay = new System.Windows.Forms.Label();
            this.lblEmployeeCountValue = new System.Windows.Forms.Label();
            this.lblTotalNetPayValue = new System.Windows.Forms.Label();
            this.lblEmployeeCount = new System.Windows.Forms.Label();
            this.lblTotNetPay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPayRate);
            this.groupBox1.Controls.Add(this.txtHoursWorked);
            this.groupBox1.Controls.Add(this.lblPayRate);
            this.groupBox1.Controls.Add(this.lblHoursWorked);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtPayRate
            // 
            this.txtPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayRate.Location = new System.Drawing.Point(147, 66);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(175, 22);
            this.txtPayRate.TabIndex = 1;
            this.txtPayRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(147, 28);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(175, 22);
            this.txtHoursWorked.TabIndex = 0;
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPayRate
            // 
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(6, 72);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(67, 16);
            this.lblPayRate.TabIndex = 2;
            this.lblPayRate.Text = "Pay Rate:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(6, 34);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(98, 16);
            this.lblHoursWorked.TabIndex = 2;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNetPayValue);
            this.groupBox2.Controls.Add(this.lblUnionDuesValue);
            this.groupBox2.Controls.Add(this.lblFedTaxValue);
            this.groupBox2.Controls.Add(this.lblStateTaxValue);
            this.groupBox2.Controls.Add(this.lblFicaTaxValue);
            this.groupBox2.Controls.Add(this.lblGrossPayValue);
            this.groupBox2.Controls.Add(this.lblNetPay);
            this.groupBox2.Controls.Add(this.lblUnionDues);
            this.groupBox2.Controls.Add(this.lblFedTax);
            this.groupBox2.Controls.Add(this.lblStateTax);
            this.groupBox2.Controls.Add(this.lblFica);
            this.groupBox2.Controls.Add(this.lblGrossPay);
            this.groupBox2.Location = new System.Drawing.Point(33, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(341, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // lblNetPayValue
            // 
            this.lblNetPayValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPayValue.Location = new System.Drawing.Point(147, 192);
            this.lblNetPayValue.Name = "lblNetPayValue";
            this.lblNetPayValue.Size = new System.Drawing.Size(175, 23);
            this.lblNetPayValue.TabIndex = 4;
            this.lblNetPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUnionDuesValue
            // 
            this.lblUnionDuesValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUnionDuesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnionDuesValue.Location = new System.Drawing.Point(147, 159);
            this.lblUnionDuesValue.Name = "lblUnionDuesValue";
            this.lblUnionDuesValue.Size = new System.Drawing.Size(175, 23);
            this.lblUnionDuesValue.TabIndex = 4;
            this.lblUnionDuesValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFedTaxValue
            // 
            this.lblFedTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFedTaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFedTaxValue.Location = new System.Drawing.Point(147, 126);
            this.lblFedTaxValue.Name = "lblFedTaxValue";
            this.lblFedTaxValue.Size = new System.Drawing.Size(175, 23);
            this.lblFedTaxValue.TabIndex = 4;
            this.lblFedTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStateTaxValue
            // 
            this.lblStateTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStateTaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTaxValue.Location = new System.Drawing.Point(147, 93);
            this.lblStateTaxValue.Name = "lblStateTaxValue";
            this.lblStateTaxValue.Size = new System.Drawing.Size(175, 23);
            this.lblStateTaxValue.TabIndex = 4;
            this.lblStateTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFicaTaxValue
            // 
            this.lblFicaTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFicaTaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFicaTaxValue.Location = new System.Drawing.Point(147, 60);
            this.lblFicaTaxValue.Name = "lblFicaTaxValue";
            this.lblFicaTaxValue.Size = new System.Drawing.Size(175, 23);
            this.lblFicaTaxValue.TabIndex = 4;
            this.lblFicaTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrossPayValue
            // 
            this.lblGrossPayValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrossPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPayValue.Location = new System.Drawing.Point(147, 27);
            this.lblGrossPayValue.Name = "lblGrossPayValue";
            this.lblGrossPayValue.Size = new System.Drawing.Size(175, 23);
            this.lblGrossPayValue.TabIndex = 4;
            this.lblGrossPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(6, 199);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(59, 16);
            this.lblNetPay.TabIndex = 3;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // lblUnionDues
            // 
            this.lblUnionDues.AutoSize = true;
            this.lblUnionDues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnionDues.Location = new System.Drawing.Point(6, 166);
            this.lblUnionDues.Name = "lblUnionDues";
            this.lblUnionDues.Size = new System.Drawing.Size(81, 16);
            this.lblUnionDues.TabIndex = 3;
            this.lblUnionDues.Text = "Union Dues:";
            // 
            // lblFedTax
            // 
            this.lblFedTax.AutoSize = true;
            this.lblFedTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFedTax.Location = new System.Drawing.Point(6, 133);
            this.lblFedTax.Name = "lblFedTax";
            this.lblFedTax.Size = new System.Drawing.Size(84, 16);
            this.lblFedTax.TabIndex = 3;
            this.lblFedTax.Text = "Federal Tax:";
            // 
            // lblStateTax
            // 
            this.lblStateTax.AutoSize = true;
            this.lblStateTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateTax.Location = new System.Drawing.Point(6, 100);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(68, 16);
            this.lblStateTax.TabIndex = 3;
            this.lblStateTax.Text = "State Tax:";
            // 
            // lblFica
            // 
            this.lblFica.AutoSize = true;
            this.lblFica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFica.Location = new System.Drawing.Point(6, 67);
            this.lblFica.Name = "lblFica";
            this.lblFica.Size = new System.Drawing.Size(66, 16);
            this.lblFica.TabIndex = 2;
            this.lblFica.Text = "FICA Tax:";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(6, 34);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(74, 16);
            this.lblGrossPay.TabIndex = 2;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAvgNetPayValue);
            this.groupBox3.Controls.Add(this.lblAvgPay);
            this.groupBox3.Controls.Add(this.lblEmployeeCountValue);
            this.groupBox3.Controls.Add(this.lblTotalNetPayValue);
            this.groupBox3.Controls.Add(this.lblEmployeeCount);
            this.groupBox3.Controls.Add(this.lblTotNetPay);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox3.Location = new System.Drawing.Point(33, 425);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totals";
            // 
            // lblAvgNetPayValue
            // 
            this.lblAvgNetPayValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAvgNetPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgNetPayValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvgNetPayValue.Location = new System.Drawing.Point(147, 107);
            this.lblAvgNetPayValue.Name = "lblAvgNetPayValue";
            this.lblAvgNetPayValue.Size = new System.Drawing.Size(175, 23);
            this.lblAvgNetPayValue.TabIndex = 7;
            this.lblAvgNetPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvgPay
            // 
            this.lblAvgPay.AutoSize = true;
            this.lblAvgPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvgPay.Location = new System.Drawing.Point(6, 114);
            this.lblAvgPay.Name = "lblAvgPay";
            this.lblAvgPay.Size = new System.Drawing.Size(114, 16);
            this.lblAvgPay.TabIndex = 6;
            this.lblAvgPay.Text = "Average Net Pay:";
            // 
            // lblEmployeeCountValue
            // 
            this.lblEmployeeCountValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmployeeCountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCountValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmployeeCountValue.Location = new System.Drawing.Point(147, 65);
            this.lblEmployeeCountValue.Name = "lblEmployeeCountValue";
            this.lblEmployeeCountValue.Size = new System.Drawing.Size(175, 23);
            this.lblEmployeeCountValue.TabIndex = 5;
            this.lblEmployeeCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalNetPayValue
            // 
            this.lblTotalNetPayValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalNetPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNetPayValue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotalNetPayValue.Location = new System.Drawing.Point(147, 27);
            this.lblTotalNetPayValue.Name = "lblTotalNetPayValue";
            this.lblTotalNetPayValue.Size = new System.Drawing.Size(175, 23);
            this.lblTotalNetPayValue.TabIndex = 5;
            this.lblTotalNetPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalNetPayValue.Click += new System.EventHandler(this.lblTotalNetPayValue_Click);
            // 
            // lblEmployeeCount
            // 
            this.lblEmployeeCount.AutoSize = true;
            this.lblEmployeeCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmployeeCount.Location = new System.Drawing.Point(6, 72);
            this.lblEmployeeCount.Name = "lblEmployeeCount";
            this.lblEmployeeCount.Size = new System.Drawing.Size(110, 16);
            this.lblEmployeeCount.TabIndex = 2;
            this.lblEmployeeCount.Text = "Employee Count:";
            // 
            // lblTotNetPay
            // 
            this.lblTotNetPay.AutoSize = true;
            this.lblTotNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotNetPay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotNetPay.Location = new System.Drawing.Point(6, 34);
            this.lblTotNetPay.Name = "lblTotNetPay";
            this.lblTotNetPay.Size = new System.Drawing.Size(93, 16);
            this.lblTotNetPay.TabIndex = 2;
            this.lblTotNetPay.Text = "Total Net Pay:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(48, 603);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(89, 27);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearForm.Location = new System.Drawing.Point(157, 603);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(89, 27);
            this.btnClearForm.TabIndex = 3;
            this.btnClearForm.Text = "C&lear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(266, 603);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pay Calculator";
            // 
            // CS4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CS4Form";
            this.Text = "CS4 Jim Harris";
            this.Load += new System.EventHandler(this.CS4Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFica;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblNetPayValue;
        private System.Windows.Forms.Label lblUnionDuesValue;
        private System.Windows.Forms.Label lblFedTaxValue;
        private System.Windows.Forms.Label lblStateTaxValue;
        private System.Windows.Forms.Label lblFicaTaxValue;
        private System.Windows.Forms.Label lblGrossPayValue;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblUnionDues;
        private System.Windows.Forms.Label lblFedTax;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEmployeeCount;
        private System.Windows.Forms.Label lblTotNetPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblEmployeeCountValue;
        private System.Windows.Forms.Label lblTotalNetPayValue;
        private System.Windows.Forms.Label lblAvgNetPayValue;
        private System.Windows.Forms.Label lblAvgPay;
        private System.Windows.Forms.Label label1;

    }
}

