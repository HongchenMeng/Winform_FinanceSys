namespace FinanceSys.FinanceManagerSys
{
    partial class Form_InvoiceXX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_InvoiceXX));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInvoiceMX = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contracno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ltdname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demoname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.handling = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceMX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvInvoiceMX);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(935, 398);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发票明细";
            // 
            // dgvInvoiceMX
            // 
            this.dgvInvoiceMX.AllowUserToAddRows = false;
            this.dgvInvoiceMX.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInvoiceMX.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoiceMX.BackgroundColor = System.Drawing.Color.White;
            this.dgvInvoiceMX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceMX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.contracno,
            this.invoiceno,
            this.ltdname,
            this.demoname,
            this.money,
            this.payment,
            this.empid,
            this.addtime,
            this.handling,
            this.remark});
            this.dgvInvoiceMX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoiceMX.EnableHeadersVisualStyles = false;
            this.dgvInvoiceMX.Location = new System.Drawing.Point(3, 17);
            this.dgvInvoiceMX.Name = "dgvInvoiceMX";
            this.dgvInvoiceMX.ReadOnly = true;
            this.dgvInvoiceMX.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInvoiceMX.RowHeadersVisible = false;
            this.dgvInvoiceMX.RowTemplate.Height = 23;
            this.dgvInvoiceMX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceMX.Size = new System.Drawing.Size(929, 378);
            this.dgvInvoiceMX.TabIndex = 1;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "状态";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 80;
            // 
            // contracno
            // 
            this.contracno.DataPropertyName = "ContractNo";
            this.contracno.HeaderText = "合同编号";
            this.contracno.Name = "contracno";
            this.contracno.ReadOnly = true;
            this.contracno.Width = 80;
            // 
            // invoiceno
            // 
            this.invoiceno.DataPropertyName = "InvoiceNo";
            this.invoiceno.HeaderText = "发票编号";
            this.invoiceno.Name = "invoiceno";
            this.invoiceno.ReadOnly = true;
            // 
            // ltdname
            // 
            this.ltdname.DataPropertyName = "LTDName";
            this.ltdname.HeaderText = "公司名称";
            this.ltdname.Name = "ltdname";
            this.ltdname.ReadOnly = true;
            this.ltdname.Width = 80;
            // 
            // demoname
            // 
            this.demoname.DataPropertyName = "DemoName";
            this.demoname.HeaderText = "项目名称";
            this.demoname.Name = "demoname";
            this.demoname.ReadOnly = true;
            this.demoname.Width = 80;
            // 
            // money
            // 
            this.money.DataPropertyName = "Money";
            this.money.HeaderText = "金额";
            this.money.Name = "money";
            this.money.ReadOnly = true;
            this.money.Width = 80;
            // 
            // payment
            // 
            this.payment.DataPropertyName = "Payment";
            this.payment.HeaderText = "付款方式";
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            this.payment.Width = 80;
            // 
            // empid
            // 
            this.empid.DataPropertyName = "EmpID";
            this.empid.HeaderText = "业务员";
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 80;
            // 
            // addtime
            // 
            this.addtime.DataPropertyName = "invoicetime";
            this.addtime.HeaderText = "时间";
            this.addtime.Name = "addtime";
            this.addtime.ReadOnly = true;
            this.addtime.Width = 80;
            // 
            // handling
            // 
            this.handling.DataPropertyName = "Handling";
            this.handling.HeaderText = "操作员";
            this.handling.Name = "handling";
            this.handling.ReadOnly = true;
            this.handling.Width = 80;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "Remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 80;
            // 
            // Form_InvoiceXX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 402);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_InvoiceXX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "财务管理——发票详细列表";
            this.Load += new System.EventHandler(this.Form_InvoiceXX_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceMX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvInvoiceMX;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn contracno;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ltdname;
        private System.Windows.Forms.DataGridViewTextBoxColumn demoname;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn addtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn handling;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
    }
}