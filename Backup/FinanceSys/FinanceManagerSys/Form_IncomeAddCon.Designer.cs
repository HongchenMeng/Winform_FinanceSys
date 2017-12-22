namespace FinanceSys.FinanceManagerSys
{
    partial class Form_IncomeAddCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_IncomeAddCon));
            this.gbmsg = new System.Windows.Forms.GroupBox();
            this.txtTic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.txtDemoname = new System.Windows.Forms.TextBox();
            this.cbxPayment = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDemocost = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtParty = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtOperperson = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcontractno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbmsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbmsg
            // 
            this.gbmsg.Controls.Add(this.txtTic);
            this.gbmsg.Controls.Add(this.label12);
            this.gbmsg.Controls.Add(this.btnCancel);
            this.gbmsg.Controls.Add(this.btnOK);
            this.gbmsg.Controls.Add(this.dateTimePicker2);
            this.gbmsg.Controls.Add(this.dtptime);
            this.gbmsg.Controls.Add(this.cbxType);
            this.gbmsg.Controls.Add(this.cbxEmp);
            this.gbmsg.Controls.Add(this.txtDemoname);
            this.gbmsg.Controls.Add(this.cbxPayment);
            this.gbmsg.Controls.Add(this.label9);
            this.gbmsg.Controls.Add(this.txtMoney);
            this.gbmsg.Controls.Add(this.label8);
            this.gbmsg.Controls.Add(this.label15);
            this.gbmsg.Controls.Add(this.label4);
            this.gbmsg.Controls.Add(this.txtDemocost);
            this.gbmsg.Controls.Add(this.txtB);
            this.gbmsg.Controls.Add(this.txtParty);
            this.gbmsg.Controls.Add(this.txtRemark);
            this.gbmsg.Controls.Add(this.txtOperperson);
            this.gbmsg.Controls.Add(this.label13);
            this.gbmsg.Controls.Add(this.label2);
            this.gbmsg.Controls.Add(this.label10);
            this.gbmsg.Controls.Add(this.label6);
            this.gbmsg.Controls.Add(this.label11);
            this.gbmsg.Controls.Add(this.label3);
            this.gbmsg.Controls.Add(this.label5);
            this.gbmsg.Controls.Add(this.txtcontractno);
            this.gbmsg.Controls.Add(this.label1);
            this.gbmsg.Location = new System.Drawing.Point(12, 12);
            this.gbmsg.Name = "gbmsg";
            this.gbmsg.Size = new System.Drawing.Size(838, 279);
            this.gbmsg.TabIndex = 14;
            this.gbmsg.TabStop = false;
            this.gbmsg.Text = "合同收入资金详细信息录入";
            // 
            // txtTic
            // 
            this.txtTic.Location = new System.Drawing.Point(630, 110);
            this.txtTic.Name = "txtTic";
            this.txtTic.Size = new System.Drawing.Size(121, 21);
            this.txtTic.TabIndex = 12;
            this.txtTic.Text = "0.00";
            this.txtTic.TextChanged += new System.EventHandler(this.txtTic_TextChanged);
            this.txtTic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtTic_MouseDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(559, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "项目提成：";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FinanceSys.Properties.Resources.撤销;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(750, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "撤消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOK.Image = global::FinanceSys.Properties.Resources.保存;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnOK.Location = new System.Drawing.Point(669, 249);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "保存";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1173, 70);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 21);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // dtptime
            // 
            this.dtptime.Location = new System.Drawing.Point(630, 83);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(121, 21);
            this.dtptime.TabIndex = 9;
            // 
            // cbxType
            // 
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Items.AddRange(new object[] {
            "网络推广",
            "地图认刊",
            "顾问",
            "广告"});
            this.cbxType.Location = new System.Drawing.Point(338, 111);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 20);
            this.cbxType.TabIndex = 11;
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(338, 83);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(121, 20);
            this.cbxEmp.TabIndex = 8;
            this.cbxEmp.SelectedIndexChanged += new System.EventHandler(this.cbxEmp_SelectedIndexChanged);
            // 
            // txtDemoname
            // 
            this.txtDemoname.Location = new System.Drawing.Point(87, 53);
            this.txtDemoname.MaxLength = 30;
            this.txtDemoname.Name = "txtDemoname";
            this.txtDemoname.Size = new System.Drawing.Size(165, 21);
            this.txtDemoname.TabIndex = 4;
            // 
            // cbxPayment
            // 
            this.cbxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPayment.FormattingEnabled = true;
            this.cbxPayment.Items.AddRange(new object[] {
            "分期付款",
            "一次性付款"});
            this.cbxPayment.Location = new System.Drawing.Point(630, 54);
            this.cbxPayment.Name = "cbxPayment";
            this.cbxPayment.Size = new System.Drawing.Size(121, 20);
            this.cbxPayment.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "合同类别：";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(338, 52);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(202, 21);
            this.txtMoney.TabIndex = 5;
            this.txtMoney.Text = "0.00";
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            this.txtMoney.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtMoney_MouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(279, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "业务员：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(535, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "合同签订时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "项目金额：";
            // 
            // txtDemocost
            // 
            this.txtDemocost.Location = new System.Drawing.Point(87, 83);
            this.txtDemocost.Name = "txtDemocost";
            this.txtDemocost.Size = new System.Drawing.Size(100, 21);
            this.txtDemocost.TabIndex = 7;
            this.txtDemocost.Text = "0.00";
            this.txtDemocost.TextChanged += new System.EventHandler(this.txtDemocost_TextChanged);
            this.txtDemocost.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtDemocost_MouseDown);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(630, 20);
            this.txtB.MaxLength = 30;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(202, 21);
            this.txtB.TabIndex = 3;
            // 
            // txtParty
            // 
            this.txtParty.Location = new System.Drawing.Point(338, 20);
            this.txtParty.MaxLength = 30;
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(202, 21);
            this.txtParty.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(87, 138);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(738, 91);
            this.txtRemark.TabIndex = 13;
            // 
            // txtOperperson
            // 
            this.txtOperperson.Location = new System.Drawing.Point(87, 111);
            this.txtOperperson.MaxLength = 15;
            this.txtOperperson.Name = "txtOperperson";
            this.txtOperperson.Size = new System.Drawing.Size(100, 21);
            this.txtOperperson.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(559, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "乙方名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "甲方名称：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "备注：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "项目成本：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "操作员：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "项目名称：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "付款方式：";
            // 
            // txtcontractno
            // 
            this.txtcontractno.Location = new System.Drawing.Point(87, 20);
            this.txtcontractno.MaxLength = 12;
            this.txtcontractno.Name = "txtcontractno";
            this.txtcontractno.Size = new System.Drawing.Size(165, 21);
            this.txtcontractno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "合同编号：";
            // 
            // Form_IncomeAddCon
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 296);
            this.Controls.Add(this.gbmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_IncomeAddCon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——合同收入资金录入";
            this.Load += new System.EventHandler(this.Form_IncomeAddCon_Load);
            this.gbmsg.ResumeLayout(false);
            this.gbmsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmsg;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.TextBox txtDemoname;
        private System.Windows.Forms.ComboBox cbxPayment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDemocost;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtParty;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtOperperson;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcontractno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtTic;
        private System.Windows.Forms.Label label12;

    }
}