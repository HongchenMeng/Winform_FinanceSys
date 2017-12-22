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
    /// 数据访问类Stale_InvoiceMX。
    /// </summary>
    public class InvoiceMX_DAL
    {
        public InvoiceMX_DAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stale_InvoiceMX");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) == 1) return true; else return false;
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.InvoiceMX_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Stale_InvoiceMX(");
            strSql.Append("InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo)");
			strSql.Append(" values (");
            strSql.Append("@InvoiceNo,@LTDName,@DemoName,@Money,@Invoicetime,@Payment,@Status,@Handling,@EmpName,@IsBank,@Remark,@ContractNo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@InvoiceNo", SqlDbType.NVarChar,100),
					new SqlParameter("@LTDName", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Invoicetime", SqlDbType.DateTime),
					new SqlParameter("@Payment", SqlDbType.NVarChar,50),
					new SqlParameter("@Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Handling", SqlDbType.NVarChar,50),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsBank", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100),
                    new SqlParameter("@ContractNo", SqlDbType.NVarChar,100)                    };
			parameters[0].Value = model.InvoiceNo;
			parameters[1].Value = model.LTDName;
			parameters[2].Value = model.DemoName;
			parameters[3].Value = model.Money;
			parameters[4].Value = model.Invoicetime;
			parameters[5].Value = model.Payment;
			parameters[6].Value = model.Status;
			parameters[7].Value = model.Handling;
			parameters[8].Value = model.EmpName;
			parameters[9].Value = model.IsBank;
			parameters[10].Value = model.Remark;
            parameters[11].Value = model.ContractNo;
			return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
        }
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.InvoiceMX_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_InvoiceMX set ");
			strSql.Append("InvoiceNo=@InvoiceNo,");
			strSql.Append("LTDName=@LTDName,");
			strSql.Append("DemoName=@DemoName,");
			strSql.Append("Money=@Money,");
			strSql.Append("Invoicetime=@Invoicetime,");
			strSql.Append("Payment=@Payment,");
			strSql.Append("Status=@Status,");
			strSql.Append("Handling=@Handling,");
			strSql.Append("EmpName=@EmpName,");
			strSql.Append("IsBank=@IsBank,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@InvoiceNo", SqlDbType.NVarChar,100),
					new SqlParameter("@LTDName", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Invoicetime", SqlDbType.DateTime),
					new SqlParameter("@Payment", SqlDbType.NVarChar,50),
					new SqlParameter("@Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Handling", SqlDbType.NVarChar,50),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsBank", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.InvoiceNo;
			parameters[2].Value = model.LTDName;
			parameters[3].Value = model.DemoName;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.Invoicetime;
			parameters[6].Value = model.Payment;
			parameters[7].Value = model.Status;
			parameters[8].Value = model.Handling;
			parameters[9].Value = model.EmpName;
			parameters[10].Value = model.IsBank;
			parameters[11].Value = model.Remark;

				return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_InvoiceMX ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

				return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.InvoiceMX_Model GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark from Stale_InvoiceMX ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.InvoiceMX_Model model=new Model.InvoiceMX_Model();
			DataTable dt=DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[0]["ID"].ToString());
				}
				model.InvoiceNo=dt.Rows[0]["InvoiceNo"].ToString();
				model.LTDName=dt.Rows[0]["LTDName"].ToString();
				model.DemoName=dt.Rows[0]["DemoName"].ToString();
				if(dt.Rows[0]["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(dt.Rows[0]["Money"].ToString());
				}
				if(dt.Rows[0]["Invoicetime"].ToString()!="")
				{
					model.Invoicetime=DateTime.Parse(dt.Rows[0]["Invoicetime"].ToString());
				}
				model.Payment=dt.Rows[0]["Payment"].ToString();
				model.Status=dt.Rows[0]["Status"].ToString();
				model.Handling=dt.Rows[0]["Handling"].ToString();
				model.EmpName=dt.Rows[0]["EmpName"].ToString();
				model.IsBank=dt.Rows[0]["IsBank"].ToString();
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
            strSql.Append("select ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo ");
			strSql.Append(" FROM Stale_InvoiceMX ");
			if(strWhere.Trim()!="")
			{
                strSql.Append(" where ContractNo = '" + strWhere + "'");
			}
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataTable GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark ");
			strSql.Append(" FROM Stale_InvoiceMX ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}
        #endregion
    }
}
