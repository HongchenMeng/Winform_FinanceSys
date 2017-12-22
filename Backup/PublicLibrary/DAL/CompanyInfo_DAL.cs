using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FinanceSys.PublicLibrary.DAL
{
    public class CompanyInfo_DAL
    {
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name,LinkMan,Adress ");
            strSql.Append(" FROM Satle_CompanyInfo ");
           
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
    }
}
