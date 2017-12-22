using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FinanceSys.PersonnelSys.BLL
{
    public class Users_BLL
    {
        private DAL.Users_DAL DAL = new FinanceSys.PersonnelSys.DAL.Users_DAL();
        public bool Exists(string username)
        {
            return DAL.Exists(username);
        }

        public bool ValiedUser(string username, string userpwd, out Model.Users_Model usermodel)
        {
            return DAL.ValiedUser(username, userpwd, out usermodel);
        }

        public bool UpdatePwd(string username, string userpwd)
        {
            return DAL.UpdatePwd(username, userpwd);
        }
        public bool UpdateUname(string username, string name)
        {
            return DAL.UpdateUname(username, name);
        }

        public bool CheckPwd(string pwd)
        {
            return DAL.CheckPwd(pwd);
        }
        public bool AddUser(string username, string userpwd, string name)
        {
            if (DAL.AddUser(username, userpwd, name) == 1) return true; else return false;
        }
        public DataTable GetUserList()
        {
            return DAL.GetUserList();
        }
        public bool UpdateEnabled(int id, string isenabled)
        {
            return DAL.UpdateEnabled(id, isenabled);
        }
        public bool GetUserState(string username)
        {
            return DAL.GetUserState(username);
        }
        public bool DelUser(int id)
        {
            return DAL.DelUser(id);
        }
    }
}
