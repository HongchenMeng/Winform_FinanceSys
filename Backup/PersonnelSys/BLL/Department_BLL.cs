using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.PersonnelSys.Model;
using System.Data;

namespace FinanceSys.PersonnelSys.BLL
{
    public class Department_BLL
    {
        private DAL.Department_DAL dals = new FinanceSys.PersonnelSys.DAL.Department_DAL();
        #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dals.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(string depart)
		{
            return dals.Add(depart);
		}
/// <summary>
       /// 查询部门ID
       /// </summary>
       /// <param name="departname"></param>
       /// <returns></returns>
        public int GetDepartID(string departname)
        {
            return dals.GetDepartID(departname);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Department_Model model)
		{
			return dals.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			return dals.Delete(ID);
		}
         /// <summary>
        /// 修改部门名称
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Update(string name, int id)
        {
            return dals.Update(name, id);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Department_Model GetModel(int ID)
		{
			
			return dals.GetModel(ID);
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(string strWhere)
        {
            return dals.GetList(strWhere);
        }
        #endregion
    }
}
