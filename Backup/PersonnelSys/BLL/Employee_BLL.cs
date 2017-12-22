using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.PersonnelSys.Model;
using System.Data;

namespace FinanceSys.PersonnelSys.BLL
{
    public class Employee_BLL
    {
        private DAL.Employee_DAL dal = new FinanceSys.PersonnelSys.DAL.Employee_DAL();
        #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string empname)
		{
            return dal.Exists(empname);
		}
        /// <summary>
        /// 更改状态标识
        /// </summary>
        /// <param name="id"></param>
        public void UpdateCode(int id)
        {
            dal.UpdateCode(id);
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.Employee_Model model)
		{
			return dal.Add(model);
		}
       
		/// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(Model.Employee_Model model)
		{
            return dal.Update(model);
		}
        /// <summary>
        /// 更改在职状态
        /// </summary>
        public int Update(int id,string status)
        {
            return dal.Update(id,status);
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
		public Model.Employee_Model GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string ziduan,string strWhere)
        {
            return dal.GetList(ziduan, strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList()
        {
            return dal.GetList();
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetListByOperation(string strWhere)
        {
            return dal.GetListByOperation(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetEmpByDepart(int depart)
        {
            return dal.GetEmpByDepart(depart);
        }
        #endregion
    }
}
