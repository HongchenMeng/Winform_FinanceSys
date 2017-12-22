using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using FinanceSys.PublicLibrary;
using Model = FinanceSys.PersonnelSys.Model;
using System.Data;

namespace FinanceSys.PersonnelSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Employee。
    /// </summary>
    public class Employee_DAL
    {
        private DbHelperSQL DbHelperSQL = new DbHelperSQL();

        public Employee_DAL() { }

        	#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string empname)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stale_Employee");
            strSql.Append(" where EmpName=@EmpName ");
			SqlParameter[] parameters = {
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50)};
			parameters[0].Value = empname;

			if( DbHelperSQL.GetScalar(strSql.ToString(),parameters)>0)return true;else return false;
		}

        //public IList<Model.Employee_Model> GetIList()
        //{
        //    //return;
        //}
		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(Model.Employee_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Stale_Employee(");
            strSql.Append("EmpName,Sex,EntryTime,DepartID,Job,Mobile,OfficePhone,Status,Remark,Code)");
            strSql.Append(" values (");
            strSql.Append("@EmpName,@Sex,@EntryTime,@DepartID,@Job,@Mobile,@OfficePhone,@Status,@Remark,@Code)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NChar,2),
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@DepartID", SqlDbType.Int),
					new SqlParameter("@Job", SqlDbType.NVarChar,50),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@OfficePhone", SqlDbType.NVarChar,50),
					new SqlParameter("@Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@Code", SqlDbType.Int)
                                        };
            parameters[0].Value = model.EmpName;
            parameters[1].Value = model.Sex;
            parameters[2].Value = model.EntryTime;
            parameters[3].Value = model.DepartID;
            parameters[4].Value = model.Job;
            parameters[5].Value = model.Mobile;
            parameters[6].Value = model.OfficePhone;
            parameters[7].Value = model.Status;
            parameters[8].Value = model.Remark;
            parameters[9].Value = model.Code;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Employee_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_Employee set ");
			strSql.Append("EmpName=@EmpName,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("EntryTime=@EntryTime,");
            strSql.Append("DepartID=@DepartID,");
			strSql.Append("Job=@Job,");
			strSql.Append("Mobile=@Mobile,");
			strSql.Append("OfficePhone=@OfficePhone,");
			strSql.Append("Status=@Status,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NChar,2),
					new SqlParameter("@EntryTime", SqlDbType.DateTime),
					new SqlParameter("@DepartID", SqlDbType.Int),
					new SqlParameter("@Job", SqlDbType.NVarChar,50),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,50),
					new SqlParameter("@OfficePhone", SqlDbType.NVarChar,50),
					new SqlParameter("@Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.EmpName;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.EntryTime;
            parameters[4].Value = model.DepartID;
			parameters[5].Value = model.Job;
			parameters[6].Value = model.Mobile;
			parameters[7].Value = model.OfficePhone;
			parameters[8].Value = model.Status;
			parameters[9].Value = model.Remark;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;
		}
        
        /// <summary>
        /// 更改在职状态
        /// </summary>
        public int Update(int id,string status)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Employee set ");
            strSql.Append("Status=@Status ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),					
					new SqlParameter("@Status", SqlDbType.NVarChar,50)};
            parameters[0].Value = id;         
            parameters[1].Value = status;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;
        }

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_Employee ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Employee_Model GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,EmpName,Sex,EntryTime,DepartID,Job,Mobile,OfficePhone,Status,Remark from Stale_Employee ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.Employee_Model model=new Model.Employee_Model();
			DataTable dt = DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[0]["ID"].ToString());
				}
				model.EmpName=dt.Rows[0]["EmpName"].ToString();
				model.Sex=dt.Rows[0]["Sex"].ToString();
				if(dt.Rows[0]["EntryTime"].ToString()!="")
				{
					model.EntryTime=DateTime.Parse(dt.Rows[0]["EntryTime"].ToString());
				}
                model.DepartID = int.Parse(dt.Rows[0]["DepartID"].ToString());
				model.Job=dt.Rows[0]["Job"].ToString();
				model.Mobile=dt.Rows[0]["Mobile"].ToString();
				model.OfficePhone=dt.Rows[0]["OfficePhone"].ToString();
				model.Status=dt.Rows[0]["Status"].ToString();
				model.Remark=dt.Rows[0]["Remark"].ToString();
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
        public DataTable GetList(string ziduan, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select a.ID as 工号,a.EmpName as 姓名,a.Sex as 性别,a.EntryTime as 入职时间,");
            strSql.Append("b.departname as 所在部门,a.Job as 职位,a.Mobile as 联系电话,a.OfficePhone as 办公电话");
            strSql.Append(",a.Status as 在职状态,a.Remark  as 备注 ");
            strSql.Append(" FROM Stale_Employee a left join Stale_Department b on (a.departid=b.id)");
            strSql.Append(" where code != 1 ");
            if (!string.IsNullOrEmpty(ziduan))
            {
                switch (ziduan)
                {
                    case "ID":
                        try { strSql.Append(" and a.id=" + int.Parse(strWhere)); }
                        catch { return null; }
                        break;
                    case "EmpName":
                        strSql.Append(" and a.EmpName='" + strWhere + "'");
                        break;
                    case "Sex":
                        strSql.Append(" and a.Sex='" + strWhere + "'");
                        break;
                    default:
                        try
                        {
                            strSql.Append(" and b.DepartName='" + strWhere + "'");
                        }
                        catch { return null; }
                        break;
                }
                
            }
            strSql.Append(" order by a.id desc");
            //else
            //{
            //    return null;
            //}

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,empname from stale_employee where code!=1");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(string strWhere)
        {
            string sql = "select * from stale_employee";

            return DbHelperSQL.GetDateSet(sql);
        }
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetListByOperation(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,empname from Stale_Employee ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where job = '" + strWhere + "'");
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataTable GetEmpByDepart(int depart)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,EmpName ");
            strSql.Append(" FROM Stale_Employee where DepartID = @DepartID  and code != 1");

            SqlParameter[] param = new SqlParameter[] { 
                new SqlParameter("@DepartID",SqlDbType.Int,4)
            };

            param[0].Value = depart;

            return DbHelperSQL.GetDateSet(strSql.ToString(),param);
        }
        /// <summary>
        /// 更改状态标识
        /// </summary>
        /// <param name="id"></param>
        public void UpdateCode(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update stale_employee set code=1 where id=" + id + "");

            DbHelperSQL.ExecuteCommand(strSql.ToString());
        }
        #endregion
    }
}
