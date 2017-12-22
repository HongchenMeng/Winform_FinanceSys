using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Model = FinanceSys.FinanceManagerSys.Model;
using FinanceSys.PublicLibrary;
using System.Data;

namespace FinanceSys.FinanceManagerSys.DAL
{
    /// <summary>
    /// 数据访问类Stale_Invoice。
    /// </summary>
    public class Invoice_DAL
    {
        public Invoice_DAL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string invoiceno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Stale_Invoice");
            strSql.Append(" where InvoiceNo=@InvoiceNo ");
            SqlParameter[] parameters = {
					new SqlParameter("@InvoiceNo", SqlDbType.NVarChar,100)};
            parameters[0].Value = invoiceno;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters) == 1) return true; else return false;
        }
        /// <summary>
        /// 获取发票总金额
        /// </summary>
        /// <returns></returns>
        public int GetCountM()
        {
            string sql = "select sum([money]) from stale_invoice";

            return DbHelperSQL.GetScalar(sql);
        }
        /// <summary>
        /// 查询发票表中是否有合同编号
        /// 有：插入发票明细表
        /// 没：插入发票表
        /// </summary>
        /// <param name="contractno"></param>
        /// <returns></returns>
        public int ExistsContract(string contractno)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Stale_Invoice");
            strSql.Append(" where contractno='" + contractno + "'");

            return DbHelperSQL.ExecuteCommand(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Model.Invoice_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Stale_Invoice(");
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
                    new SqlParameter("@ContractNo", SqlDbType.NVarChar,100)};
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

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(Model.Invoice_Model model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Invoice set ");
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
            strSql.Append("Remark=@Remark,");
            strSql.Append("ContractNo=@ContractNo");
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
					new SqlParameter("@Remark", SqlDbType.NVarChar,100),
                                        new SqlParameter("@ContractNo", SqlDbType.NVarChar,100)};
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
            parameters[12].Value = model.ContractNo;
            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Stale_Invoice ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.ExecuteCommand(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Invoice_Model GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo from Stale_Invoice ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Model.Invoice_Model model = new Model.Invoice_Model();
            DataTable dt = DbHelperSQL.GetDateSet(strSql.ToString(), parameters);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                }
                model.InvoiceNo = dt.Rows[0]["InvoiceNo"].ToString();
                model.LTDName = dt.Rows[0]["LTDName"].ToString();
                model.DemoName = dt.Rows[0]["DemoName"].ToString();
                if (dt.Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(dt.Rows[0]["Money"].ToString());
                }
                if (dt.Rows[0]["Invoicetime"].ToString() != "")
                {
                    model.Invoicetime = DateTime.Parse(dt.Rows[0]["Invoicetime"].ToString());
                }
                model.Payment = dt.Rows[0]["Payment"].ToString();
                model.Status = dt.Rows[0]["Status"].ToString();
                model.Handling = dt.Rows[0]["Handling"].ToString();
                model.EmpName = dt.Rows[0]["EmpName"].ToString();
                model.IsBank = dt.Rows[0]["IsBank"].ToString();
                model.Remark = dt.Rows[0]["Remark"].ToString();
                model.ContractNo = dt.Rows[0]["ContractNo"].ToString();
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo ");
            strSql.Append(" FROM Stale_Invoice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 获取分页总数
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            string sql = "select count(*) from stale_invoice";

            return DbHelperSQL.GetScalar(sql);
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
            strSql.Append(" ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo ");
            strSql.Append(" FROM Stale_Invoice ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.GetDateSet(strSql.ToString());
        }

        /// <summary>
        /// 查询每页显示的数量
        /// 参数：当前页
        /// </summary>
        /// <param name="pagenum"></param>
        /// <returns></returns>
        public DataTable GetInvoiceIList(int pagenum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP 15 ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo FROM Stale_Invoice ");
            strSql.Append(" WHERE ID >(SELECT ISNULL(MAX(ID),0) FROM ");
            strSql.Append("(SELECT TOP (15*(" + pagenum + "-1)) ID FROM Stale_Invoice ORDER BY ID");
            strSql.Append(") A)ORDER BY ID");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }
        /// <summary>
        /// 得到资产信息(分页)
        /// </summary>
        /// <param name="start">起始页</param>
        /// <param name="max">最大条数</param>
        /// <returns></returns>
        public DataTable getInvoiceList(int start, int max)
        {
            string sql = "select ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo from Stale_Invoice";

            DataTable dt = DbHelperSQL.GetDataTable_Page(sql, start, max);
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
        /// 得到信息的总页数
        /// </summary>
        /// <returns></returns>
        public int getTotalPage()
        {
            string sql = "select count(*) from Stale_Invoice";

            return DbHelperSQL.GetScalar(sql);

        }
        /// <summary>
        /// 查询项目金额
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int GetInvoiceMoneyByContractNo(string contract)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [money] from stale_invoice ");
            strSql.Append(" where ContractNo='" + contract + "'");

            return DbHelperSQL.GetScalar(strSql.ToString());
        }
        /// <summary>
        /// 查询公司名称
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public string GetInvoiceLtdName(string contract)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select LTDName from stale_invoice ");
            //strSql.Append(" where ContractNo='" + contract + "'");
            strSql.Append(" where id='" + contract + "'");

            string str = string.Empty;

            SqlDataReader datareader = DbHelperSQL.GetReader(strSql.ToString());

            if (datareader.Read())
            {
                str = datareader["LTDName"].ToString();
            }

            return str;
        }
        
        /// <summary>
        /// 查询公司信息
        /// </summary>
        /// <param name="ltdname"></param>
        /// <returns></returns>
        public Model.Invoice_Model GetInvoiceInfoByLtdName(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,InvoiceNo,LTDName,DemoName,Money,Invoicetime,Payment,Status,Handling,EmpName,IsBank,Remark,ContractNo ");
            strSql.Append(" from stale_invoice where id=" + id);

            SqlDataReader reader = DbHelperSQL.GetReader(strSql.ToString());
            Model.Invoice_Model model = new FinanceSys.FinanceManagerSys.Model.Invoice_Model();
            object ojb = new object();
            if (reader.Read())
            {
                ojb = reader["id"];
                if (ojb != null)
                {
                    model.ID = (int)ojb;
                }
                model.InvoiceNo = reader["InvoiceNo"].ToString();
                model.LTDName = reader["LTDName"].ToString();
                model.DemoName = reader["DemoName"].ToString();
                ojb = reader["Money"];
                if (ojb != null)
                {
                    model.Money = (decimal)ojb;
                }
                ojb = reader["Invoicetime"];
                if (ojb != null)
                {
                    model.Invoicetime = (DateTime)ojb;
                }
                model.Payment = reader["Payment"].ToString();
                model.Status = reader["Status"].ToString();
                model.Handling = reader["Handling"].ToString();
                model.EmpName = reader["EmpName"].ToString();
                model.IsBank = reader["IsBank"].ToString();
                model.Remark = reader["Remark"].ToString();
                model.ContractNo = reader["ContractNo"].ToString();
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 查询ID编号是否存在
        /// 如果存在已开过发票
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool GetIsCount(int id)
        {
            string sql = "select id from stale_invoice where id=" + id;
            if (DbHelperSQL.GetScalar(sql) > 0)
                return true;
            else
                return false;
        }
        public void UpdateInvoice(decimal money, string state,int id)
        {
            string sql = string.Format("update Stale_Invoice set [money]=[money]+{0},Status='{1}' where id={2}", money, state, id);

            DbHelperSQL.ExecuteCommand(sql);
        }
        public void UpdateState(string state)
        {
            string sql = string.Format("update Stale_Invoice set  Status='{1}'",  state);

            DbHelperSQL.ExecuteCommand(sql);
        }
        #endregion
    }
}