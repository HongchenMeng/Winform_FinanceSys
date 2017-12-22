using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace FinanceSys.App_Code
{
    public class Page
    {
        public static int curPage = 1;  //当前页
        public static int TotalPage = 0; //总页数
        public static int pageCount = 15; //每页显示条数
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
    }
}
