using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FinanceSys.PublicLibrary.BLL
{
    public class CompanyInfo_BLL
    {
        private DAL.CompanyInfo_DAL DAL = new FinanceSys.PublicLibrary.DAL.CompanyInfo_DAL();
         /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            return DAL.GetList();
        }
    }
}
