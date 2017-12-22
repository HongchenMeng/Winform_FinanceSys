using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Web.Services;
using WebService1;

namespace FinanceSys.PublicLibrary
{
    public class DbHelperSQL
    {
        private static WebService1.Service1 SClient;
        /// <summary>
        /// 连接数据库的方法
        /// </summary>
        private static SqlConnection conn;
        public static SqlConnection ConnectionString
        {
            get
            {
                string str = ConfigurationSettings.AppSettings["conn"].ToString();

                conn = new SqlConnection(str);
                if (conn == null)
                {
                    conn.Open();
                }
                else if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                else if (conn.State == System.Data.ConnectionState.Broken)
                {
                    conn.Close();
                    conn.Open();
                }

                return conn;
            }
        }
        /// <summary>
        /// 返回SqlDataReader,无参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);

                SqlDataReader reader = comm.ExecuteReader();

                return reader;
                reader.Close();
            }
            catch(Exception ex) {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return null; 
            
            }
            finally
            {
                
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回SqlDataReader,有参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);
                comm.Parameters.AddRange(values);
                SqlDataReader reader = comm.ExecuteReader();
                return reader;
                reader.Close();
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return null;
            }
            finally {
               
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回DataTable,无参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDateSet(string sql)
        {
            try
            {
                DataSet Ds = new DataSet();

                SqlCommand comm = new SqlCommand(sql, ConnectionString);

                SqlDataAdapter Adapter = new SqlDataAdapter(comm);

                Adapter.Fill(Ds);

                return Ds.Tables[0];
            }
            catch(Exception ex) {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return null; }
            finally { ConnectionString.Close(); }
        }
        /// <summary>
        /// 返回DataTable,有参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static DataTable GetDateSet(string sql, params SqlParameter[] values)
        {
            try
            {
                DataSet Ds = new DataSet();

                SqlCommand comm = new SqlCommand(sql, ConnectionString);
                comm.Parameters.AddRange(values);
                SqlDataAdapter Adapter = new SqlDataAdapter(comm);

                Adapter.Fill(Ds);

                return Ds.Tables[0];
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return null;
            }
            finally {
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回第一行第一列,无参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int GetScalar(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);


                return Convert.ToInt32(comm.ExecuteScalar());
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return 0;
            }
            finally {
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回第一行第一列,有参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int GetScalar(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);
                comm.Parameters.AddRange(values);
                return Convert.ToInt32(comm.ExecuteScalar());
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return 0;
            }
            finally {
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回第一行第一列(String类型),无参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string ReturnStringScalar(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);

                return comm.ExecuteScalar().ToString();
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return null;
            }
            finally {
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回受影响的行数,无参数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);

                return comm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return 0;
            }
            finally
            {
                ConnectionString.Close();
            }
        }
        /// <summary>
        /// 返回受影响的行数,有参数
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int ExecuteCommand(string sql, params SqlParameter[] values)
        {
            try
            {
                SqlCommand comm = new SqlCommand(sql, ConnectionString);
                comm.Parameters.Clear();
                comm.Parameters.AddRange(values);
                               
                return comm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return 0;
            }
            finally
            {
                ConnectionString.Close();                
            }
        }
        /// <summary>
        /// 返回结果集分页
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="start">起始条数(从0开始) start+1 -- start+max</param>
        /// <param name="max">分页条数</param>
        public static DataTable GetDataTable_Page(string cmdText, int start, int max)
        {
            //创建一个新的数据适配器
            SqlDataAdapter custDA = new SqlDataAdapter();
            //创建一个新的 SqlCommand 对象
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectionString;
            cmd.CommandText = cmdText;           
            custDA.SelectCommand = cmd;
            DataSet ds = new DataSet();
            try
            {
                custDA.Fill(ds, start, max, "data");
            }
            catch(Exception ex)
            {
                SClient = new Service1();
                SClient.CreateFile(ex.Message, DateTime.Now.ToLongDateString());
                return null;
            }
            return ds.Tables["data"];
        }
    }
}
