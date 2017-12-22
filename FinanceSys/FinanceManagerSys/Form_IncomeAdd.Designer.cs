namespace FinanceSys.FinanceManagerSys
{
    partial class Form_IncomeAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_IncomeAdd));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtOperPerson = new System.Windows.Forms.TextBox();
            this.txtdemoname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtltdname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpMonth);
            this.groupBox3.Controls.Add(this.cbxType);
            this.groupBox3.Controls.Add(this.txtMoney);
            this.groupBox3.Controls.Add(this.txtType);
            this.groupBox3.Controls.Add(this.txtOperPerson);
            this.groupBox3.Controls.Add(this.txtdemoname);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtltdname);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 225);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "非合同收入资金详细信息录入";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "yyyy-MM-dd";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(84, 52);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(122, 21);
            this.dtpMonth.TabIndex = 3;
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "--无--",
            "网络推广费",
            "地图认刊费",
            "顾问费",
            "广告费"});
            this.cbxType.Location = new System.Drawing.Point(241, 53);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 20);
            this.cbxType.TabIndex = 4;
            this.cbxType.Visible = false;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(455, 86);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(122, 21);
            this.txtMoney.TabIndex = 6;
            this.txtMoney.Text = "0.00";
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMoney_MouseDown);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(455, 52);
            this.txtType.MaxLength = 15;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(121, 21);
            this.txtType.TabIndex = 5;
            // 
            // txtOperPerson
            // 
            this.txtOperPerson.Location = new System.Drawing.Point(85, 83);
            this.txtOperPerson.MaxLength = 15;
            this.txtOperPerson.Name = "txtOperPerson";
            this.txtOperPerson.Size = new System.Drawing.Size(121, 21);
            this.txtOperPerson.TabIndex = 5;
            // 
            // txtdemoname
            // 
            this.txtdemoname.Location = new System.Drawing.Point(455, 20);
            this.txtdemoname.MaxLength = 30;
            this.txtdemoname.Name = "txtdemoname";
            this.txtdemoname.Size = new System.Drawing.Size(212, 21);
            this.txtdemoname.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 51;
            this.label9.Text = "收入金额：";
            // 
            // txtltdname
            // 
            this.txtltdname.Location = new System.Drawing.Point(84, 20);
            this.txtltdname.MaxLength = 30;
            this.txtltdname.Name = "txtltdname";
            this.txtltdname.Size = new System.Drawing.Size(278, 21);
            this.txtltdname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "收入类型：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "操作员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "公司名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "项目名称：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(89, 116);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(583, 74);
            this.txtRemark.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "收入月份：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "备注：";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FinanceSys.Properties.Resources.撤销;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(615, 244);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "撤消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOK.Image = global::FinanceSys.Properties.Resources.保存;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOK.Location = new System.Drawing.Point(534, 244);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form_IncomeAdd
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_IncomeAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——非合同收入资金录入";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtOperPerson;
        private System.Windows.Forms.TextBox txtdemoname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtltdname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtType;
    }
}