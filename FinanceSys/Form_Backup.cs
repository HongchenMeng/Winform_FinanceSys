using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FinanceSys
{
    public partial class Form_Backup : Form
    {
        public Form_Backup()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
           
            backgroundWorker1.RunWorkerAsync();//5+1+a+s+p+x
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
        }

        private void Form_Backup_Load(object sender, EventArgs e)
        {
         
        }
    }
}
