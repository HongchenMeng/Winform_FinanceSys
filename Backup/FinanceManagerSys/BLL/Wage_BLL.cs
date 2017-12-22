using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;

namespace FinanceSys.FinanceManagerSys.BLL
{
    /// <summary>
    /// 业务逻辑类Stale_Wage 的摘要说明。
    /// </summary>
    public class Wage_BLL
    {
        private DAL.Wage_DAL dal = new FinanceSys.FinanceManagerSys.DAL.Wage_DAL();
        #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public int Exists(string empname)
		{
			return dal.Exists(empname);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Wage_Model model)
		{
			return dal.Add(model);
		}
         /// <summary>
        /// 获取分页总数
        /// </summary>
        public int WageCount()
        {
            return dal.WageCount();
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
		/// 更新一条数据
		/// </summary>
        public int Update(string name, decimal wage)
		{
            return dal.Update(name,wage);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int UpdateTic(string name, decimal money)
        {
            return dal.UpdateTic(name, money);
        }
         /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.Wage_Model model)
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
		public Model.Wage_Model GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Wage_Model GetModel(string name)
        {
            return dal.GetModel(name);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public int GetEmpBasicWage(string name)
        {

            return dal.GetEmpBasicWage(name);
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(string strWhere) {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public IList<FinanceManagerSys.Model.Wage_Model> GetListWage(string strWhere)
        {
            return dal.GetListWage(strWhere);
        }
        #endregion
    }
}
