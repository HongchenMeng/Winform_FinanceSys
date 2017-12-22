namespace FinanceSys.FinanceManagerSys
{
    partial class Form_Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Account));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.HK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shouru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yumoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnwhere = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txttime);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询科目";
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(341, 56);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(133, 21);
            this.txttime.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(119, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "RMB";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(387, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " 库存现金 —— 人民币现金";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "截止日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "币别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "现金科目：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccount);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "本月收支详细信息";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            this.dgvAccount.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HK,
            this.shouru,
            this.zhichu,
            this.yumoney});
            this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAccount.Location = new System.Drawing.Point(3, 17);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowTemplate.Height = 23;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(505, 180);
            this.dgvAccount.TabIndex = 0;
            // 
            // HK
            // 
            this.HK.HeaderText = "应收回款";
            this.HK.Name = "HK";
            this.HK.ReadOnly = true;
            this.HK.Width = 120;
            // 
            // shouru
            // 
            this.shouru.HeaderText = "本月总收入";
            this.shouru.Name = "shouru";
            this.shouru.ReadOnly = true;
            this.shouru.Width = 120;
            // 
            // zhichu
            // 
            this.zhichu.HeaderText = "本月总支出";
            this.zhichu.Name = "zhichu";
            this.zhichu.ReadOnly = true;
            this.zhichu.Width = 120;
            // 
            // yumoney
            // 
            this.yumoney.HeaderText = "本月账户余额";
            this.yumoney.Name = "yumoney";
            this.yumoney.ReadOnly = true;
            this.yumoney.Width = 140;
            // 
            // btnwhere
            // 
            this.btnwhere.Image = ((System.Drawing.Image)(resources.GetObject("btnwhere.Image")));
            this.btnwhere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnwhere.Location = new System.Drawing.Point(348, 324);
            this.btnwhere.Name = "btnwhere";
            this.btnwhere.Size = new System.Drawing.Size(94, 23);
            this.btnwhere.TabIndex = 6;
            this.btnwhere.Text = "过滤条件";
            this.btnwhere.UseVisualStyleBackColor = true;
            this.btnwhere.Click += new System.EventHandler(this.btnwhere_Click);
            // 
            // btnexit
            // 
            this.btnexit.Image = global::FinanceSys.Properties.Resources.撤销;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(448, 324);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 349);
            this.Controls.Add(this.btnwhere);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Account";
            this.Text = "财务管理——账户查询";
            this.Load += new System.EventHandler(this.Form_Account_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnwhere;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridViewTextBoxColumn HK;
        private System.Windows.Forms.DataGridViewTextBoxColumn shouru;
        private System.Windows.Forms.DataGridViewTextBoxColumn zhichu;
        private System.Windows.Forms.DataGridViewTextBoxColumn yumoney;
    }
}