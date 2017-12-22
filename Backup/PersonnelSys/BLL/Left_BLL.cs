using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FinanceSys.PersonnelSys.BLL
{
    public class Left_BLL
    {
        private static DAL.Left_DAL leftdal = new FinanceSys.PersonnelSys.DAL.Left_DAL();
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return leftdal.Exists(ID);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Left_Model model)
        {
            return leftdal.Add(model);
        }
        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int LeftCount()
        {
            return leftdal.LeftCount();
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="start">起始页</param>
        /// <param name="max">最大条数</param>
        /// <returns></returns>
        public DataTable GetList(int start, int max)
        {
            return leftdal.GetList(start, max);
        }
         /// <summary>
        /// 查询每页显示的数量
        /// 参数：当前页
        /// </summary>
        /// <param name="pagenum"></param>
        /// <returns></returns>
        public DataTable GetList(int pagenum)
        {
            return leftdal.GetList(pagenum);
        }
         /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.Left_Model model)
        {
            return leftdal.Update(model);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int ID)
        {
            return leftdal.Delete(ID);
        }
         /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Left_Model GetModel(int ID)
        {
            return leftdal.GetModel(ID);
        }
          /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetList(string ziduan,string strWhere)
        {
            return leftdal.GetList(ziduan,strWhere);
        }
         /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            return leftdal.GetList(Top, strWhere, filedOrder);
        }
        #endregion
    }
}
