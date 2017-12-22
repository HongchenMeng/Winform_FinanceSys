namespace FinanceSys.PersonnelSys
{
    partial class Form_Month
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Month));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtptime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbxiaqi = new System.Windows.Forms.RadioButton();
            this.rdbbenqi = new System.Windows.Forms.RadioButton();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtptime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbxiaqi);
            this.groupBox1.Controls.Add(this.rdbbenqi);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "会计期间";
            // 
            // dtptime
            // 
            this.dtptime.CustomFormat = "yyyy-MM";
            this.dtptime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptime.Location = new System.Drawing.Point(205, 20);
            this.dtptime.Name = "dtptime";
            this.dtptime.Size = new System.Drawing.Size(83, 21);
            this.dtptime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "本期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "下期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择日期";
            // 
            // rdbxiaqi
            // 
            this.rdbxiaqi.AutoSize = true;
            this.rdbxiaqi.Location = new System.Drawing.Point(118, 24);
            this.rdbxiaqi.Name = "rdbxiaqi";
            this.rdbxiaqi.Size = new System.Drawing.Size(14, 13);
            this.rdbxiaqi.TabIndex = 2;
            this.rdbxiaqi.TabStop = true;
            this.rdbxiaqi.UseVisualStyleBackColor = true;
            // 
            // rdbbenqi
            // 
            this.rdbbenqi.AutoSize = true;
            this.rdbbenqi.Checked = true;
            this.rdbbenqi.Location = new System.Drawing.Point(51, 23);
            this.rdbbenqi.Name = "rdbbenqi";
            this.rdbbenqi.Size = new System.Drawing.Size(14, 13);
            this.rdbbenqi.TabIndex = 1;
            this.rdbbenqi.TabStop = true;
            this.rdbbenqi.UseVisualStyleBackColor = true;
            // 
            // btnok
            // 
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnok.Location = new System.Drawing.Point(342, 12);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 6;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancel
            // 
            this.btncancel.Image = ((System.Drawing.Image)(resources.GetObject("btncancel.Image")));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(342, 41);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 7;
            this.btncancel.Text = "取消";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Form_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 79);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Month";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "人事管理——工资数据录入";
            this.Load += new System.EventHandler(this.Form_Month_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtptime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbxiaqi;
        private System.Windows.Forms.RadioButton rdbbenqi;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancel;
    }
}