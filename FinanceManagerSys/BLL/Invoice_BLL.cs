using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;

namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_Invoice 的摘要说明。
    /// </summary>
    public class Invoice_BLL
    {
        private DAL.Invoice_DAL dal = new FinanceSys.FinanceManagerSys.DAL.Invoice_DAL();
        public Invoice_BLL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(string invoiceno)
		{
            return dal.Exists(invoiceno);
		}
        public void UpdateInvoice(decimal money, string state, int id)
        {
            dal.UpdateInvoice(money, state, id);
        }
        public void UpdateState(string state)
        {
            dal.UpdateState(state);
        }
          /// <summary>
        /// 获取发票总金额
        /// </summary>
        /// <returns></returns>
        public int GetCountM()
        {
            return dal.GetCountM();
        }
        /// <summary>
        /// 查询发票表中是否有合同编号
        /// 有：插入发票明细表
        /// 没：插入发票表
        /// </summary>
        /// <param name="contractno"></param>
        /// <returns></returns>
        public int ExistsContract(string contractno)
        {
            return dal.ExistsContract(contractno);
        }
           /// <summary>
        /// 获取分页总数
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            return dal.GetCount();
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Invoice_Model model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(Model.Invoice_Model model)
		{
		return	dal.Update(model);
		}
         /// <summary>
        /// 得到资产信息(分页)
        /// </summary>
        /// <param name="start">起始页</param>
        /// <param name="max">最大条数</param>
        /// <returns></returns>
        public DataTable getInvoiceList(int start, int max)
        {
            return dal.getInvoiceList(start, max);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
        public int Delete(int ID)
		{
			
		return	dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Invoice_Model GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		// <summary>
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
        /// 查询每页显示的数量
        /// 参数：当前页
        /// </summary>
        /// <param name="pagenum"></param>
        /// <returns></returns>
        public DataTable GetInvoiceIList(int pagenum)
        {
            return dal.GetInvoiceIList(pagenum);
        }
         /// <summary>
        /// 得到信息的总页数
        /// </summary>
        /// <returns></returns>
        public int getTotalPage()
        {
            return dal.getTotalPage();
        }
         /// <summary>
        /// 查询项目金额
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int GetInvoiceMoneyByContractNo(string contract)
        {
            return dal.GetInvoiceMoneyByContractNo(contract);
        }
         /// <summary>
        /// 查询公司名称
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public string GetInvoiceLtdName(string contract)
        {
            return dal.GetInvoiceLtdName(contract);
        }
        /// <summary>
        /// 查询公司信息
        /// </summary>
        /// <param name="ltdname"></param>
        /// <returns></returns>
        public Model.Invoice_Model GetInvoiceInfoByLtdName(int id)
        {
            return dal.GetInvoiceInfoByLtdName(id);
        }
        /// <summary>
        /// 查询ID编号是否存在
        /// 如果存在已开过发票
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool GetIsCount(int id)
        {
            return dal.GetIsCount(id);
        }
        #endregion
    }

}
