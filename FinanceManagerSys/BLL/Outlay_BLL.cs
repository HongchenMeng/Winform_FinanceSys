using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;

namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_Outlay 的摘要说明。
    /// </summary>
    public class Outlay_BLL
    {
        private DAL.Outlay_DAL dal = new FinanceSys.FinanceManagerSys.DAL.Outlay_DAL();
        public Outlay_BLL()
		{}
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
		public int  Add(Model.Outlay_Model model)
		{
			return dal.Add(model);
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
        /// 获取分页总数
        /// </summary>
        public int OutlayCount()
        {
            return dal.OutlayCount();
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(Model.Outlay_Model model)
		{
            return dal.Update(model);
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
		public Model.Outlay_Model GetModel(int ID)
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
        /// 查询月份总支出金额
        /// </summary>
        /// <param name="time">参数 时间</param>
        /// <returns>返回泛型集合</returns>
        public int GetOutSys(DateTime time)
        {
            return dal.GetOutSys(time);
        }
        #endregion
    }
}
