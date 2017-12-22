namespace FinanceSys.PersonnelSys
{
    partial class Form_WageGrantList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WageGrantList));
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCountFooting = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvWageCount = new System.Windows.Forms.DataGridView();
            this.xuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicwage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traffic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jintie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.award = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.madewage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shebao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualwage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWageCount)).BeginInit();
            this.SuspendLayout();
            // 
            // dtptime
            // 
            this.dtptime.CustomFormat = "yyyy-MM";
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptime.Location = new System.Drawing.Point(594, 28);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(66, 21);
            this.dtptime.TabIndex = 40;
            this.dtptime.ValueChanged += new System.EventHandler(this.dtptime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "发放时间：";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(481, 36);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(11, 12);
            this.lblCount.TabIndex = 38;
            this.lblCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 37;
            this.label3.Text = "总记录数：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1059, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "总合计：";
            // 
            // lblCountFooting
            // 
            this.lblCountFooting.AutoSize = true;
            this.lblCountFooting.Location = new System.Drawing.Point(1118, 39);
            this.lblCountFooting.Name = "lblCountFooting";
            this.lblCountFooting.Size = new System.Drawing.Size(35, 12);
            this.lblCountFooting.TabIndex = 42;
            this.lblCountFooting.Text = "Count";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnExcel,
            this.toolStripSeparator2,
            this.btnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 44;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(57, 22);
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(52, 22);
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvWageCount);
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 365);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工资发放";
            // 
            // dgvWageCount
            // 
            this.dgvWageCount.AllowUserToAddRows = false;
            this.dgvWageCount.AllowUserToDeleteRows = false;
            this.dgvWageCount.AllowUserToOrderColumns = true;
            this.dgvWageCount.AllowUserToResizeColumns = false;
            this.dgvWageCount.AllowUserToResizeRows = false;
            this.dgvWageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWageCount.BackgroundColor = System.Drawing.Color.White;
            this.dgvWageCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWageCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xuhao,
            this.month,
            this.empname,
            this.basicwage,
            this.traffic,
            this.jintie,
            this.jiaban,
            this.award,
            this.tic,
            this.madewage,
            this.lv,
            this.shebao,
            this.other,
            this.deduction,
            this.actualwage});
            this.dgvWageCount.Location = new System.Drawing.Point(6, 13);
            this.dgvWageCount.Name = "dgvWageCount";
            this.dgvWageCount.ReadOnly = true;
            this.dgvWageCount.RowHeadersVisible = false;
            this.dgvWageCount.RowTemplate.Height = 23;
            this.dgvWageCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWageCount.Size = new System.Drawing.Size(651, 342);
            this.dgvWageCount.TabIndex = 47;
            // 
            // xuhao
            // 
            this.xuhao.Frozen = true;
            this.xuhao.HeaderText = "序号";
            this.xuhao.Name = "xuhao";
            this.xuhao.ReadOnly = true;
            this.xuhao.Width = 65;
            // 
            // month
            // 
            this.month.Frozen = true;
            this.month.HeaderText = "月份";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Width = 75;
            // 
            // empname
            // 
            this.empname.Frozen = true;
            this.empname.HeaderText = "员工姓名";
            this.empname.Name = "empname";
            this.empname.ReadOnly = true;
            this.empname.Width = 85;
            // 
            // basicwage
            // 
            this.basicwage.DataPropertyName = "BasicWage";
            this.basicwage.HeaderText = "基本工资";
            this.basicwage.Name = "basicwage";
            this.basicwage.ReadOnly = true;
            this.basicwage.Width = 85;
            // 
            // traffic
            // 
            this.traffic.HeaderText = "岗位补贴";
            this.traffic.Name = "traffic";
            this.traffic.ReadOnly = true;
            this.traffic.Width = 85;
            // 
            // jintie
            // 
            this.jintie.HeaderText = "津贴";
            this.jintie.Name = "jintie";
            this.jintie.ReadOnly = true;
            this.jintie.Width = 80;
            // 
            // jiaban
            // 
            this.jiaban.HeaderText = "加班工资";
            this.jiaban.Name = "jiaban";
            this.jiaban.ReadOnly = true;
            this.jiaban.Width = 85;
            // 
            // award
            // 
            this.award.DataPropertyName = "Award";
            this.award.HeaderText = "奖金";
            this.award.Name = "award";
            this.award.ReadOnly = true;
            this.award.Width = 80;
            // 
            // tic
            // 
            this.tic.DataPropertyName = "Tic";
            this.tic.HeaderText = "业务提成";
            this.tic.Name = "tic";
            this.tic.ReadOnly = true;
            this.tic.Width = 85;
            // 
            // madewage
            // 
            this.madewage.HeaderText = "应发工资总额";
            this.madewage.Name = "madewage";
            this.madewage.ReadOnly = true;
            this.madewage.Width = 105;
            // 
            // lv
            // 
            this.lv.HeaderText = "个人所得税";
            this.lv.Name = "lv";
            this.lv.ReadOnly = true;
            this.lv.Width = 90;
            // 
            // shebao
            // 
            this.shebao.DataPropertyName = "QQing";
            this.shebao.HeaderText = "社保";
            this.shebao.Name = "shebao";
            this.shebao.ReadOnly = true;
            this.shebao.Width = 80;
            // 
            // other
            // 
            this.other.DataPropertyName = "Other";
            this.other.HeaderText = "其它";
            this.other.Name = "other";
            this.other.ReadOnly = true;
            this.other.Width = 80;
            // 
            // deduction
            // 
            this.deduction.HeaderText = "代扣代缴";
            this.deduction.Name = "deduction";
            this.deduction.ReadOnly = true;
            this.deduction.Width = 85;
            // 
            // actualwage
            // 
            this.actualwage.HeaderText = "实发工资";
            this.actualwage.Name = "actualwage";
            this.actualwage.ReadOnly = true;
            this.actualwage.Width = 85;
            // 
            // Form_WageGrantList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblCountFooting);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtptime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_WageGrantList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——工资发放";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_WageGrantList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWageCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountFooting;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvWageCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn empname;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicwage;
        private System.Windows.Forms.DataGridViewTextBoxColumn traffic;
        private System.Windows.Forms.DataGridViewTextBoxColumn jintie;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn award;
        private System.Windows.Forms.DataGridViewTextBoxColumn tic;
        private System.Windows.Forms.DataGridViewTextBoxColumn madewage;
        private System.Windows.Forms.DataGridViewTextBoxColumn lv;
        private System.Windows.Forms.DataGridViewTextBoxColumn shebao;
        private System.Windows.Forms.DataGridViewTextBoxColumn other;
        private System.Windows.Forms.DataGridViewTextBoxColumn deduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualwage;
    }
}