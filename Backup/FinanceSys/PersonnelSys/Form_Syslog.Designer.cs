namespace FinanceSys.PersonnelSys
{
    partial class Form_Syslog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Syslog));
            this.dgvLoginlog = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginlog)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoginlog
            // 
            this.dgvLoginlog.AllowUserToAddRows = false;
            this.dgvLoginlog.AllowUserToDeleteRows = false;
            this.dgvLoginlog.AllowUserToOrderColumns = true;
            this.dgvLoginlog.AllowUserToResizeRows = false;
            this.dgvLoginlog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoginlog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoginlog.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLoginlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoginlog.Location = new System.Drawing.Point(0, 0);
            this.dgvLoginlog.Name = "dgvLoginlog";
            this.dgvLoginlog.ReadOnly = true;
            this.dgvLoginlog.RowHeadersVisible = false;
            this.dgvLoginlog.RowTemplate.Height = 23;
            this.dgvLoginlog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoginlog.Size = new System.Drawing.Size(684, 408);
            this.dgvLoginlog.TabIndex = 0;
            this.dgvLoginlog.TabStop = false;
            // 
            // Form_Syslog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 408);
            this.Controls.Add(this.dgvLoginlog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Syslog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统管理——系统日志";
            this.Load += new System.EventHandler(this.Form_Syslog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginlog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoginlog;
    }
}