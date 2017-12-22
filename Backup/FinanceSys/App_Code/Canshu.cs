using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.App_Code
{
    public class Canshu
    {
        private static string _loginName;

        public static string LoginName
        {
            get { return _loginName; }
            set { _loginName = value; }
        }

        private static string _name;

        public static string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private static int _id;

        public static int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
