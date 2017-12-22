using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace FinanceSys.App_Code
{
    public class Message
    {
        /// <summary>
        /// 消息对话框
        /// </summary>
        /// <param name="txt">文本</param>
        /// <param name="title">标题</param>
        public static void InfoMsg(string txt)
        {
            MessageBox.Show(txt, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// 错误对话框
        /// </summary>
        /// <param name="txt">文本</param>
        /// <param name="title">标题</param>
        public static void ErrorMsg(string txt)
        {

            MessageBox.Show(txt, " 错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        /// <summary>
        /// 问题对话框
        /// </summary>
        /// <param name="txt">文本</param>
        /// <param name="title">标题</param>
        public static bool QuestionMsg(string txt)
        {

            if (MessageBox.Show(txt, "确认请求", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 将datagridview中的数据导出到excel中 
        /// </summary>
        /// <param name="view">datagridview</param>
        public static void ToExel(DataGridView view)
        {
            //if (view.Rows.Count == 0)
            //{
            //    Message.InfoMsg("表格中没有数据，不能导出空表");
            //    return;
            //}

            ////建立Excel对象
            //Excel.Application excel = new Excel.Application();
            //excel.Application.Workbooks.Add(true);
            //excel.Visible = true;
            ////生成字段名称
            //for (int i = 0; i < view.ColumnCount; i++)
            //{

            //    excel.Cells[1, i + 1] = view.Columns[i].HeaderText;
            //}
            ////填充数据
            //for (int row = 0; row <= view.RowCount - 1; row++)
            //{
            //    for (int column = 0; column < view.ColumnCount; column++)
            //    {

            //        if (view[column, row].ValueType == typeof(string))
            //        {
            //            excel.Cells[row + 2, column + 1] = "'" + view[column, row].Value.ToString();
            //        }
            //        else
            //        {
            //            excel.Cells[row + 2, column + 1] = view[column, row].Value.ToString();
            //        }
            //    }
            //}
        }
    }
}
