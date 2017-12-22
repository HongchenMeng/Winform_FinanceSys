using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;
namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_Salary 的摘要说明。
    /// </summary>
    public class Salary_BLL
    {
        private FinanceManagerSys.DAL.Salary_DAL dal = new FinanceSys.FinanceManagerSys.DAL.Salary_DAL();
        public Salary_BLL()
		{}
		#region  成员方法
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Salary_Model model)
		{
			return dal.Add(model);
		}
         /// <summary>
        /// 获取分页总数
        /// </summary>
        public int SalaryCount()
        {
            return dal.SalaryCount();
        }
         /// <summary>
        /// 分页
        /// </summary>
        /// <param name="start">起始页</param>
        /// <param name="max">最大条数</param>
        /// <returns></returns>
        public DataTable GetList(int start, int max)
        {
            return dal.GetList(start, max);
        }
         /// <summary>
        /// 查询每页显示的数量
        /// 参数：当前页
        /// </summary>
        /// <param name="pagenum"></param>
        /// <returns></returns>
        public DataTable GetIList(int pagenum)
        {
            return dal.GetIList(pagenum);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataTable GetList(string strWhere)
		{
			return dal.GetList(strWhere);
        }
        #endregion
    }
}
