using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model = FinanceSys.FinanceManagerSys.Model;
using FinanceSys.PublicLibrary;
using System.Data.SqlClient;
using System.Collections;

namespace FinanceSys.FinanceManagerSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Contract。
    /// </summary>
    public class Contract_DAL
    {
        public Contract_DAL()
		{}
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ContractID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stale_Contract");
			strSql.Append(" where ContractNo=@ContractID ");
			SqlParameter[] parameters = new SqlParameter[]
            {
					new SqlParameter("@ContractID", SqlDbType.Int,4)};
			parameters[0].Value = ContractID;

            if (DbHelperSQL.GetScalar(strSql.ToString(), parameters) > 0) return true; else return false;
		}
        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int ContractCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from Stale_Contract");                       

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
            strSql.Append("select ContractID as '编号',ContractNo as '合同编号',Party as '甲方',B as '乙方',DemoName as '项目名称',Money as '项目金额',Cost as '项目成本',Payment as '付款方式',EmpName as '业务员',InvoiceNo as '发票编号',Signedtime as '合同签订时间',OperPerson as '操作员',Remark as '备注' ");
            strSql.Append(" from stale_contract");

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
        /// 获得数据列表
        /// 根据合同编号
        /// </summary>
        public DataTable GetListByContract(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ContractID as '编号',ContractNo as '合同编号',Party as '甲方',B as '乙方',DemoName as '项目名称',Money as '项目金额',Cost as '项目成本',Payment as '付款方式',EmpName as '业务员',InvoiceNo as '发票编号',Signedtime as '合同签订时间',OperPerson as '操作员',Remark as '备注' ");
            strSql.Append(" FROM Stale_Contract ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where ContractNo like '%" + strWhere + "%'");
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// 根据甲方名称
        /// </summary>
        public DataTable GetListByParty(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ContractID as '编号',ContractNo as '合同编号',Party as '甲方',B as '乙方',DemoName as '项目名称',Money as '项目金额',Cost as '项目成本',Payment as '付款方式',EmpName as '业务员',InvoiceNo as '发票编号',Signedtime as '合同签订时间',OperPerson as '操作员',Remark as '备注' ");
            strSql.Append(" FROM Stale_Contract ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where Party like '%" + strWhere + "%'");
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// 根据乙方名称
        /// </summary>
        public DataTable GetListByB(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ContractID as '编号',ContractNo as '合同编号',Party as '甲方',B as '乙方',DemoName as '项目名称',Money as '项目金额',Cost as '项目成本',Payment as '付款方式',EmpName as '业务员',InvoiceNo as '发票编号',Signedtime as '合同签订时间',OperPerson as '操作员',Remark as '备注' ");
            strSql.Append(" FROM Stale_Contract ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where B like '%" + strWhere + "%'");
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// 根据项目名称
        /// </summary>
        public DataTable GetListByDemoName(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ContractID as '编号',ContractNo as '合同编号',Party as '甲方',B as '乙方',DemoName as '项目名称',Money as '项目金额',Cost as '项目成本',Payment as '付款方式',EmpName as '业务员',InvoiceNo as '发票编号',Signedtime as '合同签订时间',OperPerson as '操作员',Remark as '备注' ");
            strSql.Append(" FROM Stale_Contract ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where DemoName like '%" + strWhere + "%'");
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.Contract_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Stale_Contract(");
            strSql.Append("ContractNo,Party,B,DemoName,Money,Payment,Schedule,Cost,EmpName,InvoiceNo,Signedtime,Addtime,OperPerson,Remark)");
			strSql.Append(" values (");
            strSql.Append("@ContractNo,@Party,@B,@DemoName,@Money,@Payment,@Schedule,@Cost,@EmpName,@InvoiceNo,@Signedtime,@Addtime,@OperPerson,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ContractNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Party", SqlDbType.NVarChar,100),
                    new SqlParameter("@B", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Payment", SqlDbType.NVarChar,20),
					new SqlParameter("@Schedule", SqlDbType.NVarChar,20),
					new SqlParameter("@Cost", SqlDbType.Decimal,9),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,100),
					new SqlParameter("@InvoiceNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Signedtime", SqlDbType.DateTime),
					new SqlParameter("@Addtime", SqlDbType.DateTime),
					new SqlParameter("@OperPerson", SqlDbType.NVarChar,30),
					new SqlParameter("@Remark", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.ContractNo;
			parameters[1].Value = model.Party;
            parameters[2].Value = model.B;
			parameters[3].Value = model.DemoName;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.Payment;
			parameters[6].Value = model.Schedule;
			parameters[7].Value = model.Cost;
			parameters[8].Value = model.EmpName;
			parameters[9].Value = model.InvoiceNo;
			parameters[10].Value = model.Signedtime;
			parameters[11].Value = model.Addtime;
			parameters[12].Value = model.OperPerson;
			parameters[13].Value = model.Remark;

			return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);			
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Contract_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_Contract set ");
			strSql.Append("ContractNo=@ContractNo,");
            strSql.Append("Party=@Party,");
            strSql.Append("B=@B,");
			strSql.Append("DemoName=@DemoName,");
			strSql.Append("Money=@Money,");
			strSql.Append("Payment=@Payment,");
			strSql.Append("Schedule=@Schedule,");
			strSql.Append("Cost=@Cost,");
            strSql.Append("EmpName=@EmpName,");
			strSql.Append("InvoiceNo=@InvoiceNo,");
			strSql.Append("Signedtime=@Signedtime,");
			strSql.Append("Addtime=@Addtime,");
			strSql.Append("OperPerson=@OperPerson,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ContractID=@ContractID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ContractID", SqlDbType.Int,4),
					new SqlParameter("@ContractNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Party", SqlDbType.NVarChar,100),
                    new SqlParameter("@B", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Payment", SqlDbType.NVarChar,20),
					new SqlParameter("@Schedule", SqlDbType.NVarChar,20),
					new SqlParameter("@Cost", SqlDbType.Decimal,9),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,100),
					new SqlParameter("@InvoiceNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Signedtime", SqlDbType.DateTime),
					new SqlParameter("@Addtime", SqlDbType.DateTime),
					new SqlParameter("@OperPerson", SqlDbType.NVarChar,30),
					new SqlParameter("@Remark", SqlDbType.NVarChar,1000)};
			parameters[0].Value = model.ContractID;
			parameters[1].Value = model.ContractNo;
            parameters[2].Value = model.Party;
            parameters[3].Value = model.B;
			parameters[4].Value = model.DemoName;
			parameters[5].Value = model.Money;
			parameters[6].Value = model.Payment;
			parameters[7].Value = model.Schedule;
			parameters[8].Value = model.Cost;
            parameters[9].Value = model.EmpName;
			parameters[10].Value = model.InvoiceNo;
			parameters[11].Value = model.Signedtime;
			parameters[12].Value = model.Addtime;
			parameters[13].Value = model.OperPerson;
			parameters[14].Value = model.Remark;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ContractID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_Contract ");
			strSql.Append(" where ContractID=@ContractID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ContractID", SqlDbType.Int,4)};
			parameters[0].Value = ContractID;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Contract_Model GetModel(int ContractID)
		{
			
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ContractID,ContractNo,Party,B,DemoName,Money,Payment,Schedule,Cost,EmpName,InvoiceNo,Signedtime,Addtime,OperPerson,Remark from Stale_Contract ");
			strSql.Append(" where ContractID=@ContractID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ContractID", SqlDbType.Int,4)};
			parameters[0].Value = ContractID;

            Model.Contract_Model model = new Model.Contract_Model();
			DataTable dt=DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ContractID"].ToString()!="")
				{
					model.ContractID=int.Parse(dt.Rows[0]["ContractID"].ToString());
				}
				model.ContractNo=dt.Rows[0]["ContractNo"].ToString();
                model.Party = dt.Rows[0]["Party"].ToString();
                model.B = dt.Rows[0]["B"].ToString();
				model.DemoName=dt.Rows[0]["DemoName"].ToString();
				if(dt.Rows[0]["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(dt.Rows[0]["Money"].ToString());
				}
				model.Payment=dt.Rows[0]["Payment"].ToString();
				model.Schedule=dt.Rows[0]["Schedule"].ToString();
				if(dt.Rows[0]["Cost"].ToString()!="")
				{
					model.Cost=decimal.Parse(dt.Rows[0]["Cost"].ToString());
				}

                model.EmpName = dt.Rows[0]["EmpName"].ToString();
				
				model.InvoiceNo=dt.Rows[0]["InvoiceNo"].ToString();
				if(dt.Rows[0]["Signedtime"].ToString()!="")
				{
					model.Signedtime=DateTime.Parse(dt.Rows[0]["Signedtime"].ToString());
				}
				if(dt.Rows[0]["Addtime"].ToString()!="")
				{
					model.Addtime=DateTime.Parse(dt.Rows[0]["Addtime"].ToString());
				}
				model.OperPerson=dt.Rows[0]["OperPerson"].ToString();
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
            strSql.Append("select ContractID,ContractNo,Party,B,DemoName,Money,Payment,Schedule,Cost,EmpName,InvoiceNo,Signedtime,Addtime,OperPerson,Remark ");
            strSql.Append(" FROM Stale_Contract order by ContractID desc");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
            strSql.Append(" ContractID,ContractNo,Party,B,DemoName,Money,Payment,Schedule,Cost,EmpName,InvoiceNo,Signedtime,Addtime,OperPerson,Remark ");
			strSql.Append(" FROM Stale_Contract ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}
        /// <summary>
        /// 根据合同编号查询出此
        /// 合同的合同金额
        /// </summary>
        /// <param name="contractno"></param>
        /// <returns></returns>
        public decimal GetContractMoney(string contractno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [money] from Stale_Contract ");
            strSql.Append(" where contractno='" + contractno + "'");
            using (SqlDataReader dareader = DbHelperSQL.GetReader(strSql.ToString()))
            {
                decimal countmoney = 0;
                if (dareader.Read())
                {
                    if (!string.IsNullOrEmpty(dareader["Money"].ToString()))
                    {
                        countmoney = Convert.ToDecimal(dareader["Money"]);
                    }
                }
                return countmoney;
                dareader.Dispose();
                dareader.Close();
            }
        }
        #endregion
    }
}
