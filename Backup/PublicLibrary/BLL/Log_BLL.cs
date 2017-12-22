using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using FinanceSys.PublicLibrary.DAL;

namespace FinanceSys.PublicLibrary.BLL
{
    public class Log_BLL
    {
        /// <summary>
		/// 增加一条数据
		/// </summary>
        public static int Add(DateTime time, string type, string person, string state, string computer, string sys,int Code)
        {
            return Log_DAL.Add(time, type, person, state, computer, sys, Code);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            return Log_DAL.GetList();
        }
       
    }
}
