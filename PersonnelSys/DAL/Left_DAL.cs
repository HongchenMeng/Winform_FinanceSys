using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FinanceSys.PublicLibrary;
using Model = FinanceSys.PersonnelSys.Model;

namespace FinanceSys.PersonnelSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Left。
    /// </summary>
    public class Left_DAL
    {
        public Left_DAL() { }

        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Stale_Left");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            if (DbHelperSQL.GetScalar(strSql.ToString(), parameters) > 0) return true; else return false;
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Left_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Stale_Left(");
            strSql.Append("EID,EmpName,Sex,DepartName,LeftTime,LeftType,LeftReason,ApprovalPerson,ApprovalDempart,Remark)");
            strSql.Append(" values (");
            strSql.Append("@EID,@EmpName,@Sex,@DepartName,@LeftTime,@LeftType,@LeftReason,@ApprovalPerson,@ApprovalDempart,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EID", SqlDbType.Int,4),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NChar,2),
					new SqlParameter("@DepartName", SqlDbType.NVarChar,50),
					new SqlParameter("@LeftTime", SqlDbType.DateTime),
					new SqlParameter("@LeftType", SqlDbType.NVarChar,50),
					new SqlParameter("@LeftReason", SqlDbType.NVarChar,200),
					new SqlParameter("@ApprovalPerson", SqlDbType.NVarChar,50),
					new SqlParameter("@ApprovalDempart", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.EID;
            parameters[1].Value = model.EmpName;
            parameters[2].Value = model.Sex;
            parameters[3].Value = model.DepartName;
            parameters[4].Value = model.LeftTime;
            parameters[5].Value = model.LeftType;
            parameters[6].Value = model.LeftReason;
            parameters[7].Value = model.ApprovalPerson;
            parameters[8].Value = model.ApprovalDempart;
            parameters[9].Value = model.Remark;


            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;

        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.Left_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Left set ");
            strSql.Append("EID=@EID,");
            strSql.Append("EmpName=@EmpName,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("DepartName=@DepartName,");
            strSql.Append("LeftTime=@LeftTime,");
            strSql.Append("LeftType=@LeftType,");
            strSql.Append("LeftReason=@LeftReason,");
            strSql.Append("ApprovalPerson=@ApprovalPerson,");
            strSql.Append("ApprovalDempart=@ApprovalDempart,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EID", SqlDbType.Int,4),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Sex", SqlDbType.NChar,2),
					new SqlParameter("@DepartName", SqlDbType.NVarChar,50),
					new SqlParameter("@LeftTime", SqlDbType.DateTime),
					new SqlParameter("@LeftType", SqlDbType.NVarChar,50),
					new SqlParameter("@LeftReason", SqlDbType.NVarChar,200),
					new SqlParameter("@ApprovalPerson", SqlDbType.NVarChar,50),
					new SqlParameter("@ApprovalDempart", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.EID;
            parameters[2].Value = model.EmpName;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.DepartName;
            parameters[5].Value = model.LeftTime;
            parameters[6].Value = model.LeftType;
            parameters[7].Value = model.LeftReason;
            parameters[8].Value = model.ApprovalPerson;
            parameters[9].Value = model.ApprovalDempart;
            parameters[10].Value = model.Remark;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stale_Left ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; return 0;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Left_Model GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,EID,EmpName,Sex,DepartName,LeftTime,LeftType,LeftReason,ApprovalPerson,ApprovalDempart,Remark from Stale_Left ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Model.Left_Model model = new Model.Left_Model();
            DataTable dt = DbHelperSQL.GetDateSet(strSql.ToString(), parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                }
                if (dt.Rows[0]["EID"].ToString() != "")
                {
                    model.EID = int.Parse(dt.Rows[0]["EID"].ToString());
                }
                model.EmpName = dt.Rows[0]["EmpName"].ToString();
                model.Sex = dt.Rows[0]["Sex"].ToString();
                model.DepartName = dt.Rows[0]["DepartName"].ToString();
                if (dt.Rows[0]["LeftTime"].ToString() != "")
                {
                    model.LeftTime = DateTime.Parse(dt.Rows[0]["LeftTime"].ToString());
                }
                model.LeftType = dt.Rows[0]["LeftType"].ToString();
                model.LeftReason = dt.Rows[0]["LeftReason"].ToString();
                model.ApprovalPerson = dt.Rows[0]["ApprovalPerson"].ToString();
                model.ApprovalDempart = dt.Rows[0]["ApprovalDempart"].ToString();
                model.Remark = dt.Rows[0]["Remark"].ToString();
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
        public DataTable GetList(string ziduan,string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select empname as '姓名',sex as '性别',DepartName as '部门名称',");
            strSql.Append("LeftTime as '离职时间',LeftType as '离职类型',LeftReason as '离职原因',");
            strSql.Append("ApprovalPerson as '批准人',ApprovalDempart as '批准人部门',");
            strSql.Append("Remark as '备注' from stale_left where ");

            if (!string.IsNullOrEmpty(ziduan))
            {
                switch (ziduan)
                {
                    case "EmpName":
                        strSql.Append(" EmpName like '%" + strWhere + "%'");
                        break;
                    case "Sex":
                        strSql.Append(" Sex='" + strWhere + "'");
                        break;
                    default:
                        strSql.Append(" DepartName like '%" + strWhere + "%'");
                        break;
                }
            }
            strSql.Append(" order by id desc");
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int LeftCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from stale_left");

            return DbHelperSQL.GetScalar(strSql.ToString());
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="start">起始页</param>
        /// <param name="max">最大条数</param>
        /// <returns></returns>
        public DataTable GetList(int start, int max)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select empname as '姓名',sex as '性别',DepartName as '部门名称',");
            strSql.Append("LeftTime as '离职时间',LeftType as '离职类型',LeftReason as '离职原因',");
            strSql.Append("ApprovalPerson as '批准人',ApprovalDempart as '批准人部门',");
            strSql.Append("Remark as '备注' ");
            strSql.Append(" FROM Stale_Left ");

            DataTable dt = DbHelperSQL.GetDataTable_Page(strSql.ToString(), start, max);
            if (dt != null)
            {
                return dt;
            }
            else
            {
                return null;
            }

        }
        /// <summary>
        /// 查询每页显示的数量
        /// 参数：当前页
        /// </summary>
        /// <param name="pagenum"></param>
        /// <returns></returns>
        public DataTable GetList(int pagenum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP 15 ");
            strSql.Append("id as '编号',empname as '姓名',sex as '性别',DepartName as '部门名称',");
            strSql.Append("LeftTime as '离职时间',LeftType as '离职类型',LeftReason as '离职原因',");
            strSql.Append("ApprovalPerson as '批准人',ApprovalDempart as '批准人部门',");
            strSql.Append("Remark as '备注' ");
            strSql.Append("FROM Stale_Left ");
            strSql.Append(" WHERE ID >(SELECT ISNULL(MAX(ID),0) FROM ");
            strSql.Append("(SELECT TOP (15*(" + pagenum + "-1)) ID FROM Stale_Left ORDER BY ID");
            strSql.Append(") A)ORDER BY ID");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataTable GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,EID,EmpName,Sex,DepartName,LeftTime,LeftType,LeftReason,ApprovalPerson,ApprovalDempart,Remark ");
            strSql.Append(" FROM Stale_Left ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }

        #endregion
    }
}
