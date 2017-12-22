namespace FinanceSys.PersonnelSys
{
    partial class Form_EmpWageAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EmpWageAdd));
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.txtSocialSecurity = new System.Windows.Forms.TextBox();
            this.txtJobsubsidies = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.txtOvertimepay = new System.Windows.Forms.TextBox();
            this.txtAllowance = new System.Windows.Forms.TextBox();
            this.txtPersonalIncomeTax = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtTic = new System.Windows.Forms.TextBox();
            this.txtBasicWage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(291, 20);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(121, 20);
            this.cbxEmp.TabIndex = 2;
            // 
            // txtSocialSecurity
            // 
            this.txtSocialSecurity.Location = new System.Drawing.Point(291, 133);
            this.txtSocialSecurity.Name = "txtSocialSecurity";
            this.txtSocialSecurity.Size = new System.Drawing.Size(121, 21);
            this.txtSocialSecurity.TabIndex = 10;
            this.txtSocialSecurity.Text = "0.00";
            this.txtSocialSecurity.TextChanged += new System.EventHandler(this.txtSocialSecurity_TextChanged);
            this.txtSocialSecurity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtSocialSecurity_MouseDown);
            // 
            // txtJobsubsidies
            // 
            this.txtJobsubsidies.Location = new System.Drawing.Point(80, 79);
            this.txtJobsubsidies.Name = "txtJobsubsidies";
            this.txtJobsubsidies.Size = new System.Drawing.Size(120, 21);
            this.txtJobsubsidies.TabIndex = 5;
            this.txtJobsubsidies.Text = "0.00";
            this.txtJobsubsidies.TextChanged += new System.EventHandler(this.txtJobsubsidies_TextChanged);
            this.txtJobsubsidies.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtJobsubsidies_MouseDown);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(80, 167);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(332, 79);
            this.txtRemark.TabIndex = 11;
            // 
            // txtOther
            // 
            this.txtOther.Location = new System.Drawing.Point(80, 133);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(120, 21);
            this.txtOther.TabIndex = 9;
            this.txtOther.Text = "0.00";
            this.txtOther.TextChanged += new System.EventHandler(this.txtOther_TextChanged);
            this.txtOther.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOther_MouseDown);
            // 
            // txtOvertimepay
            // 
            this.txtOvertimepay.Location = new System.Drawing.Point(291, 47);
            this.txtOvertimepay.Name = "txtOvertimepay";
            this.txtOvertimepay.Size = new System.Drawing.Size(121, 21);
            this.txtOvertimepay.TabIndex = 4;
            this.txtOvertimepay.Text = "0.00";
            this.txtOvertimepay.TextChanged += new System.EventHandler(this.txtOvertimepay_TextChanged);
            this.txtOvertimepay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtOvertimepay_MouseDown);
            // 
            // txtAllowance
            // 
            this.txtAllowance.Location = new System.Drawing.Point(291, 79);
            this.txtAllowance.Name = "txtAllowance";
            this.txtAllowance.Size = new System.Drawing.Size(121, 21);
            this.txtAllowance.TabIndex = 6;
            this.txtAllowance.Text = "0.00";
            this.txtAllowance.TextChanged += new System.EventHandler(this.txtAllowance_TextChanged);
            this.txtAllowance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtAllowance_MouseDown);
            // 
            // txtPersonalIncomeTax
            // 
            this.txtPersonalIncomeTax.Location = new System.Drawing.Point(291, 106);
            this.txtPersonalIncomeTax.Name = "txtPersonalIncomeTax";
            this.txtPersonalIncomeTax.Size = new System.Drawing.Size(121, 21);
            this.txtPersonalIncomeTax.TabIndex = 8;
            this.txtPersonalIncomeTax.Text = "0.00";
            this.txtPersonalIncomeTax.TextChanged += new System.EventHandler(this.txtPersonalIncomeTax_TextChanged);
            this.txtPersonalIncomeTax.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtPersonalIncomeTax_MouseDown);
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(80, 106);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(120, 21);
            this.txtBonus.TabIndex = 7;
            this.txtBonus.Text = "0.00";
            this.txtBonus.TextChanged += new System.EventHandler(this.txtBonus_TextChanged);
            this.txtBonus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBonus_MouseDown);
            // 
            // txtTic
            // 
            this.txtTic.Location = new System.Drawing.Point(418, 73);
            this.txtTic.Name = "txtTic";
            this.txtTic.Size = new System.Drawing.Size(42, 21);
            this.txtTic.TabIndex = 63;
            this.txtTic.Text = "0.00";
            this.txtTic.Visible = false;
            // 
            // txtBasicWage
            // 
            this.txtBasicWage.Location = new System.Drawing.Point(80, 47);
            this.txtBasicWage.Name = "txtBasicWage";
            this.txtBasicWage.Size = new System.Drawing.Size(120, 21);
            this.txtBasicWage.TabIndex = 3;
            this.txtBasicWage.Text = "0.00";
            this.txtBasicWage.TextChanged += new System.EventHandler(this.txtBasicWage_TextChanged);
            this.txtBasicWage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBasicWage_MouseDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 68;
            this.label14.Text = "月份：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 50;
            this.label8.Text = "加班工资：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 51;
            this.label5.Text = "备注：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "奖金：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 48;
            this.label13.Text = "其他：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 52;
            this.label7.Text = "津贴：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 55;
            this.label2.Text = "社保：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "业务提成：";
            this.label3.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 45;
            this.label10.Text = "员工姓名：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 53;
            this.label12.Text = "岗位补贴：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 54;
            this.label6.Text = "个人所得税：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 46;
            this.label1.Text = "基本工资：";
            // 
            // dtptime
            // 
            this.dtptime.CustomFormat = "yyyy-MM";
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptime.Location = new System.Drawing.Point(80, 20);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(120, 21);
            this.dtptime.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOK.Location = new System.Drawing.Point(246, 270);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(337, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form_EmpWageAdd
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 309);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.cbxEmp);
            this.Controls.Add(this.txtSocialSecurity);
            this.Controls.Add(this.txtJobsubsidies);
            this.Controls.Add(this.txtRemark);
            this.Controls.Add(this.txtOther);
            this.Controls.Add(this.txtOvertimepay);
            this.Controls.Add(this.txtAllowance);
            this.Controls.Add(this.txtPersonalIncomeTax);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtTic);
            this.Controls.Add(this.txtBasicWage);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_EmpWageAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人事管理——工资数据录入";
            this.Load += new System.EventHandler(this.Form_EmpWageAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.TextBox txtSocialSecurity;
        private System.Windows.Forms.TextBox txtJobsubsidies;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.TextBox txtOvertimepay;
        private System.Windows.Forms.TextBox txtAllowance;
        private System.Windows.Forms.TextBox txtPersonalIncomeTax;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtTic;
        private System.Windows.Forms.TextBox txtBasicWage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}