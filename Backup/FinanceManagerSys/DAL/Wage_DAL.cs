using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using FinanceSys.PublicLibrary;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data;

namespace FinanceSys.FinanceManagerSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Wage。
    /// </summary>
    public class Wage_DAL
    {
        #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public int Exists(string empname)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id from Stale_Wage");
            strSql.Append(" where EmpName=@EmpName");
            SqlParameter[] parameters = {
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50)};
            parameters[0].Value = empname;

            return DbHelperSQL.GetScalar(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int WageCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from Stale_Wage");

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
            strSql.Append("select id as '编号',[Month] as '月份',EmpName as '姓名',BasicWage as '基本工资',Jobsubsidies as '岗位补贴',");
            strSql.Append("Allowance as '津贴',Overtimepay as '加班工资',Bonus as '奖金',Businesscommission as '业务提成',PersonalIncomeTax as '个人所得税',");
            strSql.Append("SocialSecurity as '社保',Other as '其它',Remark as '备注'");
            strSql.Append(" from stale_wage ");

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
            strSql.Append(" id as '编号',[Month] as '月份',EmpName as '姓名',");
            strSql.Append("BasicWage as '基本工资',Jobsubsidies as '岗位补贴',");
            strSql.Append("Allowance as '津贴',Overtimepay as '加班工资',Bonus as '奖金'");
            strSql.Append(",Businesscommission as '业务提成',PersonalIncomeTax as '个人所得税',");
            strSql.Append("SocialSecurity as '社保',Other as '其它',Remark as '备注'");
            strSql.Append("FROM stale_wage ");
            strSql.Append(" WHERE ID >(SELECT ISNULL(MAX(ID),0) FROM ");
            strSql.Append("(SELECT TOP (15*(" + pagenum + "-1)) ID FROM stale_wage ORDER BY ID");
            strSql.Append(") A)ORDER BY ID desc");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.Wage_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Stale_Wage(");
			strSql.Append("Month,EmpName,BasicWage,Jobsubsidies,Allowance,Overtimepay,Bonus,Businesscommission,PersonalIncomeTax,SocialSecurity,Other,Remark)");
			strSql.Append(" values (");
			strSql.Append("@Month,@EmpName,@BasicWage,@Jobsubsidies,@Allowance,@Overtimepay,@Bonus,@Businesscommission,@PersonalIncomeTax,@SocialSecurity,@Other,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = new SqlParameter[]
            {
					new SqlParameter("@Month", SqlDbType.DateTime),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@BasicWage", SqlDbType.Decimal,9),
					new SqlParameter("@Jobsubsidies", SqlDbType.Decimal,9),
					new SqlParameter("@Allowance", SqlDbType.Decimal,9),
					new SqlParameter("@Overtimepay", SqlDbType.Decimal,9),
					new SqlParameter("@Bonus", SqlDbType.Decimal,9),
					new SqlParameter("@Businesscommission", SqlDbType.Decimal,9),
					new SqlParameter("@PersonalIncomeTax", SqlDbType.Decimal,9),
					new SqlParameter("@SocialSecurity", SqlDbType.Decimal,9),
					new SqlParameter("@Other", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)
            };
			parameters[0].Value = model.Month;
			parameters[1].Value = model.EmpName;
			parameters[2].Value = model.BasicWage;
			parameters[3].Value = model.Jobsubsidies;
			parameters[4].Value = model.Allowance;
			parameters[5].Value = model.Overtimepay;
			parameters[6].Value = model.Bonus;
			parameters[7].Value = model.Businesscommission;
			parameters[8].Value = model.PersonalIncomeTax;
			parameters[9].Value = model.SocialSecurity;
			parameters[10].Value = model.Other;
			parameters[11].Value = model.Remark;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Wage_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_Wage set ");
			strSql.Append("Month=@Month,");
			strSql.Append("EmpName=@EmpName,");
			strSql.Append("BasicWage=@BasicWage,");
			strSql.Append("Jobsubsidies=@Jobsubsidies,");
			strSql.Append("Allowance=@Allowance,");
			strSql.Append("Overtimepay=@Overtimepay,");
			strSql.Append("Bonus=@Bonus,");
			strSql.Append("Businesscommission=@Businesscommission,");
			strSql.Append("PersonalIncomeTax=@PersonalIncomeTax,");
			strSql.Append("SocialSecurity=@SocialSecurity,");
			strSql.Append("Other=@Other,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = new SqlParameter[]
            {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.DateTime),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@BasicWage", SqlDbType.Decimal,9),
					new SqlParameter("@Jobsubsidies", SqlDbType.Decimal,9),
					new SqlParameter("@Allowance", SqlDbType.Decimal,9),
					new SqlParameter("@Overtimepay", SqlDbType.Decimal,9),
					new SqlParameter("@Bonus", SqlDbType.Decimal,9),
					new SqlParameter("@Businesscommission", SqlDbType.Decimal,9),
					new SqlParameter("@PersonalIncomeTax", SqlDbType.Decimal,9),
					new SqlParameter("@SocialSecurity", SqlDbType.Decimal,9),
					new SqlParameter("@Other", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Month;
			parameters[2].Value = model.EmpName;
			parameters[3].Value = model.BasicWage;
			parameters[4].Value = model.Jobsubsidies;
			parameters[5].Value = model.Allowance;
			parameters[6].Value = model.Overtimepay;
			parameters[7].Value = model.Bonus;
			parameters[8].Value = model.Businesscommission;
			parameters[9].Value = model.PersonalIncomeTax;
			parameters[10].Value = model.SocialSecurity;
			parameters[11].Value = model.Other;
			parameters[12].Value = model.Remark;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; else return 0;
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(string name, decimal wage)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Wage set BasicWage=@BasicWage ");
            strSql.Append(" where EmpName=@EmpName ");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@BasicWage",SqlDbType.Decimal,9),
                new SqlParameter("@EmpName",SqlDbType.NVarChar,50)
            };

            paraments[0].Value = wage;
            paraments[1].Value = name;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments);
        }
        /// <summary>
        /// 更新一条数据
        /// 员工提成工资
        /// </summary>
        public int UpdateTic(string name, decimal money)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Wage Set Businesscommission=Businesscommission+@Businesscommission ");
            strSql.Append(" where EmpName=@EmpName");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@Businesscommission",SqlDbType.Decimal,9),
                new SqlParameter("@EmpName",SqlDbType.NVarChar,50)
            };

            paraments[0].Value = money;
            paraments[1].Value = name;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_Wage ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) > 0) return 1; else return 0;
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Wage_Model GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Month,EmpName,BasicWage,Jobsubsidies,Allowance,Overtimepay,Bonus,Businesscommission,PersonalIncomeTax,SocialSecurity,Other,Remark from Stale_Wage ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.Wage_Model model=new Model.Wage_Model();
			DataTable dt=DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ID"].ToString()!="")
				{
                    model.ID = int.Parse(dt.Rows[0]["ID"].ToString());
				}
                if (dt.Rows[0]["Month"].ToString() != "")
				{
                    model.Month = DateTime.Parse(dt.Rows[0]["Month"].ToString());
				}
                model.EmpName = dt.Rows[0]["EmpName"].ToString();
                if (dt.Rows[0]["BasicWage"].ToString() != "")
				{
                    model.BasicWage = decimal.Parse(dt.Rows[0]["BasicWage"].ToString());
				}
                if (dt.Rows[0]["Jobsubsidies"].ToString() != "")
				{
                    model.Jobsubsidies = decimal.Parse(dt.Rows[0]["Jobsubsidies"].ToString());
				}
                if (dt.Rows[0]["Allowance"].ToString() != "")
				{
                    model.Allowance = decimal.Parse(dt.Rows[0]["Allowance"].ToString());
				}
                if (dt.Rows[0]["Overtimepay"].ToString() != "")
				{
                    model.Overtimepay = decimal.Parse(dt.Rows[0]["Overtimepay"].ToString());
				}
                if (dt.Rows[0]["Bonus"].ToString() != "")
				{
                    model.Bonus = decimal.Parse(dt.Rows[0]["Bonus"].ToString());
				}
                if (dt.Rows[0]["Businesscommission"].ToString() != "")
				{
                    model.Businesscommission = decimal.Parse(dt.Rows[0]["Businesscommission"].ToString());
				}
                if (dt.Rows[0]["PersonalIncomeTax"].ToString() != "")
				{
                    model.PersonalIncomeTax = decimal.Parse(dt.Rows[0]["PersonalIncomeTax"].ToString());
				}
                if (dt.Rows[0]["SocialSecurity"].ToString() != "")
				{
                    model.SocialSecurity = decimal.Parse(dt.Rows[0]["SocialSecurity"].ToString());
				}
                if (dt.Rows[0]["Other"].ToString() != "")
				{
                    model.Other = decimal.Parse(dt.Rows[0]["Other"].ToString());
				}
                model.Remark = dt.Rows[0]["Remark"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Wage_Model GetModel(string name)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Month,EmpName,BasicWage,Jobsubsidies,Allowance,Overtimepay,Bonus,Businesscommission,PersonalIncomeTax,SocialSecurity,Other,Remark from Stale_Wage ");
            strSql.Append(" where EmpName=@EmpName ");
            SqlParameter[] parameters = {
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50)};
            parameters[0].Value = name;

            Model.Wage_Model model = new Model.Wage_Model();
            DataTable dt = DbHelperSQL.GetDateSet(strSql.ToString(), parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                }
                if (dt.Rows[0]["Month"].ToString() != "")
                {
                    model.Month = DateTime.Parse(dt.Rows[0]["Month"].ToString());
                }
                model.EmpName = dt.Rows[0]["EmpName"].ToString();
                if (dt.Rows[0]["BasicWage"].ToString() != "")
                {
                    model.BasicWage = decimal.Parse(dt.Rows[0]["BasicWage"].ToString());
                }
                if (dt.Rows[0]["Jobsubsidies"].ToString() != "")
                {
                    model.Jobsubsidies = decimal.Parse(dt.Rows[0]["Jobsubsidies"].ToString());
                }
                if (dt.Rows[0]["Allowance"].ToString() != "")
                {
                    model.Allowance = decimal.Parse(dt.Rows[0]["Allowance"].ToString());
                }
                if (dt.Rows[0]["Overtimepay"].ToString() != "")
                {
                    model.Overtimepay = decimal.Parse(dt.Rows[0]["Overtimepay"].ToString());
                }
                if (dt.Rows[0]["Bonus"].ToString() != "")
                {
                    model.Bonus = decimal.Parse(dt.Rows[0]["Bonus"].ToString());
                }
                if (dt.Rows[0]["Businesscommission"].ToString() != "")
                {
                    model.Businesscommission = decimal.Parse(dt.Rows[0]["Businesscommission"].ToString());
                }
                if (dt.Rows[0]["PersonalIncomeTax"].ToString() != "")
                {
                    model.PersonalIncomeTax = decimal.Parse(dt.Rows[0]["PersonalIncomeTax"].ToString());
                }
                if (dt.Rows[0]["SocialSecurity"].ToString() != "")
                {
                    model.SocialSecurity = decimal.Parse(dt.Rows[0]["SocialSecurity"].ToString());
                }
                if (dt.Rows[0]["Other"].ToString() != "")
                {
                    model.Other = decimal.Parse(dt.Rows[0]["Other"].ToString());
                }
                model.Remark = dt.Rows[0]["Remark"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public int GetEmpBasicWage(string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select basicwage from Stale_Wage ");
            strSql.Append(" where Empname=@Empname");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@Empname",SqlDbType.NVarChar,50)
            };

            paraments[0].Value = name;

            return DbHelperSQL.GetScalar(strSql.ToString(), paraments);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataTable GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,Month,EmpName,BasicWage,Jobsubsidies,Allowance,Overtimepay,Bonus,Businesscommission,PersonalIncomeTax,SocialSecurity,Other,Remark ");
			strSql.Append(" FROM Stale_Wage order by id desc");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}
        /// <summary>
		/// 获得数据列表
		/// </summary>
        public IList<FinanceManagerSys.Model.Wage_Model> GetListWage(string strWhere)
        {
            StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,[Month],EmpName,BasicWage,Jobsubsidies,Allowance,Overtimepay,Bonus,");
            strSql.Append("Businesscommission,PersonalIncomeTax,SocialSecurity,Other,Remark ");
            strSql.Append(" from stale_wage ");
            strSql.Append("where convert(varchar,[month],120) like '" + strWhere + "%'");
                        

            SqlDataReader reader = DbHelperSQL.GetReader(strSql.ToString());
            IList<FinanceManagerSys.Model.Wage_Model> ilist = new List<FinanceManagerSys.Model.Wage_Model>();

            while (reader.Read())
            {
                ilist.Add(ReaderBind(reader));
            }            
            return ilist;
            reader.Close();
            reader.Dispose();
        }
        /// <summary>
		/// 对象实体绑定数据
		/// </summary>
        private static FinanceManagerSys.Model.Wage_Model ReaderBind(SqlDataReader dataReader)
        {
            FinanceManagerSys.Model.Wage_Model model = new FinanceSys.FinanceManagerSys.Model.Wage_Model();
            if (dataReader["ID"].ToString() != "")
            {
                model.ID = int.Parse(dataReader["ID"].ToString());
            }
            if (dataReader["Month"].ToString() != "")
            {
                model.Month = DateTime.Parse(dataReader["Month"].ToString());
            }
            model.EmpName = dataReader["EmpName"].ToString();
            if (dataReader["BasicWage"].ToString() != "")
            {
                model.BasicWage = decimal.Parse(dataReader["BasicWage"].ToString());
            }
            if (dataReader["Jobsubsidies"].ToString() != "")
            {
                model.Jobsubsidies = decimal.Parse(dataReader["Jobsubsidies"].ToString());
            }
            if (dataReader["Allowance"].ToString() != "")
            {
                model.Allowance = decimal.Parse(dataReader["Allowance"].ToString());
            }
            if (dataReader["Overtimepay"].ToString() != "")
            {
                model.Overtimepay = decimal.Parse(dataReader["Overtimepay"].ToString());
            }
            if (dataReader["Bonus"].ToString() != "")
            {
                model.Bonus = decimal.Parse(dataReader["Bonus"].ToString());
            }
            if (dataReader["Businesscommission"].ToString() != "")
            {
                model.Businesscommission = decimal.Parse(dataReader["Businesscommission"].ToString());
            }
            if (dataReader["PersonalIncomeTax"].ToString() != "")
            {
                model.PersonalIncomeTax = decimal.Parse(dataReader["PersonalIncomeTax"].ToString());
            }
            if (dataReader["SocialSecurity"].ToString() != "")
            {
                model.SocialSecurity = decimal.Parse(dataReader["SocialSecurity"].ToString());
            }
            if (dataReader["Other"].ToString() != "")
            {
                model.Other = decimal.Parse(dataReader["Other"].ToString());
            }
            model.Remark = dataReader["Remark"].ToString();
            return model;
        }
        #endregion
    }
}
