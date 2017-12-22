namespace FinanceSys.PersonnelSys
{
    partial class Form_PayMonth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PayMonth));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnmonth = new System.Windows.Forms.Button();
            this.dtppaymonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnmonth);
            this.groupBox1.Controls.Add(this.dtppaymonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "工资发放";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(316, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "撤销";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnmonth
            // 
            this.btnmonth.Image = global::FinanceSys.Properties.Resources.保存;
            this.btnmonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmonth.Location = new System.Drawing.Point(235, 12);
            this.btnmonth.Name = "btnmonth";
            this.btnmonth.Size = new System.Drawing.Size(75, 23);
            this.btnmonth.TabIndex = 2;
            this.btnmonth.Text = "确定";
            this.btnmonth.UseVisualStyleBackColor = true;
            this.btnmonth.Click += new System.EventHandler(this.btnmonth_Click);
            // 
            // dtppaymonth
            // 
            this.dtppaymonth.CustomFormat = "yyyy-MM";
            this.dtppaymonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtppaymonth.Location = new System.Drawing.Point(109, 13);
            this.dtppaymonth.Name = "dtppaymonth";
            this.dtppaymonth.Size = new System.Drawing.Size(108, 21);
            this.dtppaymonth.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择月份：";
            // 
            // Form_PayMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 77);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_PayMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "人事管理——选择工资发放月份";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmonth;
        private System.Windows.Forms.DateTimePicker dtppaymonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
    }
}