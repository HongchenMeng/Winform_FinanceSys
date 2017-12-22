using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FinanceSys.PublicLibrary.BLL;

namespace FinanceSys.PersonnelSys
{
    public partial class Form_Syslog : Form
    {
        public Form_Syslog()
        {
            InitializeComponent();
        }

        private void Form_Syslog_Load(object sender, EventArgs e)
        {
            PublicLibrary.BLL.Log_BLL logbll = new Log_BLL();
            dgvLoginlog.DataSource = logbll.GetList();
            
        }
    }
}
