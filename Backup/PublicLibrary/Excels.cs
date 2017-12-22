using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using Microsoft.Office.Interop.Excel;

namespace FinanceSys.PublicLibrary
{
    public class Excels
    {
        /// <summary>   
        ///方法，导出DataGridView中的数据到Excel文件   
        /// </summary>   
        /// <remarks>  
        /// add com "Microsoft Excel 11.0 Object Library"  
        /// using Excel=Microsoft.Office.Interop.Excel;  
        /// using System.Reflection;  
        /// </remarks>  
        /// <param name= "dgv"> DataGridView </param>   
        /// 
        public static int DataGridViewToExcel(DataGridView dgv)
        {
            
            //int item=0;
            //申明保存对话框
            SaveFileDialog dlg = new SaveFileDialog();
            //默认文件后缀
            dlg.DefaultExt = "xlsx";
            //文件后缀列表
            dlg.Filter = "EXCEL文件(*.XLSX)|*.xlsx ";
            //默然路径是系统当前路径   
            dlg.InitialDirectory = Directory.GetCurrentDirectory();
            //打开保存对话框
            if (dlg.ShowDialog() == DialogResult.Cancel) return 0;
            //返回文件路径   
            string fileNameString = dlg.FileName;
            //验证strFileName是否为空或值无效   
            if (fileNameString.Trim() == " ")
            { return 0; }
            //定义表格内数据的行数和列数   
            int rowscount = dgv.Rows.Count;
            int colscount = dgv.Columns.Count;
            //行数必须大于0   
            if (rowscount <= 0)
            {
                MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            //列数必须大于0   
            if (colscount <= 0)
            {
                MessageBox.Show("没有数据可供保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            //行数不可以大于65536   
            if (rowscount > 65536)
            {
                MessageBox.Show("数据记录数太多(最多不能超过65536条)，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            //列数不可以大于255   
            if (colscount > 255)
            {
                MessageBox.Show("数据记录行数太多，不能保存 ", "提示 ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            //验证以fileNameString命名的文件是否存在，如果存在删除它   
            FileInfo file = new FileInfo(fileNameString);
            if (file.Exists)
            {
                try
                {
                    file.Delete();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "删除失败 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return 0;
                }
            }

            Microsoft.Office.Interop.Excel.Application objExcel = null;
            Microsoft.Office.Interop.Excel.Workbook objWorkbook = null;
            Microsoft.Office.Interop.Excel.Worksheet objsheet = null;

            try
            {
                //申明对象   
                objExcel = new Microsoft.Office.Interop.Excel.Application();
                objWorkbook = objExcel.Workbooks.Add(Missing.Value);
                objsheet = (Microsoft.Office.Interop.Excel.Worksheet)objWorkbook.ActiveSheet;
                //设置EXCEL不可见   
                objExcel.Visible = false;

                //向Excel中写入表格的表头   
                int displayColumnsCount = 1;
                for (int i = 0; i <= dgv.ColumnCount - 1; i++)
                {
                    if (dgv.Columns[i].Visible == true)
                    {
                        objExcel.Cells[1, displayColumnsCount] = dgv.Columns[i].HeaderText.Trim();
                        displayColumnsCount++;
                    }
                }
                //设置进度条   

                //progressBar1.Refresh();
                //progressBar1.Visible = true;
                //progressBar1.Minimum = 1;
                //progressBar1.Maximum = dgv.RowCount;
                //progressBar1.Step = 1;
                //向Excel中逐行逐列写入表格中的数据   
                for (int row = 0; row <= dgv.RowCount - 1; row++)
                {
                    //this.progressBar1.PerformStep();
                    //this.label2.Text = (this.progressBar1.Value / this.progressBar1.Maximum) + "%";

                    displayColumnsCount = 1;
                    for (int col = 0; col < colscount; col++)
                    {
                        if (dgv.Columns[col].Visible == true)
                        {
                            try
                            {
                                objExcel.Cells[row + 2, displayColumnsCount] = dgv.Rows[row].Cells[col].Value.ToString().Trim();
                                displayColumnsCount++;
                            }
                            catch (Exception)
                            {

                            }

                        }
                    }
                }

                //隐藏进度条   
                //tempProgressBar.Visible   =   false;   
                //保存文件   
                objWorkbook.SaveAs(fileNameString, Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlShared, Missing.Value, Missing.Value, Missing.Value,
                        Missing.Value, Missing.Value);
                return 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "警告 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            finally
            {
                //关闭Excel应用   
                if (objWorkbook != null) objWorkbook.Close(Missing.Value, Missing.Value, Missing.Value);
                if (objExcel.Workbooks != null) objExcel.Workbooks.Close();
                if (objExcel != null) objExcel.Quit();

                objsheet = null;
                objWorkbook = null;
                objExcel = null;
            }
        }

        /// <summary>
        /// 将数据导入Excel
        /// </summary>
        /// <param name="view"></param>
        public static void ToExel(DataGridView view)
        {
            if (view.Rows.Count == 0)
            {
                MessageBox.Show("表格中没有数据，不能导出空表", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //建立Excel对象
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            excel.Visible = true;
            //生成字段名称
            for (int i = 0; i < view.ColumnCount; i++)
            {

                excel.Cells[1, i + 1] = view.Columns[i].HeaderText;
            }
            //填充数据
            for (int row = 0; row <= view.RowCount - 1; row++)
            {
                for (int column = 0; column < view.ColumnCount; column++)
                {

                    if (view[column, row].ValueType == typeof(string))
                    {
                        excel.Cells[row + 2, column + 1] = "'" + view[column, row].Value.ToString();
                    }
                    else
                    {
                        excel.Cells[row + 2, column + 1] = view[column, row].Value.ToString();
                    }
                }
            }
        }

        /// <summary>
        /// 把DataGridView中的数据 导出到EXCEL         /// </summary>
        /// <param name="dg"></param>
        public static void Input_Excel(DataGridView dg)
        {
            Microsoft.Office.Interop.Excel._Worksheet Sht;
            Microsoft.Office.Interop.Excel._Workbook Bo;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Bo = excel.Application.Workbooks.Add(true);
            // excel.Visible = true;//excel是否显示
            Sht = (Microsoft.Office.Interop.Excel.Worksheet)Bo.Sheets[1];
            //写入数据到EXCEL
            int Rowed = 0;
            if (dg.AllowUserToAddRows == true)
            {
                for (int i = 0; i < dg.Rows.Count - 1; i++)
                {
                    for (int y = 1; y <= dg.ColumnCount; y++)
                    {
                        excel.Cells[1, y] = dg.Columns[y - 1].HeaderText;
                    }
                    Rowed++;
                    if (Rowed < 65000)
                    {
                        for (int lie = 0; lie < dg.ColumnCount; lie++)
                        {
                            excel.Cells[Rowed + 1, lie + 1] = Convert.ToString(dg[lie, i].Value);
                        }
                    }
                    else
                    {
                        Sht = (Microsoft.Office.Interop.Excel.Worksheet)Bo.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        Rowed = 0;
                        i--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < dg.Rows.Count - 1; i++)
                {
                    for (int y = 1; y <= dg.ColumnCount; y++)
                    {
                        excel.Cells[1, y] = dg.Columns[y - 1].HeaderText;
                    }
                    Rowed++;
                    if (Rowed < 65000)
                    {
                        for (int lie = 0; lie < dg.ColumnCount; lie++)
                        {
                            excel.Cells[Rowed + 1, lie + 1] = Convert.ToString(dg[lie, i].Value);
                        }
                    }
                    else
                    {
                        Sht = (Microsoft.Office.Interop.Excel.Worksheet)Bo.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                        Rowed = 0;
                        i--;
                    }
                }
                
            }
            excel.Visible = true;
        }

    }
}
