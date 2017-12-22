using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;

namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_Income 的摘要说明。
    /// </summary>
    public class Income_BLL
    {
        private DAL.Income_DAL dal = new FinanceSys.FinanceManagerSys.DAL.Income_DAL();
        #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}
         /// <summary>
        /// 获取分页总数
        /// </summary>
        public int IncomeCount()
        {
            return dal.IncomeCount();
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
        /// 查询月份收入金额(合同方式)
        /// </summary>
        /// <returns></returns>
        public int GetSys(DateTime time)
        {
            return dal.GetSys(time);
        }
        /// <summary>
        /// 查询月份收入总金额
        /// </summary>
        /// <returns></returns>
        public int GetIncomeCount(DateTime time)
        {
            return dal.GetIncomeCount(time);
        }
        /// <summary>
        /// 查询回款总金额
        /// </summary>
        /// <returns></returns>
        public int GetBreakCount()
        {
            return dal.GetBreakCount();
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Income_Model model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Income_Model model)
		{
            return dal.Update(model);
		}
          /// <summary>
        /// 获取收入总金额
        /// </summary>
        /// <returns></returns>
        public int GetCountM()
        {
            return dal.GetCountM();
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int Update(string contract, decimal money)
        {
            return dal.Update(contract, money);
        }
        /// <summary>
        /// 改变回款状态
        /// </summary>
        /// <param name="contractid"></param>
        /// <returns></returns>
        public bool UpdateState(string state, int contractid)
        {
            if (dal.UpdateState(state, contractid) == 1)
            {
                return true;
            }
            else { return false; }
        }
          /// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(int id, decimal breakM)
        {
            return dal.Update(id, breakM);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{

            return dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public  Model.Income_Model GetModel(int ID)
		{
			
			return dal.GetModel(ID);
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
         /// <summary>
        /// 修改收入表中的
        /// 发票金额
        /// 以及是否回款
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int UpIncomeMon(string contract, decimal money, string isbank)
        {
            return dal.UpIncomeMon(contract, money, isbank);
        }
        #endregion
    }
}
