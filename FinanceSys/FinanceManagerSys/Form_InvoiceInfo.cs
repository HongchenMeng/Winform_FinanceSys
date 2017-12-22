using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace FinanceSys.FinanceManagerSys
{
    public partial class Form_InvoiceInfo : Form
    {
        public string canshu = string.Empty;
        
        private static FinanceManagerSys.BLL.Invoice_BLL bll = new FinanceSys.FinanceManagerSys.BLL.Invoice_BLL();
        private static FinanceManagerSys.Model.Invoice_Model model = new FinanceSys.FinanceManagerSys.Model.Invoice_Model();
        public Form_InvoiceInfo()
        {
            InitializeComponent();
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInvoiceInfo()
        {            
            if (App_Code.Canshu.Id != 0 && App_Code.Canshu.Id != -1)
            {
                model = bll.GetInvoiceInfoByLtdName(App_Code.Canshu.Id);
                lblLtdName.Text = model.LTDName;
                lblInvoiceTime.Text = model.Invoicetime.ToString();
                lblInvoiceMoney.Text = model.Money.ToString();
                lblDemoName.Text = model.DemoName;
                lblRemark.Text = model.Remark;
                lblState.Text = model.Status;
            }
        }

        private void Form_InvoiceInfo_Load(object sender, EventArgs e)
        {
            this.ShowInvoiceInfo();
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 2;
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll")]
        private static extern int ReleaseCapture();

        private void Form_InvoiceInfo_MouseMove(object sender, MouseEventArgs e)
        {
            //为当前的应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息，让系统误以为你在标题拦上按下鼠标
            SendMessage((int)this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void Form_InvoiceInfo_Resize(object sender, EventArgs e)
        {
            Type(this, 25, 0.1);
        }

        private void Type(Control sender, int p_1, double p_2)
        {
            GraphicsPath oPath = new GraphicsPath();

            oPath.AddClosedCurve(new Point[] { new Point(0, sender.Height / p_1), new Point(sender.Width / p_1, 0), new Point(sender.Width - sender.Width / p_1, 0), new Point(sender.Width, sender.Height / p_1), new Point(sender.Width, sender.Height - sender.Height / p_1), new Point(sender.Width - sender.Width / p_1, sender.Height), new Point(sender.Width / p_1, sender.Height), new Point(0, sender.Height - sender.Height / p_1) }, (float)p_2);
            sender.Region = new Region(oPath);
        }

        private void Form_InvoiceInfo_Paint(object sender, PaintEventArgs e)
        {
            Type(this, 25, 0.1);
        }
    }
}
