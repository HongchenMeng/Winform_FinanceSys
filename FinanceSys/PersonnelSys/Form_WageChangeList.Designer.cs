﻿namespace FinanceSys.PersonnelSys
{
    partial class Form_WageChangeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_WageChangeList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPayChange = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolbtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator28 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator29 = new System.Windows.Forms.ToolStripSeparator();
            this.lblCurPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator30 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTotalpage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator32 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator33 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator34 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtPage = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator35 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayChange)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvPayChange);
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 379);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工工资调整信息";
            // 
            // dgvPayChange
            // 
            this.dgvPayChange.AllowUserToAddRows = false;
            this.dgvPayChange.AllowUserToDeleteRows = false;
            this.dgvPayChange.AllowUserToOrderColumns = true;
            this.dgvPayChange.AllowUserToResizeRows = false;
            this.dgvPayChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayChange.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayChange.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayChange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayChange.EnableHeadersVisualStyles = false;
            this.dgvPayChange.Location = new System.Drawing.Point(3, 17);
            this.dgvPayChange.Name = "dgvPayChange";
            this.dgvPayChange.ReadOnly = true;
            this.dgvPayChange.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayChange.RowHeadersVisible = false;
            this.dgvPayChange.RowTemplate.Height = 23;
            this.dgvPayChange.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayChange.Size = new System.Drawing.Size(723, 359);
            this.dgvPayChange.TabIndex = 1;
            this.dgvPayChange.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.tsbtnAdd,
            this.toolStripSeparator2,
            this.toolbtnRefresh,
            this.toolStripSeparator5,
            this.tsbtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolbtnRefresh
            // 
            this.toolbtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolbtnRefresh.Image")));
            this.toolbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnRefresh.Name = "toolbtnRefresh";
            this.toolbtnRefresh.Size = new System.Drawing.Size(52, 22);
            this.toolbtnRefresh.Text = "刷新";
            this.toolbtnRefresh.Click += new System.EventHandler(this.toolbtnRefresh_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnClose.Image")));
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(52, 22);
            this.tsbtnClose.Text = "关闭";
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.toolStripSeparator24,
            this.btnBack,
            this.toolStripSeparator25,
            this.btnNext,
            this.toolStripSeparator26,
            this.btnLast,
            this.toolStripSeparator27,
            this.toolStripSeparator28,
            this.toolStripSeparator29,
            this.lblCurPage,
            this.toolStripSeparator30,
            this.lblTotalpage,
            this.toolStripSeparator32,
            this.toolStripSeparator33,
            this.toolStripSeparator34,
            this.toolStripLabel2,
            this.txtPage,
            this.toolStripLabel3,
            this.toolStripSeparator35,
            this.btnFind});
            this.toolStrip3.Location = new System.Drawing.Point(0, 25);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(735, 25);
            this.toolStrip3.TabIndex = 33;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(52, 22);
            this.btnFirst.Text = "首页";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 25);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 22);
            this.btnBack.Text = "上一页";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 22);
            this.btnNext.Text = "下一页";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(6, 25);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(52, 22);
            this.btnLast.Text = "尾页";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator28
            // 
            this.toolStripSeparator28.Name = "toolStripSeparator28";
            this.toolStripSeparator28.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator29
            // 
            this.toolStripSeparator29.Name = "toolStripSeparator29";
            this.toolStripSeparator29.Size = new System.Drawing.Size(6, 25);
            // 
            // lblCurPage
            // 
            this.lblCurPage.Name = "lblCurPage";
            this.lblCurPage.Size = new System.Drawing.Size(39, 22);
            this.lblCurPage.Text = "第1页";
            // 
            // toolStripSeparator30
            // 
            this.toolStripSeparator30.Name = "toolStripSeparator30";
            this.toolStripSeparator30.Size = new System.Drawing.Size(6, 25);
            // 
            // lblTotalpage
            // 
            this.lblTotalpage.Name = "lblTotalpage";
            this.lblTotalpage.Size = new System.Drawing.Size(32, 22);
            this.lblTotalpage.Text = "共页";
            // 
            // toolStripSeparator32
            // 
            this.toolStripSeparator32.Name = "toolStripSeparator32";
            this.toolStripSeparator32.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator33
            // 
            this.toolStripSeparator33.Name = "toolStripSeparator33";
            this.toolStripSeparator33.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator34
            // 
            this.toolStripSeparator34.Name = "toolStripSeparator34";
            this.toolStripSeparator34.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(32, 22);
            this.toolStripLabel2.Text = "第：";
            // 
            // txtPage
            // 
            this.txtPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(40, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel3.Text = "页";
            // 
            // toolStripSeparator35
            // 
            this.toolStripSeparator35.Name = "toolStripSeparator35";
            this.toolStripSeparator35.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFind
            // 
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(52, 22);
            this.btnFind.Text = "查询";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form_WageChangeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 451);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_WageChangeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——工资调整列表";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_WageChangeList_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayChange)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPayChange;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator24;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator25;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator26;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator27;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator28;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator29;
        private System.Windows.Forms.ToolStripLabel lblCurPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator30;
        private System.Windows.Forms.ToolStripLabel lblTotalpage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator32;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator33;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator34;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtPage;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator35;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripButton toolbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}