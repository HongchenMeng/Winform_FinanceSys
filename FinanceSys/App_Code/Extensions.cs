using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
namespace FinanceSys.App_Code
{
    public static class Extensions
    {
        public static void SetDoubleBuffered(DataGridView dgv, bool b)
        {
            var dgvType = dgv.GetType();//得到当前实例
            var pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, b, null);
        }
    }
}
