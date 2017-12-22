using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceSys.PublicLibrary
{

    public class CompanyInfo
    {
        #region Model
        private int _id;
        private string _name;
        private string _linkman;
        private string _adress;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkMan
        {
            set { _linkman = value; }
            get { return _linkman; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Adress
        {
            set { _adress = value; }
            get { return _adress; }
        }
        #endregion Model
    }
}
