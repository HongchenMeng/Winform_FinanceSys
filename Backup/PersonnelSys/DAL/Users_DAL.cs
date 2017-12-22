using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using FinanceSys.PublicLibrary;
using Model = FinanceSys.PersonnelSys.Model;

namespace FinanceSys.PersonnelSys.DAL
{
    public class Users_DAL
    {
        public bool Exists(string username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Stale_Users");
            strSql.Append(" where UserName=@UserName ");
            SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50)};
            parameters[0].Value = username;

            if (DbHelperSQL.GetScalar(strSql.ToString(), parameters) > 0) return true; else return false;
        }

        public bool ValiedUser(string username, string userpwd, out Model.Users_Model usermodel)
        {
            string sql = string.Format("select ID,UserName,UserPwd,Name from Stale_Users where username='{0}' and userpwd='{1}'", username, userpwd);
            SqlDataReader datareader = DbHelperSQL.GetReader(sql);
            Model.Users_Model model = new Model.Users_Model();
            if (datareader.Read())
            {
                model.ID = (int)datareader["ID"];
                model.UserName = datareader["UserName"].ToString();
                model.UserPwd = datareader["UserPwd"].ToString();
                model.Name = datareader["Name"].ToString();
            }
            if (model.UserName == username && model.UserPwd == userpwd)
            {
                usermodel = model;
                return true;
            }
            else
            {
                usermodel = null;
                return false;
            }
            datareader.Close();
            usermodel = null;
            return false;
        }

        public bool UpdatePwd(string username, string userpwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Users set UserPwd=@UserPwd ");
            strSql.Append(" where UserName=@UserName ");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@UserPwd",SqlDbType.NVarChar,50),
                new SqlParameter("@UserName",SqlDbType.NVarChar,50)
            };

            paraments[0].Value = userpwd;
            paraments[1].Value = username;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments) > 0) return true; else return false;
        }

        public bool UpdateUname(string username, string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Stale_Users set Name=@Name ");
            strSql.Append(" where UserName=@UserName ");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@Name",SqlDbType.NVarChar,50),
                new SqlParameter("@UserName",SqlDbType.NVarChar,50)
            };

            paraments[0].Value = name;
            paraments[1].Value = username;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments) > 0) return true; else return false;
        }

        public bool CheckPwd(string pwd)
        {
            string strSql = string.Format("select count(1) from Stale_Users where UserPwd='{0}'", pwd);

            if (DbHelperSQL.GetScalar(strSql) > 0) return true; else return false;
        }

        public int AddUser(string username, string userpwd, string name)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into stale_users(username,userpwd,name,IsEnabled) values(");
            strSql.Append("'" + username + "',");
            strSql.Append("'" + userpwd + "',");
            strSql.Append("'" + name + "' ,");
            strSql.Append("'是')");

            return DbHelperSQL.ExecuteCommand(strSql.ToString());
        }

        public DataTable GetUserList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select id as '编号',username as '用户名',[name] as '真实姓名',isenabled as '是否启用' ");
            strSql.Append(" from stale_users order by id desc");

            return DbHelperSQL.GetDateSet(strSql.ToString());
        }

        public bool UpdateEnabled(int id, string isenabled)
        {
            StringBuilder strSql = new StringBuilder();
            if (id > 0 && isenabled.Equals("是"))
            {
                strSql.Append("update stale_users set isenabled='是' where id=@id ");
            }
            if (id > 0 && isenabled.Equals("否"))
            {
                strSql.Append("update stale_users set isenabled='否' where id=@id ");
            }

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@id",SqlDbType.Int,4)
            };

            paraments[0].Value = id;

            if (DbHelperSQL.ExecuteCommand(strSql.ToString(), paraments) == 1) return true; else return false;
        }

        public bool GetUserState(string username)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select isenabled from stale_users ");
            strSql.Append(" where username=@username");

            SqlParameter[] paraments = new SqlParameter[] { 
                new SqlParameter("@username",SqlDbType.NVarChar,50)
            };

            paraments[0].Value = username;

            SqlDataReader reader = DbHelperSQL.GetReader(strSql.ToString(), paraments);
            string str = string.Empty;
            if (reader.Read())
                str = reader["isenabled"].ToString();
            if (str.Equals("是"))
                return true;
            else
                return false;
        }

        public bool DelUser(int id)
        {
            string sql = "delete stale_users where id=" + id;

            if (DbHelperSQL.ExecuteCommand(sql) > 0) return true; else return false;
        }
    }
}
