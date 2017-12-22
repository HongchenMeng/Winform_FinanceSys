using System;
using System.Collections.Generic;
using System.Text;
using Model = FinanceSys.FinanceManagerSys.Model;
using System.Data.SqlClient;
using FinanceSys.PublicLibrary;
using System.Data;

namespace FinanceSys.FinanceManagerSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Income。
    /// </summary>
    public class Income_DAL
    {
        public Income_DAL() { }
        #region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Stale_Income");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			if(DbHelperSQL.GetScalar(strSql.ToString(),parameters)>0)return true;else return false;
		}

        /// <summary>
        /// 获取分页总数
        /// </summary>
        public int IncomeCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) from Stale_Income");

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
            strSql.Append("select ID as '编号',DemoName as '项目名称',Party as '甲方',B as '乙方',Money as '收入金额',DemoCost as '项目成本',ContractNo as '合同编号',EmpName as '业务员',InvoiceMoney as '发票金额',IsBank as '是否回款',BreakMoney as '回款金额',Incometime as '收入时间',OperPerson as '操作员',Remark as '备注' ");
            strSql.Append(" from stale_income order by '编号' desc");
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
            strSql.Append("ID as '编号',DemoName as '项目名称',Party as '甲方'");
            strSql.Append(",B as '乙方',Money as '收入金额',Type as '收入类别',DemoCost as '项目成本'");
            strSql.Append(",ContractNo as '合同编号',EmpName as '业务员',InvoiceMoney as '发票金额'");
            strSql.Append(",IsBank as '是否回款',BreakMoney as '回款金额',Incometime as '收入时间',"); 
            strSql.Append("OperPerson as '操作员',Remark as '备注' ");
            strSql.Append("FROM stale_income ");
            strSql.Append(" WHERE ID >(SELECT ISNULL(MAX(ID),0) FROM ");
            strSql.Append("(SELECT TOP (15*(" + pagenum + "-1)) ID FROM stale_income ORDER BY ID");
            strSql.Append(") A)ORDER BY ID desc");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.Income_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Stale_Income(");
			strSql.Append("Party,B,DemoName,Money,DemoCost,ContractNo,Incometime,EmpName,Deductap,OperPerson,IsBank,InvoiceMoney,BreakMoney,Remark,Type)");
			strSql.Append(" values (");
			strSql.Append("@Party,@B,@DemoName,@Money,@DemoCost,@ContractNo,@Incometime,@EmpName,@Deductap,@OperPerson,@IsBank,@InvoiceMoney,@BreakMoney,@Remark,@Type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Party", SqlDbType.NVarChar,100),
					new SqlParameter("@B", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@DemoCost", SqlDbType.Decimal,9),
					new SqlParameter("@ContractNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Incometime", SqlDbType.DateTime),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Deductap", SqlDbType.Decimal,9),
					new SqlParameter("@OperPerson", SqlDbType.NVarChar,50),
					new SqlParameter("@IsBank", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceMoney", SqlDbType.Decimal,9),
					new SqlParameter("@BreakMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200),
                    new SqlParameter("@Type", SqlDbType.NVarChar,50)
                                        };
			parameters[0].Value = model.Party;
			parameters[1].Value = model.B;
			parameters[2].Value = model.DemoName;
			parameters[3].Value = model.Money;
			parameters[4].Value = model.DemoCost;
			parameters[5].Value = model.ContractNo;
			parameters[6].Value = model.Incometime;
			parameters[7].Value = model.EmpName;
			parameters[8].Value = model.Deductap;
			parameters[9].Value = model.OperPerson;
			parameters[10].Value = model.IsBank;
			parameters[11].Value = model.InvoiceMoney;
			parameters[12].Value = model.BreakMoney;
			parameters[13].Value = model.Remark;
            parameters[14].Value = model.Type;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public int Update(Model.Income_Model model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Stale_Income set ");
			strSql.Append("Party=@Party,");
			strSql.Append("B=@B,");
			strSql.Append("DemoName=@DemoName,");
			strSql.Append("Money=@Money,");
			strSql.Append("DemoCost=@DemoCost,");
			strSql.Append("ContractNo=@ContractNo,");
			strSql.Append("Incometime=@Incometime,");
			strSql.Append("EmpName=@EmpName,");
			strSql.Append("Deductap=@Deductap,");
			strSql.Append("OperPerson=@OperPerson,");
			strSql.Append("IsBank=@IsBank,");
			strSql.Append("InvoiceMoney=@InvoiceMoney,");
			strSql.Append("BreakMoney=@BreakMoney,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Party", SqlDbType.NVarChar,100),
					new SqlParameter("@B", SqlDbType.NVarChar,100),
					new SqlParameter("@DemoName", SqlDbType.NVarChar,100),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@DemoCost", SqlDbType.Decimal,9),
					new SqlParameter("@ContractNo", SqlDbType.NVarChar,100),
					new SqlParameter("@Incometime", SqlDbType.DateTime),
					new SqlParameter("@EmpName", SqlDbType.NVarChar,50),
					new SqlParameter("@Deductap", SqlDbType.Decimal,9),
					new SqlParameter("@OperPerson", SqlDbType.NVarChar,50),
					new SqlParameter("@IsBank", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceMoney", SqlDbType.Decimal,9),
					new SqlParameter("@BreakMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,200)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Party;
			parameters[2].Value = model.B;
			parameters[3].Value = model.DemoName;
			parameters[4].Value = model.Money;
			parameters[5].Value = model.DemoCost;
			parameters[6].Value = model.ContractNo;
			parameters[7].Value = model.Incometime;
			parameters[8].Value = model.EmpName;
			parameters[9].Value = model.Deductap;
			parameters[10].Value = model.OperPerson;
			parameters[11].Value = model.IsBank;
			parameters[12].Value = model.InvoiceMoney;
			parameters[13].Value = model.BreakMoney;
			parameters[14].Value = model.Remark;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
		}
        /// <summary>
		/// 更新一条数据
		/// </summary>
        public int Update(int id, decimal breakM)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update stale_income set BreakMoney=BreakMoney+@BreakMoney ");
            strSql.Append(" where ID=@ID");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@BreakMoney",SqlDbType.Decimal,9),
                new SqlParameter("@ID",SqlDbType.Int,4)
            };

            paraments[0].Value = breakM;
            paraments[1].Value = id;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int Update(string contract, decimal money)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update stale_income set InvoiceMoney=InvoiceMoney+@InvoiceMoney ");
            strSql.Append(" where ContractNo=@ContractNo");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@InvoiceMoney",SqlDbType.Decimal,9),
                new SqlParameter("@ContractNo",SqlDbType.NVarChar,100)
            };

            paraments[0].Value = money;
            paraments[1].Value = contract;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments);
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public int Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Stale_Income ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.ExecuteCommand(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.Income_Model GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Party,B,DemoName,Money,DemoCost,ContractNo,Incometime,EmpName,Deductap,OperPerson,IsBank,InvoiceMoney,BreakMoney,Remark,Type from Stale_Income ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Model.Income_Model model=new Model.Income_Model();
			DataTable dt=DbHelperSQL.GetDateSet(strSql.ToString(),parameters);
			if(dt.Rows.Count>0)
			{
				if(dt.Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(dt.Rows[0]["ID"].ToString());
				}
				model.Party=dt.Rows[0]["Party"].ToString();
				model.B=dt.Rows[0]["B"].ToString();
				model.DemoName=dt.Rows[0]["DemoName"].ToString();
				if(dt.Rows[0]["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(dt.Rows[0]["Money"].ToString());
				}
				if(dt.Rows[0]["DemoCost"].ToString()!="")
				{
					model.DemoCost=decimal.Parse(dt.Rows[0]["DemoCost"].ToString());
				}
				model.ContractNo=dt.Rows[0]["ContractNo"].ToString();
				if(dt.Rows[0]["Incometime"].ToString()!="")
				{
					model.Incometime=DateTime.Parse(dt.Rows[0]["Incometime"].ToString());
				}
				model.EmpName=dt.Rows[0]["EmpName"].ToString();
				if(dt.Rows[0]["Deductap"].ToString()!="")
				{
					model.Deductap=decimal.Parse(dt.Rows[0]["Deductap"].ToString());
				}
				model.OperPerson=dt.Rows[0]["OperPerson"].ToString();
				model.IsBank=dt.Rows[0]["IsBank"].ToString();
				if(dt.Rows[0]["InvoiceMoney"].ToString()!="")
				{
					model.InvoiceMoney=decimal.Parse(dt.Rows[0]["InvoiceMoney"].ToString());
				}
				if(dt.Rows[0]["BreakMoney"].ToString()!="")
				{
					model.BreakMoney=decimal.Parse(dt.Rows[0]["BreakMoney"].ToString());
				}
				model.Remark=dt.Rows[0]["Remark"].ToString();
                model.Type = dt.Rows[0]["Type"].ToString();
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
			strSql.Append("select ID,Party,B,DemoName,Money,DemoCost,ContractNo,Incometime,EmpName,Deductap,OperPerson,IsBank,InvoiceMoney,BreakMoney,Remark ");
			strSql.Append(",Type FROM Stale_Income order by id desc");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.GetDateSet(strSql.ToString());
		}
       
        /// <summary>
        /// 修改收入表中的
        /// 发票金额
        /// 以及是否回款
        /// </summary>
        /// <param name="contract"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public int UpIncomeMon(string contract, decimal money, string isbank)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Income set ");
            strSql.Append(" InvoiceMoney=InvoiceMoney+" + money + ",");
            strSql.Append(" IsBank='" + isbank + "'");
            strSql.Append(" where ContractNo='" + contract + "'");

            return DbHelperSQL.ExecuteCommand(strSql.ToString());
        }
        /// <summary>
        /// 获取收入总金额
        /// </summary>
        /// <returns></returns>
        public int GetCountM()
        {
            string sql = "select sum([money]) from Stale_Income";

            return DbHelperSQL.GetScalar(sql);
        }
        /// <summary>
        /// 改变回款状态
        /// </summary>
        /// <param name="contractid"></param>
        /// <returns></returns>
        public int UpdateState(string state,int contractid)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update stale_income set isbank=@isbank");
            strSql.Append(" where id=@id");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@isbank",SqlDbType.NVarChar,50),
                new SqlParameter("@id",SqlDbType.Int,4)
            };

            paraments[0].Value = state;
            paraments[1].Value = contractid;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments);
        }
        /// <summary>
        /// 返回月份差值
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        private   int GetMonth(DateTime time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select datediff(m,'" + time + "',getdate())");

            return DbHelperSQL.GetScalar(strSql.ToString());
        }
        /// <summary>
        /// 查询月份收入金额(合同方式)
        /// </summary>
        /// <returns></returns>
        public int GetSys(DateTime time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum([money]) from stale_income ");
            strSql.Append("where contractno!='非合同收入' and datediff(m,incometime,getdate())");
            strSql.Append("=" + GetMonth(time) + "");
                        
            return DbHelperSQL.GetScalar(strSql.ToString());
        }
        /// <summary>
        /// 查询月份收入总金额
        /// </summary>
        /// <returns></returns>
        public int GetIncomeCount(DateTime time)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum([money]) from stale_income ");
            strSql.Append("where datediff(m,incometime,getdate())");
            strSql.Append("=" + GetMonth(time) + "");

            return DbHelperSQL.GetScalar(strSql.ToString());
        }
        /// <summary>
        /// 查询回款总金额
        /// </summary>
        /// <returns></returns>
        public int GetBreakCount()
        { 
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select sum([breakmoney]) from stale_income");

            return DbHelperSQL.GetScalar(strSql.ToString());
        }

        private Model.Income_Model ReaderBind(SqlDataReader datareader)
        {
            Model.Income_Model model = new Model.Income_Model();
            object ojb;
            ojb = datareader["ID"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.ID = (int)ojb;
            }
            model.Party = datareader["Party"].ToString();
            model.B = datareader["B"].ToString();
            model.DemoName = datareader["DemoName"].ToString();
            ojb=datareader["Money"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Money = (decimal)ojb;
            }
            ojb = datareader["DemoCost"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.DemoCost = (decimal)ojb;
            }
            model.ContractNo = datareader["ContractNo"].ToString();
            ojb = datareader["Incometime"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Incometime = (DateTime)ojb;
            }
            model.EmpName = datareader["EmpName"].ToString();
            ojb = datareader["Deductap"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.Deductap = (decimal)ojb;
            }
            model.OperPerson = datareader["OperPerson"].ToString();
            model.IsBank = datareader["IsBank"].ToString();
            ojb = datareader["InvoiceMoney"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.InvoiceMoney = (decimal)ojb;
            }
            ojb = datareader["BreakMoney"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.BreakMoney = (decimal)ojb;
            }
            model.Remark = datareader["Remark"].ToString();
            model.Type = datareader["Type"].ToString();
            return model;
        }
                
        #endregion
    }
}
