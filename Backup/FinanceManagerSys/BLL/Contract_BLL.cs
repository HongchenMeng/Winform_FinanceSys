using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model = FinanceSys.FinanceManagerSys.Model;

namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_Contract 的摘要说明。
    /// </summary>
    public class Contract_BLL
    {
        private FinanceManagerSys.DAL.Contract_DAL dal = new FinanceSys.FinanceManagerSys.DAL.Contract_DAL();
        public Contract_BLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ContractID)
		{
			return dal.Exists(ContractID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Contract_Model model)
		{
			return dal.Add(model);
		}
          /// <summary>
        /// 获取分页总数
        /// </summary>
        public int ContractCount()
        {
            return dal.ContractCount();
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="start">起始页</param>
        /// <param name="max">最大条数</param>
        /// <returns></returns>
        public  DataTable GetList(int start, int max)
        {
            return dal.GetList(start, max);
        }
         /// <summary>
        /// 获得数据列表
        /// 根据合同编号
        /// </summary>
        public DataTable GetListByContract(string strWhere)
        {
            return dal.GetListByContract(strWhere);
        }
         /// <summary>
        /// 获得数据列表
        /// 根据甲方名称
        /// </summary>
        public DataTable GetListByParty(string strWhere)
        {
            return dal.GetListByParty(strWhere);
        }
         /// <summary>
        /// 获得数据列表
        /// 根据乙方名称
        /// </summary>
        public DataTable GetListByB(string strWhere)
        {
            return dal.GetListByB(strWhere);
        }
         /// <summary>
        /// 获得数据列表
        /// 根据项目名称
        /// </summary>
        public DataTable GetListByDemoName(string strWhere)
        {
            return dal.GetListByDemoName(strWhere);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(Model.Contract_Model model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
        public int Delete(int ContractID)
        {
            return dal.Delete(ContractID);
        }

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Contract_Model GetModel(int ContractID)
		{
			
			return dal.GetModel(ContractID);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataTable GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
         /// <summary>
        /// 根据合同编号查询出此
        /// 合同的合同金额
        /// </summary>
        /// <param name="contractno"></param>
        /// <returns></returns>
        public decimal GetContractMoney(string contractno)
        {
            return dal.GetContractMoney(contractno);
        }
        #endregion 
    }
}
