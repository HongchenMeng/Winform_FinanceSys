using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;
using System.Data.SqlClient;
using FinanceSys.PublicLibrary;

namespace FinanceSys.FinanceManagerSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Salary。
    /// </summary>
    public class Salary_DAL
    {
        public Salary_DAL()
		{}
		#region  成员方法

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.Salary_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Stale_Salary(");
			strSql.Append("NewSalary,OldSalary,Reason,PubDate,EmpName,OperPerson,Remark)");
			strSql.Append(" values (");
            strSql.Append("@NewSalary,@OldSalary,@Reason,@PubDate,@EmpName,@OperPerson,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NewSalary", SqlDbType.Decimal,9),
					new SqlParameter("@OldSalary", SqlDbType.Decimal,9),
					new SqlParameter("@Reason", SqlDbType.NVarChar,200),
					new SqlParameter("@PubDate", SqlDbType.DateTime),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@OperPerson", SqlDbType.NVarChar,30),
					new SqlParameter("@Remark", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.NewSalary;
			parameters[1].Value = model.OldSalary;
			parameters[2].Value = model.Reason;
			parameters[3].Value = model.PubDate;
			parameters[4].Value = model.EmpName;
			parameters[5].Value = model.OperPerson;
			parameters[6].Value = model.Remark;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
		}
        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int SalaryCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from Stale_Salary");

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
            strSql.Append("select  salaryid as '编号',NewSalary as '变动后的工资',OldSalary as '变动前的工资',Reason  as '变动原因',PubDate  as '变动时间',EmpName as '姓名',OperPerson as '操作员',Remark as '备注' from ");
            strSql.Append("Stale_Salary order by salaryid desc");

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
        public DataTable GetIList(int pagenum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP 15 ");
            strSql.Append("salaryid as '编号',NewSalary as '变动后的工资',");
            strSql.Append("OldSalary as '变动前的工资',Reason  as '变动原因',");
            strSql.Append("PubDate  as '变动时间',EmpName as '姓名',");
            strSql.Append("OperPerson as '操作员',Remark as '备注'");
            strSql.Append("FROM Stale_Salary ");
            strSql.Append(" WHERE salaryid >(SELECT ISNULL(MAX(salaryid),0) FROM ");
            strSql.Append("(SELECT TOP (15*(" + pagenum + "-1)) salaryid FROM Stale_Salary ORDER BY salaryid");
            strSql.Append(") A)ORDER BY salaryid desc");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public DataTable GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  salaryid as '编号',NewSalary as '变动后的工资',OldSalary as '变动前的工资',Reason  as '变动原因',PubDate  as '变动时间',EmpName as '姓名',OperPerson as '操作员',Remark as '备注' from ");
            strSql.Append("Stale_Salary order by salaryid desc");            

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        #endregion
    }
}
