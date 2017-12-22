using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.PublicLibrary.Model;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace FinanceSys.PublicLibrary.DAL
{
    public class Log_DAL
    {
        /// <summary>
		/// 增加一条数据
		/// </summary>
        public static int Add(DateTime time, string type, string person, string state, string computer, string sys,int code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Stale_Log(");
            strSql.Append("OperTime,Type,OperPerson,State,ComputerName,System,Code)");
            strSql.Append(" values (");
            strSql.Append("'" + time + "',");
            strSql.Append("'" + type + "',");
            strSql.Append("'" + person + "',");
            strSql.Append("'" + state + "',");
            strSql.Append("'" + computer + "',");
            strSql.Append("'" + sys + "',");
            strSql.Append("" + code + ")");
            strSql.Append(";select @@IDENTITY");


            return DbHelperSQL.ExecuteCommand(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public static DataTable GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select OperTime as '时间/日期',OperPerson as '用户名称',Type as '操作',State as '状态',ComputerName as '计算机名称',System as '操作系统'");
            strSql.Append(" FROM Stale_Log where Code != 1 order by id desc");           
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
       
    }
}
