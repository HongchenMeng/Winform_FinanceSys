using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using FinanceSys.PublicLibrary;
using System.Data.SqlClient;
using System.Data;

namespace FinanceSys.FinanceManagerSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Outlay。
    /// </summary>
    public class Outlay_DAL
    {
        public Outlay_DAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stale_Outlay");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			if( DbHelperSQL.GetScalar(strSql.ToString(),parameters)>0)return true;else return false;
		}

        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int OutlayCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from Stale_Outlay");

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
            strSql.Append("select  ID as '编号',Outlayetime  as '支出时间',Money as '支出金额',");
            strSql.Append("Party as '甲方',B as '乙方',DemoName as '项目名称',Type as '支出类型',");
            strSql.Append("ContractNo  as '合同编号',EmpName as '业务员',OperPerson as '操作员',");
            strSql.Append("Remark  as '备注' from Stale_Outlay ");
            strSql.Append(" order by id desc");

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
             strSql.Append(" ID as '编号',Outlayetime  as '支出时间',Money as '支出金额',");
            strSql.Append("Party as '甲方',B as '乙方',DemoName as '项目名称',Type as '支出类型',");
            strSql.Append("ContractNo  as '合同编号',EmpName as '业务员',OperPerson as '操作员',");
            strSql.Append("Remark  as '备注'");
            strSql.Append("FROM Stale_Outlay ");
            strSql.Append(" WHERE ID >(SELECT ISNULL(MAX(ID),0) FROM ");
            strSql.Append("(SELECT TOP (15*(" + pagenum + "-1)) ID FROM Stale_Outlay ORDER BY ID");
            strSql.Append(") A)ORDER BY ID desc");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
        public int Add(Model.Outlay_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Stale_Outlay(");
            strSql.Append("EmpName,Party,B,DemoName,Type,ContractNo,Outlayetime,OperPerson,Money,Remark)");
            strSql.Append(" values (");
            strSql.Append("'" + model.EmpName + "',");
            strSql.Append("'" + model.Party + "',");
            strSql.Append("'" + model.B + "',");
            strSql.Append("'" + model.DemoName + "',");
            strSql.Append("'" + model.Type + "',");
            strSql.Append("'" + model.ContractNo + "',");
            strSql.Append("'" + model.Outlayetime + "',");
            strSql.Append("'" + model.OperPerson + "',");
            strSql.Append("" + model.Money + ",");
            strSql.Append("'" + model.Remark + "'");
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");

            return DbHelperSQL.ExecuteCommand(strSql.ToString());
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Outlay_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_Outlay set ");
			strSql.Append("EmpName=@EmpName,");
			strSql.Append("Party=@Party,");
			strSql.Append("B=@B,");
			strSql.Append("DemoName=@DemoName,");
			strSql.Append("Type=@Type,");
			strSql.Append("ContractNo=@ContractNo,");
			strSql.Append("Outlayetime=@Outlayetime,");
			strSql.Append("OperPerson=@OperPerson,");
			strSql.Append("Money=@Money,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Party", SqlDbType.NVarChar,100),
					new SqlParameter("@B", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@ContractNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Outlayetime", SqlDbType.DateTime),
					new SqlParameter("@OperPerson", SqlDbType.NVarChar,50),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.EmpName;
			parameters[2].Value = model.Party;
			parameters[3].Value = model.B;
			parameters[4].Value = model.DemoName;
			parameters[5].Value = model.Type;
			parameters[6].Value = model.ContractNo;
			parameters[7].Value = model.Outlayetime;
			parameters[8].Value = model.OperPerson;
			parameters[9].Value = model.Money;
			parameters[10].Value = model.Remark;

			return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_Outlay ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Outlay_Model GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,EmpName,Party,B,DemoName,Type,ContractNo,Outlayetime,OperPerson,Money,Remark from Stale_Outlay ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.Outlay_Model model=new Model.Outlay_Model();
			DataTable dt=DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[0]["ID"].ToString());
				}
				model.EmpName=dt.Rows[0]["EmpName"].ToString();
				model.Party=dt.Rows[0]["Party"].ToString();
				model.B=dt.Rows[0]["B"].ToString();
				model.DemoName=dt.Rows[0]["DemoName"].ToString();
				model.Type=dt.Rows[0]["Type"].ToString();
				model.ContractNo=dt.Rows[0]["ContractNo"].ToString();
				if(dt.Rows[0]["Outlayetime"].ToString()!="")
				{
					model.Outlayetime=DateTime.Parse(dt.Rows[0]["Outlayetime"].ToString());
				}
				model.OperPerson=dt.Rows[0]["OperPerson"].ToString();
				if(dt.Rows[0]["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(dt.Rows[0]["Money"].ToString());
				}
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
		public DataTable GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,EmpName,Party,B,DemoName,Type,ContractNo,Outlayetime,OperPerson,Money,Remark ");
			strSql.Append(" FROM Stale_Outlay order by id desc");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}
        /// <summary>
        /// 返回月份差值
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public int GetMonth(DateTime time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select datediff(m,'" + time + "',getdate())");

            return DbHelperSQL.GetScalar(strSql.ToString());
        }

        /// <summary>
        /// 查询月份总支出金额
        /// </summary>
        /// <param name="time">参数 时间</param>
        /// <returns>返回泛型集合</returns>
        public int GetOutSys(DateTime time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum([Money]) from stale_outlay where datediff(m,outlayetime,getdate())=");
            strSql.Append("" + GetMonth(time) + "");
            return DbHelperSQL.GetScalar(strSql.ToString());
        }

        #endregion
    }
}
