using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.PublicLibrary
{
    public class Log
    {
        private static BLL.Log_BLL logbll = new FinanceSys.PublicLibrary.BLL.Log_BLL();
        /// <summary>
        /// 添加日志记录
        /// </summary>
        /// <param name="opertime"></param>
        /// <param name="type"></param>
        /// <param name="person"></param>
        /// <param name="state"></param>
        /// <param name="computername"></param>
        /// <param name="sys"></param>
        public static void InsertLog(DateTime opertime,string type,string person,string state,string computername,string sys)
        {
            Model.Log_Model logmodel = new FinanceSys.PublicLibrary.Model.Log_Model();
            logmodel.OperTime = opertime;
            logmodel.Type = type;
            logmodel.OperPerson = person;
            logmodel.State = state;
            logmodel.ComputerName = computername;
            logmodel.System = sys;

            logbll.Add(logmodel);
        }
    }
}
