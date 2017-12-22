namespace FinanceSys.FinanceManagerSys
{
    partial class Form_OutlayAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OutlayAdd));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpoutlaytime = new System.Windows.Forms.DateTimePicker();
            this.cbotype2 = new System.Windows.Forms.ComboBox();
            this.cbotype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtmoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontractno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.txtDemoname = new System.Windows.Forms.TextBox();
            this.txtOperPerson = new System.Windows.Forms.TextBox();
            this.txtBname = new System.Windows.Forms.TextBox();
            this.txtParty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpoutlaytime);
            this.groupBox3.Controls.Add(this.cbotype2);
            this.groupBox3.Controls.Add(this.cbotype);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtmoney);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtcontractno);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbxEmp);
            this.groupBox3.Controls.Add(this.txtDemoname);
            this.groupBox3.Controls.Add(this.txtOperPerson);
            this.groupBox3.Controls.Add(this.txtBname);
            this.groupBox3.Controls.Add(this.txtParty);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtRemark);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(604, 238);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "支出详细信息录入";
            // 
            // dtpoutlaytime
            // 
            this.dtpoutlaytime.Location = new System.Drawing.Point(448, 74);
            this.dtpoutlaytime.Name = "dtpoutlaytime";
            this.dtpoutlaytime.Size = new System.Drawing.Size(144, 21);
            this.dtpoutlaytime.TabIndex = 6;
            // 
            // cbotype2
            // 
            this.cbotype2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype2.FormattingEnabled = true;
            this.cbotype2.Location = new System.Drawing.Point(190, 101);
            this.cbotype2.Name = "cbotype2";
            this.cbotype2.Size = new System.Drawing.Size(81, 20);
            this.cbotype2.TabIndex = 8;
            this.cbotype2.Visible = false;
            // 
            // cbotype
            // 
            this.cbotype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotype.FormattingEnabled = true;
            this.cbotype.Items.AddRange(new object[] {
            "佣金",
            "办公用品",
            "工资",
            "报销",
            "物业费",
            "看房团费",
            "会展费",
            "福利费",
            "审计费",
            "社保费",
            "税费",
            "印刷费"});
            this.cbotype.Location = new System.Drawing.Point(105, 101);
            this.cbotype.Name = "cbotype";
            this.cbotype.Size = new System.Drawing.Size(79, 20);
            this.cbotype.TabIndex = 7;
            this.cbotype.SelectedIndexChanged += new System.EventHandler(this.cbotype_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "业务员：";
            // 
            // txtmoney
            // 
            this.txtmoney.Location = new System.Drawing.Point(448, 16);
            this.txtmoney.Name = "txtmoney";
            this.txtmoney.Size = new System.Drawing.Size(144, 21);
            this.txtmoney.TabIndex = 2;
            this.txtmoney.Text = "0.00";
            this.txtmoney.TextChanged += new System.EventHandler(this.txtmoney_TextChanged);
            this.txtmoney.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtmoney_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 55;
            this.label7.Text = "支出金额：";
            // 
            // txtcontractno
            // 
            this.txtcontractno.Location = new System.Drawing.Point(105, 74);
            this.txtcontractno.MaxLength = 12;
            this.txtcontractno.Name = "txtcontractno";
            this.txtcontractno.Size = new System.Drawing.Size(255, 21);
            this.txtcontractno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 55;
            this.label6.Text = "合同编号：";
            // 
            // cbxEmp
            // 
            this.cbxEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(448, 48);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(144, 20);
            this.cbxEmp.TabIndex = 4;
            // 
            // txtDemoname
            // 
            this.txtDemoname.Location = new System.Drawing.Point(448, 101);
            this.txtDemoname.MaxLength = 10;
            this.txtDemoname.Name = "txtDemoname";
            this.txtDemoname.Size = new System.Drawing.Size(144, 21);
            this.txtDemoname.TabIndex = 9;
            // 
            // txtOperPerson
            // 
            this.txtOperPerson.Location = new System.Drawing.Point(105, 132);
            this.txtOperPerson.MaxLength = 10;
            this.txtOperPerson.Name = "txtOperPerson";
            this.txtOperPerson.Size = new System.Drawing.Size(165, 21);
            this.txtOperPerson.TabIndex = 10;
            // 
            // txtBname
            // 
            this.txtBname.Location = new System.Drawing.Point(105, 47);
            this.txtBname.MaxLength = 30;
            this.txtBname.Name = "txtBname";
            this.txtBname.Size = new System.Drawing.Size(255, 21);
            this.txtBname.TabIndex = 3;
            // 
            // txtParty
            // 
            this.txtParty.Location = new System.Drawing.Point(105, 20);
            this.txtParty.MaxLength = 30;
            this.txtParty.Name = "txtParty";
            this.txtParty.Size = new System.Drawing.Size(255, 21);
            this.txtParty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 50;
            this.label1.Text = "支出类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 51;
            this.label3.Text = "项目名称：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 50;
            this.label9.Text = "乙方名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 51;
            this.label4.Text = "操作员：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "甲方名称：";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(105, 163);
            this.txtRemark.MaxLength = 200;
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(487, 65);
            this.txtRemark.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(377, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 44;
            this.label14.Text = "支出时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "备注：";
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FinanceSys.Properties.Resources.保存;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSave.Location = new System.Drawing.Point(445, 262);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::FinanceSys.Properties.Resources.撤销;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(541, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "撤消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form_OutlayAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 297);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_OutlayAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——支出信息录入";
            this.Load += new System.EventHandler(this.Form_OutlayAdd_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpoutlaytime;
        private System.Windows.Forms.ComboBox cbotype2;
        private System.Windows.Forms.ComboBox cbotype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontractno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxEmp;
        private System.Windows.Forms.TextBox txtOperPerson;
        private System.Windows.Forms.TextBox txtBname;
        private System.Windows.Forms.TextBox txtParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtDemoname;
        private System.Windows.Forms.Label label3;
    }
}