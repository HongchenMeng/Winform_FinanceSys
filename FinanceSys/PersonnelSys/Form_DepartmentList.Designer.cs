namespace FinanceSys.PersonnelSys
{
    partial class Form_DepartmentList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DepartmentList));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tvwDepart = new System.Windows.Forms.TreeView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancels = new System.Windows.Forms.Button();
            this.tvwDeparts = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnCloses = new System.Windows.Forms.Button();
            this.btnUpdates = new System.Windows.Forms.Button();
            this.btnnAddNode = new System.Windows.Forms.Button();
            this.btnSaves = new System.Windows.Forms.Button();
            this.btnDels = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.tvwDepart);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(217, 78);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消添加/修改";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tvwDepart
            // 
            this.tvwDepart.Location = new System.Drawing.Point(20, 27);
            this.tvwDepart.Name = "tvwDepart";
            this.tvwDepart.Size = new System.Drawing.Size(178, 247);
            this.tvwDepart.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(217, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(217, 195);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "修改部门";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(217, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "添加部门";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(217, 117);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存设置";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(217, 156);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 25);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除部门";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancels);
            this.groupBox2.Controls.Add(this.tvwDeparts);
            this.groupBox2.Controls.Add(this.btnCloses);
            this.groupBox2.Controls.Add(this.btnUpdates);
            this.groupBox2.Controls.Add(this.btnnAddNode);
            this.groupBox2.Controls.Add(this.btnSaves);
            this.groupBox2.Controls.Add(this.btnDels);
            this.groupBox2.Location = new System.Drawing.Point(14, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 300);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "部门信息";
            // 
            // btnCancels
            // 
            this.btnCancels.Location = new System.Drawing.Point(217, 78);
            this.btnCancels.Name = "btnCancels";
            this.btnCancels.Size = new System.Drawing.Size(100, 25);
            this.btnCancels.TabIndex = 1;
            this.btnCancels.Text = "取消添加/修改";
            this.btnCancels.UseVisualStyleBackColor = true;
            this.btnCancels.Click += new System.EventHandler(this.btnCancels_Click);
            // 
            // tvwDeparts
            // 
            this.tvwDeparts.ContextMenuStrip = this.contextMenuStrip1;
            this.tvwDeparts.ImageIndex = 0;
            this.tvwDeparts.ImageList = this.imageList1;
            this.tvwDeparts.Location = new System.Drawing.Point(20, 27);
            this.tvwDeparts.Name = "tvwDeparts";
            this.tvwDeparts.SelectedImageIndex = 0;
            this.tvwDeparts.Size = new System.Drawing.Size(178, 247);
            this.tvwDeparts.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001.bmp");
            this.imageList1.Images.SetKeyName(1, "004.bmp");
            // 
            // btnCloses
            // 
            this.btnCloses.Location = new System.Drawing.Point(215, 234);
            this.btnCloses.Name = "btnCloses";
            this.btnCloses.Size = new System.Drawing.Size(100, 25);
            this.btnCloses.TabIndex = 5;
            this.btnCloses.Text = "关闭窗口";
            this.btnCloses.UseVisualStyleBackColor = true;
            this.btnCloses.Click += new System.EventHandler(this.btnCloses_Click);
            // 
            // btnUpdates
            // 
            this.btnUpdates.Location = new System.Drawing.Point(215, 195);
            this.btnUpdates.Name = "btnUpdates";
            this.btnUpdates.Size = new System.Drawing.Size(100, 25);
            this.btnUpdates.TabIndex = 4;
            this.btnUpdates.Text = "修改部门";
            this.btnUpdates.UseVisualStyleBackColor = true;
            this.btnUpdates.Click += new System.EventHandler(this.btnUpdates_Click);
            // 
            // btnnAddNode
            // 
            this.btnnAddNode.Location = new System.Drawing.Point(217, 39);
            this.btnnAddNode.Name = "btnnAddNode";
            this.btnnAddNode.Size = new System.Drawing.Size(100, 25);
            this.btnnAddNode.TabIndex = 0;
            this.btnnAddNode.Text = "添加部门";
            this.btnnAddNode.UseVisualStyleBackColor = true;
            this.btnnAddNode.Click += new System.EventHandler(this.btnnAddNode_Click);
            // 
            // btnSaves
            // 
            this.btnSaves.Enabled = false;
            this.btnSaves.Location = new System.Drawing.Point(217, 117);
            this.btnSaves.Name = "btnSaves";
            this.btnSaves.Size = new System.Drawing.Size(100, 25);
            this.btnSaves.TabIndex = 2;
            this.btnSaves.Text = "保存设置";
            this.btnSaves.UseVisualStyleBackColor = true;
            this.btnSaves.Click += new System.EventHandler(this.btnSaves_Click);
            // 
            // btnDels
            // 
            this.btnDels.Location = new System.Drawing.Point(217, 156);
            this.btnDels.Name = "btnDels";
            this.btnDels.Size = new System.Drawing.Size(100, 25);
            this.btnDels.TabIndex = 3;
            this.btnDels.Text = "删除部门";
            this.btnDels.UseVisualStyleBackColor = true;
            this.btnDels.Click += new System.EventHandler(this.btnDels_Click);
            // 
            // Form_DepartmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 344);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_DepartmentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "人事管理——部门管理";
            this.Load += new System.EventHandler(this.Form_DepartmentList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TreeView tvwDepart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancels;
        private System.Windows.Forms.TreeView tvwDeparts;
        private System.Windows.Forms.Button btnCloses;
        private System.Windows.Forms.Button btnUpdates;
        private System.Windows.Forms.Button btnnAddNode;
        private System.Windows.Forms.Button btnSaves;
        private System.Windows.Forms.Button btnDels;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}