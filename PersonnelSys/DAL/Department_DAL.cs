using System;
using System.Collections.Generic;
using System.Text;
using FinanceSys.PublicLibrary;
using Model = FinanceSys.PersonnelSys.Model;
using System.Data.SqlClient;
using System.Data;

//源码由51aspx发布
namespace FinanceSys.PersonnelSys.DAL
{
   public class Department_DAL
    {
       #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stale_Department");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			if(DbHelperSQL.GetScalar(strSql.ToString(),parameters)>0)return  true;else return false;
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(string depart)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Stale_Department(");
			strSql.Append("DepartName)");
			strSql.Append(" values (");
			strSql.Append("@DepartName)");
			strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartName", SqlDbType.NVarChar,50)};
			parameters[0].Value = depart;

			return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
			
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Department_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_Department set ");
			strSql.Append("DepartName=@DepartName,");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DepartName", SqlDbType.NVarChar,50)
					};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DepartName;

		return	DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}
       /// <summary>
        /// 修改部门名称
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Update(string name, int id)
        {
            string sql = string.Format("update Stale_Department set departname='{0}' where id={1} ", name, id);

            return DbHelperSQL.ExecuteCommand(sql) > 0;
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_Department ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

		return	DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}
       /// <summary>
       /// 查询部门ID
       /// </summary>
       /// <param name="departname"></param>
       /// <returns></returns>
        public int GetDepartID(string departname)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID from Stale_Department ");
            strSql.Append(" where DepartName=@DepartName ");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartName", SqlDbType.NVarChar,50)};
            parameters[0].Value = departname;

            return DbHelperSQL.GetScalar(strSql.ToString(), parameters);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Department_Model GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DepartName from Stale_Department ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.Department_Model model=new Model.Department_Model();
		    DataTable dt=DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[0]["ID"].ToString());
				}
				model.DepartName=dt.Rows[0]["DepartName"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataTable GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,DepartName ");
			strSql.Append(" FROM Stale_Department ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}

        #endregion
    }
}
