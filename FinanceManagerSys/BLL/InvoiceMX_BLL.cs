using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;

namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_InvoiceMX 的摘要说明。
    /// </summary>
    public class InvoiceMX_BLL
    {
        public InvoiceMX_BLL()
		{}
        private DAL.InvoiceMX_DAL dal = new FinanceSys.FinanceManagerSys.DAL.InvoiceMX_DAL();
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.InvoiceMX_Model model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(Model.InvoiceMX_Model model)
		{
		return	dal.Update(model);
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
        public Model.InvoiceMX_Model GetModel(int ID)
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
		/// 获得前几行数据
		/// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        #endregion
    }
}
