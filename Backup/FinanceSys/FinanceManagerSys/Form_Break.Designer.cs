namespace FinanceSys.FinanceManagerSys
{
    partial class Form_Break
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Break));
            this.gbmsg = new System.Windows.Forms.GroupBox();
            this.txtTic = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.txtDemoname = new System.Windows.Forms.TextBox();
            this.txtBBreak = new System.Windows.Forms.TextBox();
            this.txtBreakMoney = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.gbmsg.Controls.Add(this.cbxEmp);
            this.gbmsg.Controls.Add(this.txtDemoname);
            this.gbmsg.Controls.Add(this.txtBBreak);
            this.gbmsg.Controls.Add(this.txtBreakMoney);
            this.gbmsg.Controls.Add(this.txtMoney);
            this.gbmsg.Controls.Add(this.label14);
            this.gbmsg.Controls.Add(this.label8);
            this.gbmsg.Controls.Add(this.label7);
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
            this.gbmsg.Controls.Add(this.txtcontractno);
            this.gbmsg.Controls.Add(this.label1);
            this.gbmsg.Location = new System.Drawing.Point(12, 12);
            this.gbmsg.Name = "gbmsg";
            this.gbmsg.Size = new System.Drawing.Size(289, 463);
            this.gbmsg.TabIndex = 15;
            this.gbmsg.TabStop = false;
            this.gbmsg.Text = "合同收入资金回款金额信息录入";
            // 
            // txtTic
            // 
            this.txtTic.Location = new System.Drawing.Point(101, 326);
            this.txtTic.Name = "txtTic";
            this.txtTic.ReadOnly = true;
            this.txtTic.Size = new System.Drawing.Size(165, 21);
            this.txtTic.TabIndex = 18;
            this.txtTic.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 17;
            this.label12.Text = "项目提成：";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FinanceSys.Properties.Resources.撤销;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(191, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "撤销";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOK.Image = global::FinanceSys.Properties.Resources.保存;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(110, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
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
            this.dtptime.Enabled = false;
            this.dtptime.Location = new System.Drawing.Point(101, 49);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(165, 21);
            this.dtptime.TabIndex = 9;
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.Enabled = false;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(101, 300);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(165, 20);
            this.cbxEmp.TabIndex = 8;
            // 
            // txtDemoname
            // 
            this.txtDemoname.Location = new System.Drawing.Point(101, 76);
            this.txtDemoname.MaxLength = 30;
            this.txtDemoname.Name = "txtDemoname";
            this.txtDemoname.ReadOnly = true;
            this.txtDemoname.Size = new System.Drawing.Size(165, 21);
            this.txtDemoname.TabIndex = 3;
            // 
            // txtBBreak
            // 
            this.txtBBreak.Location = new System.Drawing.Point(101, 212);
            this.txtBBreak.Name = "txtBBreak";
            this.txtBBreak.ReadOnly = true;
            this.txtBBreak.Size = new System.Drawing.Size(165, 21);
            this.txtBBreak.TabIndex = 4;
            this.txtBBreak.Text = "0.00";
            this.txtBBreak.TextChanged += new System.EventHandler(this.txtBreakMoney_TextChanged);
            // 
            // txtBreakMoney
            // 
            this.txtBreakMoney.Location = new System.Drawing.Point(101, 185);
            this.txtBreakMoney.Name = "txtBreakMoney";
            this.txtBreakMoney.Size = new System.Drawing.Size(165, 21);
            this.txtBreakMoney.TabIndex = 1;
            this.txtBreakMoney.Text = "0.00";
            this.txtBreakMoney.TextChanged += new System.EventHandler(this.txtBreakMoney_TextChanged);
            this.txtBreakMoney.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBreakMoney_MouseDown);
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(101, 158);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(165, 21);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "已回款金额：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "业务员：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "回款金额：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "合同签订时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "项目金额：";
            // 
            // txtDemocost
            // 
            this.txtDemocost.Location = new System.Drawing.Point(101, 243);
            this.txtDemocost.Name = "txtDemocost";
            this.txtDemocost.ReadOnly = true;
            this.txtDemocost.Size = new System.Drawing.Size(165, 21);
            this.txtDemocost.TabIndex = 7;
            this.txtDemocost.Text = "0.00";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(101, 131);
            this.txtB.MaxLength = 30;
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(165, 21);
            this.txtB.TabIndex = 2;
            // 
            // txtParty
            // 
            this.txtParty.Location = new System.Drawing.Point(101, 104);
            this.txtParty.MaxLength = 30;
            this.txtParty.Name = "txtParty";
            this.txtParty.ReadOnly = true;
            this.txtParty.Size = new System.Drawing.Size(165, 21);
            this.txtParty.TabIndex = 2;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(101, 353);
            this.txtRemark.MaxLength = 500;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(165, 70);
            this.txtRemark.TabIndex = 12;
            // 
            // txtOperperson
            // 
            this.txtOperperson.Location = new System.Drawing.Point(101, 271);
            this.txtOperperson.MaxLength = 15;
            this.txtOperperson.Name = "txtOperperson";
            this.txtOperperson.ReadOnly = true;
            this.txtOperperson.Size = new System.Drawing.Size(165, 21);
            this.txtOperperson.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "乙方名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "甲方名称：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "备注：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "项目成本：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(42, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "操作员：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "项目名称：";
            // 
            // txtcontractno
            // 
            this.txtcontractno.Location = new System.Drawing.Point(101, 20);
            this.txtcontractno.MaxLength = 12;
            this.txtcontractno.Name = "txtcontractno";
            this.txtcontractno.ReadOnly = true;
            this.txtcontractno.Size = new System.Drawing.Size(165, 21);
            this.txtcontractno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "合同编号：";
            // 
            // Form_Break
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 486);
            this.Controls.Add(this.gbmsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Break";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——回款录入";
            this.Load += new System.EventHandler(this.Form_Break_Load);
            this.gbmsg.ResumeLayout(false);
            this.gbmsg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbmsg;
        private System.Windows.Forms.TextBox txtTic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.TextBox txtDemoname;
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
        private System.Windows.Forms.TextBox txtcontractno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBreakMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBBreak;
        private System.Windows.Forms.Label label14;
    }
}