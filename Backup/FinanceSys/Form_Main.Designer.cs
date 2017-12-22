namespace FinanceSys
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Eq_ReturnLook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Sys_AppRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Emp_depart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.meun_emp_emp = new System.Windows.Forms.ToolStripMenuItem();
            this.财务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Eq_Return = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Eq_Boroow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Eq_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Tool_Notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_Tool_Calc = new System.Windows.Forms.ToolStripMenuItem();
            this.statusInfo = new System.Windows.Forms.StatusStrip();
            this.stalUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.stalTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.stalConpany = new System.Windows.Forms.ToolStripStatusLabel();
            this.stalAddress = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sideBar1 = new Aptech.UI.SideBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsOper = new System.Windows.Forms.ToolStrip();
            this.tsbtnForegrounding = new System.Windows.Forms.ToolStripButton();
            this.tsmiBookManage = new System.Windows.Forms.ToolStripButton();
            this.tsmiCashierManage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.statusInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tsOper.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.财务管理ToolStripMenuItem,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改密码ToolStripMenuItem,
            this.toolStripSeparator1,
            this.Menu_Eq_ReturnLook,
            this.toolStripSeparator2,
            this.Menu_Sys_AppRestart,
            this.Menu_Exit_Exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.文件ToolStripMenuItem.Text = "系统管理(&S)";
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Image = global::FinanceSys.Properties.Resources.Key1;
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // Menu_Eq_ReturnLook
            // 
            this.Menu_Eq_ReturnLook.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Eq_ReturnLook.Image")));
            this.Menu_Eq_ReturnLook.Name = "Menu_Eq_ReturnLook";
            this.Menu_Eq_ReturnLook.Size = new System.Drawing.Size(152, 22);
            this.Menu_Eq_ReturnLook.Text = "操作日志";
            this.Menu_Eq_ReturnLook.Click += new System.EventHandler(this.Menu_Eq_ReturnLook_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // Menu_Sys_AppRestart
            // 
            this.Menu_Sys_AppRestart.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Sys_AppRestart.Image")));
            this.Menu_Sys_AppRestart.Name = "Menu_Sys_AppRestart";
            this.Menu_Sys_AppRestart.Size = new System.Drawing.Size(152, 22);
            this.Menu_Sys_AppRestart.Text = "系统注销";
            this.Menu_Sys_AppRestart.Click += new System.EventHandler(this.Menu_Sys_AppRestart_Click);
            // 
            // Menu_Exit_Exit
            // 
            this.Menu_Exit_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Exit_Exit.Image")));
            this.Menu_Exit_Exit.Name = "Menu_Exit_Exit";
            this.Menu_Exit_Exit.Size = new System.Drawing.Size(152, 22);
            this.Menu_Exit_Exit.Text = "系统退出";
            this.Menu_Exit_Exit.Click += new System.EventHandler(this.Menu_Exit_Exit_Click);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Emp_depart,
            this.toolStripSeparator3,
            this.meun_emp_emp});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.人事管理ToolStripMenuItem.Text = "人事管理(&P)";
            // 
            // menu_Emp_depart
            // 
            this.menu_Emp_depart.Image = ((System.Drawing.Image)(resources.GetObject("menu_Emp_depart.Image")));
            this.menu_Emp_depart.Name = "menu_Emp_depart";
            this.menu_Emp_depart.Size = new System.Drawing.Size(152, 22);
            this.menu_Emp_depart.Text = "部门";
            this.menu_Emp_depart.Click += new System.EventHandler(this.menu_Emp_depart_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // meun_emp_emp
            // 
            this.meun_emp_emp.Image = ((System.Drawing.Image)(resources.GetObject("meun_emp_emp.Image")));
            this.meun_emp_emp.Name = "meun_emp_emp";
            this.meun_emp_emp.Size = new System.Drawing.Size(152, 22);
            this.meun_emp_emp.Text = "员工管理";
            this.meun_emp_emp.Click += new System.EventHandler(this.meun_emp_emp_Click);
            // 
            // 财务管理ToolStripMenuItem
            // 
            this.财务管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Eq_Return,
            this.toolStripSeparator5,
            this.Menu_Eq_Boroow,
            this.toolStripSeparator6,
            this.Menu_Eq_Add});
            this.财务管理ToolStripMenuItem.Name = "财务管理ToolStripMenuItem";
            this.财务管理ToolStripMenuItem.Size = new System.Drawing.Size(82, 21);
            this.财务管理ToolStripMenuItem.Text = "财务管理(&F)";
            // 
            // Menu_Eq_Return
            // 
            this.Menu_Eq_Return.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Eq_Return.Image")));
            this.Menu_Eq_Return.Name = "Menu_Eq_Return";
            this.Menu_Eq_Return.Size = new System.Drawing.Size(124, 22);
            this.Menu_Eq_Return.Text = "工资管理";
            this.Menu_Eq_Return.Click += new System.EventHandler(this.Menu_Eq_Return_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(121, 6);
            // 
            // Menu_Eq_Boroow
            // 
            this.Menu_Eq_Boroow.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Eq_Boroow.Image")));
            this.Menu_Eq_Boroow.Name = "Menu_Eq_Boroow";
            this.Menu_Eq_Boroow.Size = new System.Drawing.Size(124, 22);
            this.Menu_Eq_Boroow.Text = "支出管理";
            this.Menu_Eq_Boroow.Click += new System.EventHandler(this.Menu_Eq_Boroow_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(121, 6);
            // 
            // Menu_Eq_Add
            // 
            this.Menu_Eq_Add.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Eq_Add.Image")));
            this.Menu_Eq_Add.Name = "Menu_Eq_Add";
            this.Menu_Eq_Add.Size = new System.Drawing.Size(124, 22);
            this.Menu_Eq_Add.Text = "收入管理";
            this.Menu_Eq_Add.Click += new System.EventHandler(this.Menu_Eq_Add_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Tool_Notepad,
            this.toolStripSeparator4,
            this.Menu_Tool_Calc});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // Menu_Tool_Notepad
            // 
            this.Menu_Tool_Notepad.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Tool_Notepad.Image")));
            this.Menu_Tool_Notepad.Name = "Menu_Tool_Notepad";
            this.Menu_Tool_Notepad.Size = new System.Drawing.Size(112, 22);
            this.Menu_Tool_Notepad.Text = "记事本";
            this.Menu_Tool_Notepad.Click += new System.EventHandler(this.Menu_Tool_Notepad_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(109, 6);
            // 
            // Menu_Tool_Calc
            // 
            this.Menu_Tool_Calc.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Tool_Calc.Image")));
            this.Menu_Tool_Calc.Name = "Menu_Tool_Calc";
            this.Menu_Tool_Calc.Size = new System.Drawing.Size(112, 22);
            this.Menu_Tool_Calc.Text = "计算器";
            this.Menu_Tool_Calc.Click += new System.EventHandler(this.Menu_Tool_Calc_Click);
            // 
            // statusInfo
            // 
            this.statusInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stalUser,
            this.stalTime,
            this.stalConpany,
            this.stalAddress});
            this.statusInfo.Location = new System.Drawing.Point(0, 706);
            this.statusInfo.Name = "statusInfo";
            this.statusInfo.Size = new System.Drawing.Size(1018, 22);
            this.statusInfo.TabIndex = 1;
            this.statusInfo.Text = "statusStrip1";
            // 
            // stalUser
            // 
            this.stalUser.AutoSize = false;
            this.stalUser.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stalUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stalUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stalUser.Name = "stalUser";
            this.stalUser.Size = new System.Drawing.Size(177, 17);
            this.stalUser.Text = "                            ";
            // 
            // stalTime
            // 
            this.stalTime.AutoSize = false;
            this.stalTime.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stalTime.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stalTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stalTime.Name = "stalTime";
            this.stalTime.Size = new System.Drawing.Size(190, 17);
            // 
            // stalConpany
            // 
            this.stalConpany.AutoSize = false;
            this.stalConpany.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stalConpany.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stalConpany.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stalConpany.Name = "stalConpany";
            this.stalConpany.Size = new System.Drawing.Size(200, 17);
            this.stalConpany.Text = "公司名称";
            // 
            // stalAddress
            // 
            this.stalAddress.AutoSize = false;
            this.stalAddress.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stalAddress.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stalAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stalAddress.Name = "stalAddress";
            this.stalAddress.Size = new System.Drawing.Size(436, 17);
            this.stalAddress.Spring = true;
            this.stalAddress.Text = "公司地址";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "button18.Image.gif");
            this.imageList1.Images.SetKeyName(1, "button48.Image.gif");
            this.imageList1.Images.SetKeyName(2, "button44.Image.gif");
            this.imageList1.Images.SetKeyName(3, "user-remove.png");
            this.imageList1.Images.SetKeyName(4, "button37.Image.gif");
            this.imageList1.Images.SetKeyName(5, "button29.Image.gif");
            this.imageList1.Images.SetKeyName(6, "table.png");
            this.imageList1.Images.SetKeyName(7, "button26.Image.gif");
            this.imageList1.Images.SetKeyName(8, "button25.Image.gif");
            this.imageList1.Images.SetKeyName(9, "button90.Image.gif");
            this.imageList1.Images.SetKeyName(10, "button124.Image.bmp");
            this.imageList1.Images.SetKeyName(11, "button74.Image.gif");
            this.imageList1.Images.SetKeyName(12, "button18.Image.gif");
            this.imageList1.Images.SetKeyName(13, "button19.Image.gif");
            this.imageList1.Images.SetKeyName(14, "button17.Image.gif");
            this.imageList1.Images.SetKeyName(15, "button113.Image.gif");
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // sideBar1
            // 
            this.sideBar1.AllowDragItem = false;
            this.sideBar1.BackColor = System.Drawing.Color.Gray;
            this.sideBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideBar1.FlatStyle = Aptech.UI.SbFlatStyle.Normal;
            this.sideBar1.GroupHeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
            this.sideBar1.GroupTextColor = System.Drawing.Color.Black;
            this.sideBar1.ImageList = this.imageList1;
            this.sideBar1.ItemContextMenuStrip = null;
            this.sideBar1.ItemStyle = Aptech.UI.SbItemStyle.PushButton;
            this.sideBar1.ItemTextColor = System.Drawing.Color.White;
            this.sideBar1.Location = new System.Drawing.Point(0, 0);
            this.sideBar1.Name = "sideBar1";
            this.sideBar1.RadioSelectedItem = null;
            this.sideBar1.Size = new System.Drawing.Size(170, 609);
            this.sideBar1.TabIndex = 4;
            this.sideBar1.View = Aptech.UI.SbView.LargeIcon;
            this.sideBar1.VisibleGroup = null;
            this.sideBar1.VisibleGroupIndex = -1;
            this.sideBar1.ItemClick += new Aptech.UI.SbItemEventHandler(this.sideBar1_ItemClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tsOper);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 681);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.sideBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 609);
            this.panel2.TabIndex = 4;
            // 
            // tsOper
            // 
            this.tsOper.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsOper.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnForegrounding,
            this.tsmiBookManage,
            this.tsmiCashierManage,
            this.toolStripButton2,
            this.toolStripButton1,
            this.tsbtnExit});
            this.tsOper.Location = new System.Drawing.Point(0, 0);
            this.tsOper.Name = "tsOper";
            this.tsOper.Size = new System.Drawing.Size(1018, 72);
            this.tsOper.TabIndex = 3;
            // 
            // tsbtnForegrounding
            // 
            this.tsbtnForegrounding.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnForegrounding.Image")));
            this.tsbtnForegrounding.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnForegrounding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnForegrounding.Name = "tsbtnForegrounding";
            this.tsbtnForegrounding.Size = new System.Drawing.Size(78, 69);
            this.tsbtnForegrounding.Text = "员工管理(&O)";
            this.tsbtnForegrounding.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnForegrounding.Click += new System.EventHandler(this.tsbtnForegrounding_Click);
            // 
            // tsmiBookManage
            // 
            this.tsmiBookManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookManage.Image")));
            this.tsmiBookManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiBookManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiBookManage.Name = "tsmiBookManage";
            this.tsmiBookManage.Size = new System.Drawing.Size(76, 69);
            this.tsmiBookManage.Text = "工资管理(&B)";
            this.tsmiBookManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiBookManage.Click += new System.EventHandler(this.tsmiBookManage_Click);
            // 
            // tsmiCashierManage
            // 
            this.tsmiCashierManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiCashierManage.Image")));
            this.tsmiCashierManage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiCashierManage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsmiCashierManage.Name = "tsmiCashierManage";
            this.tsmiCashierManage.Size = new System.Drawing.Size(73, 69);
            this.tsmiCashierManage.Text = "收入管理(&J)";
            this.tsmiCashierManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsmiCashierManage.Click += new System.EventHandler(this.tsmiCashierManage_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 69);
            this.toolStripButton1.Text = "计算器";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(55, 69);
            this.tsbtnExit.Text = "退 出(&E)";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(73, 69);
            this.toolStripButton2.Text = "支出管理(&J)";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1018, 728);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusInfo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "人事工资管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusInfo.ResumeLayout(false);
            this.statusInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tsOper.ResumeLayout(false);
            this.tsOper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 财务管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusInfo;
        private System.Windows.Forms.ToolStripStatusLabel stalUser;
        private System.Windows.Forms.ToolStripStatusLabel stalTime;
        private System.Windows.Forms.ToolStripStatusLabel stalConpany;
        private System.Windows.Forms.ToolStripStatusLabel stalAddress;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ImageList imageList1;
        private Aptech.UI.SideBar sideBar1;
        private System.Windows.Forms.ToolStripMenuItem menu_Emp_depart;
        private System.Windows.Forms.ToolStripMenuItem meun_emp_emp;
        private System.Windows.Forms.ToolStripMenuItem Menu_Sys_AppRestart;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool_Notepad;
        private System.Windows.Forms.ToolStripMenuItem Menu_Tool_Calc;
        private System.Windows.Forms.ToolStripMenuItem Menu_Eq_Add;
        private System.Windows.Forms.ToolStripMenuItem Menu_Eq_Boroow;
        private System.Windows.Forms.ToolStripMenuItem Menu_Eq_Return;
        private System.Windows.Forms.ToolStripMenuItem Menu_Eq_ReturnLook;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip tsOper;
        private System.Windows.Forms.ToolStripButton tsbtnForegrounding;
        private System.Windows.Forms.ToolStripButton tsmiBookManage;
        private System.Windows.Forms.ToolStripButton tsmiCashierManage;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}