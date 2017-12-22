using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FinanceSys.App_Code
{
    public class MyDataGridView:DataGridView
    {
        public MyDataGridView()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }
    }
}
